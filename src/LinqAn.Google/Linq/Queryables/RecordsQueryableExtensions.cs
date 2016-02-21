using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public static class RecordsQueryableExtensions
    {
        public static IEnumerable<IRecord> AsEnumerable(this IQueryable<IQueryableRecord> source)
        {
            return source.Provider.Execute<IEnumerable<IRecord>>(source.Expression);
        }

        public static Task<List<IRecord>> ToListAsync(this IQueryable<IQueryableRecord> source)
        {
            return Task.FromResult(source.AsEnumerable().ToList());
        }

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