using System;
using System.Linq.Expressions;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public class RecordsDataSet : Query<IRecord>
    {
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

        private RecordsQueryProvider<IRecord> _provider => Provider as RecordsQueryProvider<IRecord>;

        public void Include(object inclusion)
        {
            _provider.Includes.Add(inclusion);
        }
    }
}