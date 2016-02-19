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
    public class Repository : IAllowFluentQueries
    {
        private RecordsDataSet Items=>new RecordsDataSet(_client);
        private readonly IReportingClient _client;

        public Repository(IReportingClient client)
        {
            _client = client;
        }

        public IQueryFluent Query(IQueryObject queryObject)
        {
            return Query(queryObject.Query());
        }

        public IQueryFluent Query(Expression<Func<IRecord, bool>> query)
        {
            return new QueryFluent(this, query);
        }

        public IQueryFluent Query()
        {
            return new QueryFluent(this);
        }

        public IQueryable<IRecord> Queryable() => Items;

        internal IQueryable<IRecord> Select(
            Expression<Func<IRecord, bool>> filter = null,
            List<object> includes = null,
            Func<IQueryable<IRecord>, IOrderedQueryable<IRecord>> orderBy = null,
            int? page = null,
            int? pageSize = null)
        {
            IQueryable<IRecord> query = Items;
            if (includes != null)
            {
                foreach (var inclusion in includes)
                    ((RecordsDataSet)query).Include(inclusion);
            }
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
            List<object> includes = null,
            Func<IQueryable<IRecord>, IOrderedQueryable<IRecord>> orderBy = null,
            int? page = null,
            int? pageSize = null)
        {
            return await Select(filter, includes, orderBy, page, pageSize).ToListAsync().ConfigureAwait(false);
        }
    }
}