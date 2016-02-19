using System;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Linq.Queries;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Repositories
{
    public interface IAllowFluentQueries<T> where T : IRecord
    {
        IQueryFluent<T> Query(IQueryObject<T> queryObject);
        IQueryFluent<T> Query(Expression<Func<T, bool>> query);
        IQueryFluent<T> Query();
    }
}
