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
    /// <summary>
    ///     Provides useful extension methods for the queryable records.
    /// </summary>
    public static class QueryableExtensions
    {
        /// <summary>
        ///     Includes a dimension or metric in the query for records to be retrieved from Google Analytics.
        /// </summary>
        /// <typeparam name="TProperty">The dimension or metric to include in the record.</typeparam>
        /// <param name="query">The query in which to include the dimension or metric.</param>
        /// <param name="includeExpression">The include expression.</param>
        /// <returns>A query for the records in which the specified dimension or metric is included.</returns>
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

        /// <summary>
        ///     Asynchronously queries the records and returns a list of <seealso cref="IRecord" /> when the querying is complete.
        /// </summary>
        /// <param name="query">The query for which the <seealso cref="IRecord" />s are to be returned as a list.</param>
        /// <param name="token">The cancellation token for the <seealso cref="Task" />, if any.</param>
        /// <returns>A list of <seealso cref="IRecord" />s that match the query.</returns>
        public static async Task<List<IRecord>> ToListAsync(this IQueryable<IRecord> query,
            CancellationToken token = default(CancellationToken))
        {
            var queryExpression = query.Expression;
            var asyncProvider = query.Provider as IAsyncQueryProvider;
            var enumerable = asyncProvider != null
                ? await asyncProvider.ExecuteAsync<IEnumerable<IRecord>>(queryExpression, token)
                : await Task.Run(() => query.Provider.Execute<IEnumerable<IRecord>>(queryExpression), token);
            return enumerable?.ToList() ?? new List<IRecord>();
        }
    }
}