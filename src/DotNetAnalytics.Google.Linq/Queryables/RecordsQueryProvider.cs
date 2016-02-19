using System.Collections.Generic;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Linq.Core;
using DotNetAnalytics.Google.Linq.RecordQueries;
using DotNetAnalytics.Google.Queries;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queryables
{
    /// <summary>
    /// A LINQ Provider that executes API Queries over an API Client
    /// </summary>
    public class RecordsQueryProvider<T> : QueryProvider where T : IRecord
    {
        private readonly IReportingClient _client;

        public RecordsQueryProvider(IReportingClient client)
        {
            _client = client;
        }

        private static QueryableRecordQuery Translate(Expression expression)
        {
            expression = Evaluator.PartialEval(expression);
            return new RecordsQueryTranslator().Translate(expression);
        }

        public override object Execute(Expression expression)
        {
            var query = Translate(expression);
            int? totalRecords;
            return query.QueryAll
                ? _client.GetAllRecords(query)
                : _client.GetRecords(query, out totalRecords, query.StartIndex ?? 1,
                    query.RecordsCount ?? RecordQuery.MaxRecordsPerQuery);
        }
    }
}
