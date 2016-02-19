using System;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queries
{
    public abstract class QueryObject<T> : IQueryObject<T> where T : IRecord
    {
        private Expression<Func<T, bool>> _query;

        private static Expression<Func<T, bool>> And(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var body = Expression.AndAlso(left.Body, right.Body);
            var lambda = Expression.Lambda<Func<T, bool>>(body, left.Parameters[0]);
            return lambda;
        }

        private static Expression<Func<T, bool>> Or(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var body = Expression.OrElse(left.Body, right.Body);
            var lambda = Expression.Lambda<Func<T, bool>>(body, left.Parameters[0]);
            return lambda;
        }

        public Expression<Func<T, bool>> Query()
        {
            return _query;
        }

        public Expression<Func<T, bool>> And(Expression<Func<T, bool>> query)
        {
            return _query = _query == null ? query : And(_query, query);
        }

        public Expression<Func<T, bool>> Or(Expression<Func<T, bool>> query)
        {
            return _query = _query == null ? query : Or(_query, query);
        }

        public Expression<Func<T, bool>> And(IQueryObject<T> queryObject)
        {
            return And(queryObject.Query());
        }

        public Expression<Func<T, bool>> Or(IQueryObject<T> queryObject)
        {
            return Or(queryObject.Query());
        }
    }
}