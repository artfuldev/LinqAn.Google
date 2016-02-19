using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using DotNetAnalytics.Google.Linq.Queries;
using DotNetAnalytics.Google.Linq.Queryables;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Repositories
{
    public class Repository : IAllowFluentQueries<IRecord>
    {
        private readonly RecordsDataSet _items;
        protected Repository(IReportingClient client)
        {
            _items = new RecordsDataSet(client);
        }
        public IQueryFluent<IRecord> Query(IQueryObject<IRecord> queryObject)
        {
            return Query(queryObject.Query());
        }

        public IQueryFluent<IRecord> Query(Expression<Func<IRecord, bool>> query)
        {
            return new QueryFluent(this, query);
        }

        public IQueryFluent<IRecord> Query()
        {
            return new QueryFluent(this);
        }

        public IQueryable<IRecord> SelectQuery(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IRecord> Queryable()
        {
            return _items;
        }

        internal IQueryable<IRecord> Select(
            Expression<Func<IRecord, bool>> filter = null,
            Func<IQueryable<IRecord>, IOrderedQueryable<IRecord>> orderBy = null,
            int? page = null,
            int? pageSize = null)
        {
            IQueryable<IRecord> query = _items;
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (page != null && pageSize != null)
            {
                query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
            }
            return query;
        }

        internal async Task<IEnumerable<IRecord>> SelectAsync(
            Expression<Func<IRecord, bool>> filter = null,
            Func<IQueryable<IRecord>, IOrderedQueryable<IRecord>> orderBy = null,
            int? page = null,
            int? pageSize = null)
        {
            return await Select(filter, orderBy, page, pageSize).ToListAsync().ConfigureAwait(false);
        }
    }
}