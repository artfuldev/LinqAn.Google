using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queries
{
    /// <summary>
    /// Allows fluent querying of an <seealso cref="IRecord"/> by chaining
    /// and also the use of <seealso cref="IQueryObject{T}"/> instances.
    /// </summary>
    /// <typeparam name="T">The <seealso cref="IRecord"/> for which the fluent querying
    /// is done.</typeparam>
    public interface IQueryFluent<T>  where T : IRecord
    {
        IQueryFluent<T> OrderBy(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy);
        IQueryFluent<T> Include(Expression<Func<T, IDimension>> dimensionExpression);
        IQueryFluent<T> Include(Expression<Func<T, IMetric>> metricExpression);
        IEnumerable<T> SelectPage(int page, int pageSize, out int totalCount);
        IEnumerable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector = null);
        IEnumerable<T> Select();
        Task<IEnumerable<T>> SelectAsync();
    }
}