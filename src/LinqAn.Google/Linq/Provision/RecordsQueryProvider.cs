using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Google.Apis.Services;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Linq.Resolution;
using LinqAn.Google.Linq.Translation;
using LinqAn.Google.Metrics;
using LinqAn.Google.Profiles;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Provision
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
                if (translateResult.Selector == null)
                    return new RecordReader(records);
                var projector = translateResult.Selector.Compile();
                var returnType = projector.GetType().GenericTypeArguments[1];
                return Activator.CreateInstance(typeof (ProjectionReader<>).MakeGenericType(returnType),
                    BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] {records, projector});
            }
        }
    }
}