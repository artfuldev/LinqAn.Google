using System;
using System.Linq.Expressions;
using Google.Apis.Services;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Linq.Provision;
using LinqAn.Google.Profiles;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    internal class RecordsDataSet : Query<IRecord>
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

        public RecordsDataSet(BaseClientService.Initializer initializer)
            : base(new RecordsQueryProvider(initializer))
        {
        }

        public RecordsDataSet(BaseClientService.Initializer initializer, Type staticType)
            : base(new RecordsQueryProvider(initializer), staticType)
        {
        }

        public RecordsDataSet(BaseClientService.Initializer initializer, Expression expression)
            : base(new RecordsQueryProvider(initializer), expression)
        {
        }
    }
}