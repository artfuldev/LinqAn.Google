using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Profiles;

namespace LinqAn.Google
{
    public sealed class AnalyticsContext : IAnalyticsContext
    {
        private readonly IAnalyticsProfile _profile;

        public AnalyticsContext(IAnalyticsProfile profile)
        {
            _profile = profile;
        }

        public RecordsDataSet Records => new RecordsDataSet(_profile);
    }
}