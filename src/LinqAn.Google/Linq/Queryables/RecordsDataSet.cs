using System;
using System.Linq.Expressions;
using Google.Apis.Analytics.v3;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Profiles;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public class RecordsDataSet : Query<IRecord>
    {
        public RecordsDataSet(IAnalyticsProfile profile)
            : base(new RecordsQueryProvider(profile))
        {
        }

        public RecordsDataSet(IAnalyticsProfile profile, Type staticType)
            : base(new RecordsQueryProvider(profile), staticType)
        {
        }

        public RecordsDataSet(IAnalyticsProfile profile, Expression expression)
            : base(new RecordsQueryProvider(profile), expression)
        {
        }

        public RecordsDataSet(AnalyticsService service)
            : base(new RecordsQueryProvider(service))
        {
        }

        public RecordsDataSet(AnalyticsService service, Type staticType)
            : base(new RecordsQueryProvider(service), staticType)
        {
        }

        public RecordsDataSet(AnalyticsService service, Expression expression)
            : base(new RecordsQueryProvider(service), expression)
        {
        }
    }
}