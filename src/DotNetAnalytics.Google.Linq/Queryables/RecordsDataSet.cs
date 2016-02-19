using System;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Linq.Core;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queryables
{
    public class RecordsDataSet<T> : Query<T> where T : IRecord
    {
        public RecordsDataSet(IClient<T> client)
            : base(new RecordsQueryProvider<T>(client))
        {
        }

        public RecordsDataSet(IClient<T> client, Type staticType)
            : base(new RecordsQueryProvider<T>(client), staticType)
        {
        }

        public RecordsDataSet(IClient<T> client, Expression expression)
            : base(new RecordsQueryProvider<T>(client), expression)
        {
        }
    }
}
