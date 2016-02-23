using Google.Apis.Analytics.v3;
using Google.Apis.Services;
using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Profiles;

namespace LinqAn.Google
{
    public sealed class AnalyticsContext : IAnalyticsContext
    {
        private readonly IAnalyticsProfile _profile;
        private readonly BaseClientService.Initializer _initializer;

        public AnalyticsContext(BaseClientService.Initializer initializer)
        {
            _initializer = initializer;
        }

        public AnalyticsContext(IAnalyticsProfile profile)
        {
            _profile = profile;
        }

        public RecordsDataSet Records
            => _profile == null ? new RecordsDataSet(_initializer) : new RecordsDataSet(_profile);
    }
}