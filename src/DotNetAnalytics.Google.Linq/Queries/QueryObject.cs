using System;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queries
{
    public abstract class QueryObject : IQueryObject
    {
        private Expression<Func<IRecord, bool>> _query;

        private static Expression<Func<IRecord, bool>> And(Expression<Func<IRecord, bool>> left, Expression<Func<IRecord, bool>> right)
        {
            var body = Expression.AndAlso(left.Body, right.Body);
            var lambda = Expression.Lambda<Func<IRecord, bool>>(body, left.Parameters[0]);
            return lambda;
        }

        private static Expression<Func<IRecord, bool>> Or(Expression<Func<IRecord, bool>> left, Expression<Func<IRecord, bool>> right)
        {
            var body = Expression.OrElse(left.Body, right.Body);
            var lambda = Expression.Lambda<Func<IRecord, bool>>(body, left.Parameters[0]);
            return lambda;
        }

        public Expression<Func<IRecord, bool>> Query()
        {
            return _query;
        }

        public Expression<Func<IRecord, bool>> And(Expression<Func<IRecord, bool>> query)
        {
            return _query = _query == null ? query : And(_query, query);
        }

        public Expression<Func<IRecord, bool>> Or(Expression<Func<IRecord, bool>> query)
        {
            return _query = _query == null ? query : Or(_query, query);
        }

        public Expression<Func<IRecord, bool>> And(IQueryObject queryObject)
        {
            return And(queryObject.Query());
        }

        public Expression<Func<IRecord, bool>> Or(IQueryObject queryObject)
        {
            return Or(queryObject.Query());
        }
    }
}