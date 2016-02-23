using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Google.Apis.Analytics.v3;
using Google.Apis.Services;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Linq.RecordQueries;
using LinqAn.Google.Metrics;
using LinqAn.Google.Profiles;
using LinqAn.Google.Queries;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    /// <summary>
    ///     A LINQ Provider that executes API Queries over an API Client
    /// </summary>
    internal class RecordsQueryProvider : QueryProvider
    {
        private readonly IAnalyticsProfile _profile;
        private readonly BaseClientService.Initializer _initializer;
        private List<object> _includes;

        public RecordsQueryProvider(BaseClientService.Initializer initializer)
        {
            _initializer = initializer;
        }

        public RecordsQueryProvider(IAnalyticsProfile profile)
        {
            _profile = profile;
        }

        public List<object> Includes
        {
            get { return _includes ?? (_includes = new List<object>()); }
            set { _includes = value; }
        }

        public void Include<TProperty>(Expression<Func<IRecord, TProperty>> includeExpression)
        {
            if (includeExpression == null)
                throw new ArgumentNullException(nameof(includeExpression));
            if (!typeof(IDimension).IsAssignableFrom(typeof(TProperty)) && !typeof(IMetric).IsAssignableFrom(typeof(TProperty)))
                throw new InvalidOperationException("Only metrics and dimensions can be included.");
            var instance = Activator.CreateInstance<TProperty>();
            Includes.Add(instance);
        }

        private static TranslateResult Translate(Expression expression)
        {
            expression = Evaluator.PartialEval(expression);
            return new RecordsQueryTranslator().Translate(expression);
        }

        public override object Execute(Expression expression)
        {
            var translateResult = Translate(expression);
            var query = translateResult.Query;
            query.DimensionsList = Includes.OfType<IDimension>().ToList();
            query.MetricsList = Includes.OfType<IMetric>().ToList();
            using (var client = _profile == null ? new ReportingClient(_initializer) : new ReportingClient(_profile))
            {
                int? totalRecords;
                var records = query.QueryAll
                    ? client.GetAllGaData(query)
                    : client.GetGaData(query, out totalRecords, query.StartIndex ?? 1,
                        query.RecordsCount ?? RecordQuery.MaxRecordsPerQuery);
                if (translateResult.Projector == null)
                    return Activator.CreateInstance(typeof (RecordReader), records);
                var elementType = GetElementType(expression.Type);
                var projector = translateResult.Projector.Compile();
                return Activator.CreateInstance(
                    typeof (ProjectionReader<>).MakeGenericType(elementType),
                    BindingFlags.Instance | BindingFlags.NonPublic, null,
                    new object[] {records, projector},
                    null
                    );
            }
        }

        public static Type GetElementType(Type seqType)
        {
            var ienum = FindIEnumerable(seqType);
            return ienum == null ? seqType : ienum.GetGenericArguments()[0];
        }

        public static Type FindIEnumerable(Type seqType)
        {
            if (seqType == null || seqType == typeof(string))
                return null;
            if (seqType.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(seqType.GetElementType());
            if (seqType.IsGenericType)
            {
                foreach (var ienum in seqType.GetGenericArguments().Select(arg => typeof(IEnumerable<>).MakeGenericType(arg)).Where(ienum => ienum.IsAssignableFrom(seqType)))
                {
                    return ienum;
                }
            }
            var ifaces = seqType.GetInterfaces();
            if (ifaces.Length > 0)
            {
                foreach (var ienum in ifaces.Select(FindIEnumerable).Where(ienum => ienum != null))
                {
                    return ienum;
                }
            }
            if (seqType.BaseType != null && seqType.BaseType != typeof(object))
            {
                return FindIEnumerable(seqType.BaseType);
            }
            return null;
        }
    }
}