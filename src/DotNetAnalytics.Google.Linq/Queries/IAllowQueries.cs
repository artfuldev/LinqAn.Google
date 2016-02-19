using System.Linq;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queries
{
    public interface IAllowQueries<out T> where T : IRecord
    {
        IQueryable<T> SelectQuery(string query, params object[] parameters);
        IQueryable<T> Queryable();
    }
}
