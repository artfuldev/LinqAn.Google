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
        public static IEnumerable<IQueryableRecord> AsEnumerable(this IQueryable<IQueryableRecord> source)
        {
            return source.Provider.Execute<IEnumerable<IQueryableRecord>>(source.Expression);
        }

        public static Task<List<IQueryableRecord>> ToListAsync(this IQueryable<IQueryableRecord> source)
        {
            return Task.FromResult(source.AsEnumerable().ToList());
        }

        public static IQueryable<IQueryableRecord> Include<T>(this IQueryable<IQueryableRecord> source,
            Expression<Func<IQueryableRecord, T>> includeExpression)
        {
            var method = source.Provider.GetType()
                .GetRuntimeMethod("Include", new[] { typeof(Expression<Func<IQueryableRecord, T>>) });
            method?.Invoke(source, new object[] { includeExpression });
            return source;
        }
    }
}