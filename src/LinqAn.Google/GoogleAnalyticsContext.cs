using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Profiles;

namespace LinqAn.Google
{
    public sealed class GoogleAnalyticsContext : IAnalyticsContext
    {
        private readonly IAnalyticsProfile _profile;

        public GoogleAnalyticsContext(IAnalyticsProfile profile)
        {
            _profile = profile;
        }

        public RecordsDataSet Records => new RecordsDataSet(_profile);
    }
}