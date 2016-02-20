using System;
using System.Linq.Expressions;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queries
{
    /// <summary>
    ///     An object that is used to query for an <seealso cref="IRecord" />
    ///     for a number of <seealso cref="IRecord" /> objects.
    /// </summary>
    public interface IQueryObject
    {
        Expression<Func<IRecord, bool>> Query();
        Expression<Func<IRecord, bool>> And(Expression<Func<IRecord, bool>> query);
        Expression<Func<IRecord, bool>> Or(Expression<Func<IRecord, bool>> query);
        Expression<Func<IRecord, bool>> And(IQueryObject queryObject);
        Expression<Func<IRecord, bool>> Or(IQueryObject queryObject);
    }
}