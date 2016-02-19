using System;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Linq.Core;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queryables
{
    public class RecordsDataSet : Query<IRecord>
    {
        private RecordsQueryProvider<IRecord> _provider => Provider as RecordsQueryProvider<IRecord>; 
        public RecordsDataSet(IReportingClient client)
            : base(new RecordsQueryProvider<IRecord>(client))
        {
        }

        public RecordsDataSet(IReportingClient client, Type staticType)
            : base(new RecordsQueryProvider<IRecord>(client), staticType)
        {
        }

        public RecordsDataSet(IReportingClient client, Expression expression)
            : base(new RecordsQueryProvider<IRecord>(client), expression)
        {
        }

        public void Include(object inclusion)
        {
            _provider.Includes.Add(inclusion);
        }
    }
}
