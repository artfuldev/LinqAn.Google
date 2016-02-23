using System.Linq.Expressions;
using LinqAn.Google.Linq.RecordQueries;

namespace LinqAn.Google.Linq.Queryables
{
    internal class TranslateResult
    {
        internal QueryableRecordQuery Query;
        internal LambdaExpression Projector;
    }
}