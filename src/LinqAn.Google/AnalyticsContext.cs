using Google.Apis.Analytics.v3;
using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Profiles;

namespace LinqAn.Google
{
    public sealed class AnalyticsContext : IAnalyticsContext
    {
        private readonly IAnalyticsProfile _profile;
        private readonly AnalyticsService _service;

        // TODO: Create service from _service
        private AnalyticsService Service => new AnalyticsService();

        public AnalyticsContext(AnalyticsService service)
        {
            _service = service;
        }

        public AnalyticsContext(IAnalyticsProfile profile)
        {
            _profile = profile;
        }

        public RecordsDataSet Records => _profile == null ? new RecordsDataSet(Service) : new RecordsDataSet(_profile);
    }
}