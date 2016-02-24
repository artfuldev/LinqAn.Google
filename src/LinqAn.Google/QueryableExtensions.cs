using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Records;

namespace LinqAn.Google
{
    public static class QueryableExtensions
    {
        public static IQueryable<IRecord> Include<T>(this IQueryable<IRecord> query,
            Expression<Func<IRecord, T>> includeExpression)
        {
            var provider = query.Provider;
            var method = provider.GetType().GetMethod("Include");
            method = method?.MakeGenericMethod(typeof(T));
            method?.Invoke(provider, new object[] { includeExpression });
            return query;
        }

        public static async Task<List<IRecord>> ToListAsync(this IQueryable<IRecord> query)
        {
            var queryExpression = query.Expression;
            var asyncProvider = query.Provider as IAsyncQueryProvider;
            return asyncProvider != null
                ? (await asyncProvider.ExecuteAsync<IEnumerable<IRecord>>(queryExpression)).ToList()
                : (await Task.Run(() => query.Provider.Execute<IEnumerable<IRecord>>(queryExpression))).ToList();
        } 
    }
}