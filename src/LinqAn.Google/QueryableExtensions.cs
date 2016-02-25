using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Linq.Provision;
using LinqAn.Google.Metrics;
using LinqAn.Google.Records;

namespace LinqAn.Google
{
    public static class QueryableExtensions
    {
        public static IQueryable<IRecord> Include<TProperty>(this IQueryable<IRecord> query,
            Expression<Func<IRecord, TProperty>> includeExpression) where TProperty : class, new()
        {
            var provider = query.Provider as IInclusionProvider;
            if (provider == null)
                return query;
            if (includeExpression == null)
                throw new ArgumentNullException(nameof(includeExpression));
            if (!typeof (IDimension).IsAssignableFrom(typeof (TProperty)) &&
                !typeof (IMetric).IsAssignableFrom(typeof (TProperty)))
                throw new InvalidOperationException("Only metrics and dimensions can be included.");
            provider.Include(includeExpression);
            return query;
        }

        public static async Task<List<IRecord>> ToListAsync(this IQueryable<IRecord> query, CancellationToken token = default(CancellationToken))
        {
            var queryExpression = query.Expression;
            var asyncProvider = query.Provider as IAsyncQueryProvider;
            var enumerable = asyncProvider != null
                ? (await asyncProvider.ExecuteAsync<IEnumerable<IRecord>>(queryExpression, token))
                : (await Task.Run(() => query.Provider.Execute<IEnumerable<IRecord>>(queryExpression), token));
            return enumerable?.ToList() ?? new List<IRecord>();
        } 
    }
}