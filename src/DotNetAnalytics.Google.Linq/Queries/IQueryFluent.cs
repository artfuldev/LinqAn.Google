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
    /// and also the use of <seealso cref="IQueryObject"/> instances.
    /// </summary>
    public interface IQueryFluent
    {
        IQueryFluent OrderBy(Func<IQueryable<IRecord>, IOrderedQueryable<IRecord>> orderBy);
        IQueryFluent Include(Expression<Func<IRecord, IDimension>> dimensionExpression);
        IQueryFluent Include(Expression<Func<IRecord, IMetric>> metricExpression);
        IEnumerable<IRecord> SelectPage(int page, int pageSize, out int totalCount);
        IEnumerable<TResult> Select<TResult>(Expression<Func<IRecord, TResult>> selector = null);
        IEnumerable<IRecord> Select();
        Task<IEnumerable<IRecord>> SelectAsync();
    }
}