using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public static class RecordsQueryableExtensions
    {
        public static IEnumerable<IRecord> AsEnumerable(this IQueryable<IRecord> source)
        {
            return source.Provider.Execute<IEnumerable<IRecord>>(source.Expression);
        }

        public static Task<List<IRecord>> ToListAsync(this IQueryable<IRecord> source)
        {
            return Task.FromResult(source.AsEnumerable().ToList());
        }
    }
}
