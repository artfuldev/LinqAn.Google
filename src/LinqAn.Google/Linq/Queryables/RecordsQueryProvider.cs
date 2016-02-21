using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Linq.RecordQueries;
using LinqAn.Google.Metrics;
using LinqAn.Google.Queries;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    /// <summary>
    ///     A LINQ Provider that executes API Queries over an API Client
    /// </summary>
    internal class RecordsQueryProvider : QueryProvider
    {
        private readonly IReportingClient _client;
        private List<object> _includes;

        public RecordsQueryProvider(IReportingClient client)
        {
            _client = client;
        }

        public List<object> Includes
        {
            get { return _includes ?? (_includes = new List<object>()); }
            set { _includes = value; }
        }

        public void Include<TProperty>(Expression<Func<IQueryableRecord, TProperty>> includeExpression)
        {
            if (includeExpression == null)
                throw new ArgumentNullException(nameof(includeExpression));
            if (!typeof(IDimension).IsAssignableFrom(typeof(TProperty)) && !typeof(IMetric).IsAssignableFrom(typeof(TProperty)))
                throw new InvalidOperationException("Only metrics and dimensions can be included.");
            var instance = Activator.CreateInstance<TProperty>();
            Includes.Add(instance);
        }

        private static QueryableRecordQuery Translate(Expression expression)
        {
            expression = Evaluator.PartialEval(expression);
            return new RecordsQueryTranslator().Translate(expression);
        }

        public override object Execute(Expression expression)
        {
            var query = Translate(expression);
            query.DimensionsList = Includes.OfType<IDimension>().ToList();
            query.MetricsList = Includes.OfType<IMetric>().ToList();
            int? totalRecords;
            return query.QueryAll
                ? _client.GetAllQueryableRecords(query)
                : _client.GetQueryableRecords(query, out totalRecords, query.StartIndex ?? 1,
                    query.RecordsCount ?? RecordQuery.MaxRecordsPerQuery);
        }
    }
}