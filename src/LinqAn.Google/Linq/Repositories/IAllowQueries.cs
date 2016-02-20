using System.Linq;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Repositories
{
    public interface IAllowQueries<out T> where T : IRecord
    {
        IQueryable<T> Queryable();
    }
}
