using LinqAn.Google.Linq.Queryables;

namespace LinqAn.Google
{
    public interface IAnalyticsContext
    {
        RecordsDataSet Records { get; }
    }
}