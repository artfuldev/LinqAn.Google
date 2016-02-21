using System.Collections.Generic;
using System.Linq;
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
    }
}