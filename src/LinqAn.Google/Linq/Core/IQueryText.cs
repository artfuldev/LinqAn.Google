using System.Linq;
using System.Linq.Expressions;

namespace LinqAn.Google.Linq.Core
{
    /// <summary>
    /// Optional interface for <seealso cref="IQueryProvider"/> to implement <seealso cref="Query{T}"/>'s QueryText property.
    /// </summary>
    public interface IQueryText
    {
        string GetQueryText(Expression expression);
    }
}