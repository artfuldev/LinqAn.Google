using System;
using System.Linq.Expressions;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Metrics;
using LinqAn.Google.Profiles;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public class RecordsDataSet : Query<IQueryableRecord>
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
    }
}