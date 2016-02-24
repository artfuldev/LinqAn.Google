using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace LinqAn.Google.Linq.Core
{
    public interface IAsyncQueryProvider : IQueryProvider
    {
        Task<object> ExecuteAsync(Expression query, CancellationToken token = default(CancellationToken));
        Task<TResult> ExecuteAsync<TResult>(Expression query, CancellationToken token = default(CancellationToken));
    }
}