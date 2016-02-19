using System.Collections.Generic;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Linq.Core;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queryables
{
    /// <summary>
    /// A LINQ Provider that executes API Queries over an API Client
    /// </summary>
    public class RecordsQueryProvider<T> : QueryProvider where T : IRecord
    {
        private readonly IClient<T> _client;

        public RecordsQueryProvider(IClient<T> client)
        {
            _client = client;
        }

        private static IDictionary<string, string> Translate(Expression expression)
        {
            expression = Evaluator.PartialEval(expression);
            return new RecordsQueryTranslator().Translate(expression);
        }

        public override object Execute(Expression expression)
        {
            var dictionary = Translate(expression);
            var filter = new SearchFilter(dictionary);
            string id;
            if (dictionary.TryGetValue("Id", out id))
                return _client.GetAsync(int.Parse(id));
            return _client.GetAsync(filter);
        }
    }
}
