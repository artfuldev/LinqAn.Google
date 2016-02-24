using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LinqAn.Google.Linq.Core
{
    public interface IAsyncQueryProvider : IQueryProvider
    {
        Task<object> ExecuteAsync(Expression query);
        Task<TResult> ExecuteAsync<TResult>(Expression query);
    }
}