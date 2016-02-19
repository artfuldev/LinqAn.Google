using System;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queries
{
    /// <summary>
    /// An object that is used to query for an <seealso cref="IRecord"/>
    /// for a number of <seealso cref="IRecord"/> objects.
    /// </summary>
    /// <typeparam name="T">The type of <seealso cref="IRecord"/> this  query
    /// object is for</typeparam>
    public interface IQueryObject<T> where T : IRecord
    {
        Expression<Func<T, bool>> Query();
        Expression<Func<T, bool>> And(Expression<Func<T, bool>> query);
        Expression<Func<T, bool>> Or(Expression<Func<T, bool>> query);
        Expression<Func<T, bool>> And(IQueryObject<T> queryObject);
        Expression<Func<T, bool>> Or(IQueryObject<T> queryObject);
    }
}