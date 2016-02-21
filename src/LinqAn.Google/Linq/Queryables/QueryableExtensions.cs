using System.Linq;
using System.Linq.Expressions;
using LinqAn.Google.Records;
using System;
using System.Globalization;
using System.Reflection;

namespace LinqAn.Google.Linq.Queryables
{
    public static class QueryableExtensions
    {
        public static IQueryable<IQueryableRecord> Include<T>(this IQueryable<IQueryableRecord> source,
            Expression<Func<IQueryableRecord, T>> includeExpression)
        {
            var method = source.GetType()
                .GetRuntimeMethod("Include", new[] {typeof (Expression<Func<IQueryableRecord, T>>)});
            method?.Invoke(source, new object[] {includeExpression});
            return source;
        }
    }
}