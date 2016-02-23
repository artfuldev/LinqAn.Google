using System.Linq.Expressions;
using LinqAn.Google.Linq.Provision;

namespace LinqAn.Google.Linq.Queryables
{
    internal class TranslateResult
    {
        internal RecordQuery Query;
        internal LambdaExpression Selector;
    }
}