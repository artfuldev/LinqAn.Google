using System;
using System.Linq.Expressions;
using LinqAn.Google.Linq.Queries;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Repositories
{
    public interface IAllowFluentQueries
    {
        IQueryFluent Query(IQueryObject queryObject);
        IQueryFluent Query(Expression<Func<IRecord, bool>> query);
        IQueryFluent Query();
    }
}
