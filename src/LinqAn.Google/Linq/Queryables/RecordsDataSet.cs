using System;
using System.Linq.Expressions;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Core;
using LinqAn.Google.Metrics;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    public class RecordsDataSet : Query<IQueryableRecord>
    {
        private new RecordsQueryProvider Provider => base.Provider as RecordsQueryProvider;
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

        public void Include<TProperty>(Expression<Func<IQueryableRecord, TProperty>> includeExpression)
        {
            if (includeExpression == null)
                throw new ArgumentNullException(nameof(includeExpression));
            if(!typeof(IDimension).IsAssignableFrom(typeof(TProperty)) && !typeof(IMetric).IsAssignableFrom(typeof(TProperty)))
                throw new InvalidOperationException("Only metrics and dimensions can be included.");
            var instance = Activator.CreateInstance<TProperty>();
            Provider.Includes.Add(instance);
        }
    }
}