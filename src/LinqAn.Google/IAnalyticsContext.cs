using System.Linq;
using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Records;

namespace LinqAn.Google
{
    public interface IAnalyticsContext
    {
        IOrderedQueryable<IRecord> Records { get; }
    }
}