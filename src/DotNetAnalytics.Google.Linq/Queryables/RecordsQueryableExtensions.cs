using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queryables
{
    public static class RecordsQueryableExtensions
    {
        public static async Task<List<T>> ToListAsync<T>(this IQueryable<T> source) where T : IRecord
        {
            return (await source.Provider.Execute<Task<IEnumerable<T>>>(source.Expression)).ToList();
        }

        public static async Task<T> FirstAsync<T>(this IQueryable<T> source) where T : IRecord
        {
            return (await source.Provider.Execute<Task<T>>(source.Expression));
        }
    }
}
