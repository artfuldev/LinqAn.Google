using System;
using System.Linq;
using System.Linq.Expressions;
using LinqAn.Google.Records;

namespace LinqAn.Google
{
    public static class QueryableExtensions
    {
        public static IQueryable<IRecord> Include<T>(this IQueryable<IRecord> source,
            Expression<Func<IRecord, T>> includeExpression)
        {
            var provider = source.Provider;
            var method = provider.GetType().GetMethod("Include");
            method = method?.MakeGenericMethod(typeof(T));
            method?.Invoke(provider, new object[] { includeExpression });
            return source;
        }
    }
}