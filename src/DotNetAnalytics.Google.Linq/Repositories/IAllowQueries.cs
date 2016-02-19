using System.Linq;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Repositories
{
    public interface IAllowQueries<out T> where T : IRecord
    {
        IQueryable<T> Queryable();
    }
}
