using System;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Linq.Queries;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Repositories
{
    public interface IAllowFluentQueries
    {
        IQueryFluent Query(IQueryObject queryObject);
        IQueryFluent Query(Expression<Func<IRecord, bool>> query);
        IQueryFluent Query();
    }
}
