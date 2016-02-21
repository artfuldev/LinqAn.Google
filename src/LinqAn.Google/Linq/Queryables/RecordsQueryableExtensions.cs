using System;
using System.Linq;
using System.Linq.Expressions;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public static class RecordsQueryableExtensions
    {
        public static IQueryable<IQueryableRecord> Include<T>(this IQueryable<IQueryableRecord> source,
            Expression<Func<IQueryableRecord, T>> includeExpression)
        {
            var provider = source.Provider;
            var method = provider.GetType().GetMethod("Include");
            method = method?.MakeGenericMethod(typeof(T));
            method?.Invoke(provider, new object[] { includeExpression });
            return source;
        }
    }
}