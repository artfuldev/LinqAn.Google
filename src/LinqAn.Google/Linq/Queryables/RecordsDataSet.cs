using System;
using System.Linq.Expressions;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public class RecordsDataSet : Query<IQueryableRecord>
    {
        public RecordsDataSet(IReportingClient client)
            : base(new RecordsQueryProvider(client))
        {
        }

        public RecordsDataSet(IReportingClient client, Type staticType)
            : base(new RecordsQueryProvider(client), staticType)
        {
        }

        public RecordsDataSet(IReportingClient client, Expression expression)
            : base(new RecordsQueryProvider(client), expression)
        {
        }
    }
}