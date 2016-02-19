using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Linq.Repositories;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queries
{
    public class QueryFluent : IQueryFluent<IRecord>
    {
        private readonly Expression<Func<IRecord, bool>> _expression;
        private readonly Repository _repository;
        private Func<IQueryable<IRecord>, IOrderedQueryable<IRecord>> _orderBy;

        public QueryFluent(Repository repository)
        {
            _repository = repository;
        }

        public QueryFluent(Repository repository, IQueryObject<IRecord> queryObject)
            : this(repository)
        {
            _expression = queryObject.Query();
        }

        public QueryFluent(Repository repository, Expression<Func<IRecord, bool>> expression)
            : this(repository)
        {
            _expression = expression;
        }

        public IQueryFluent<IRecord> OrderBy(Func<IQueryable<IRecord>, IOrderedQueryable<IRecord>> orderBy)
        {
            _orderBy = orderBy;
            return this;
        }

        public IQueryFluent<IRecord> Include(Expression<Func<IRecord, IDimension>> dimensionExpression)
        {
            throw new NotImplementedException();
        }

        public IQueryFluent<IRecord> Include(Expression<Func<IRecord, IMetric>> metricExpression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecord> SelectPage(int page, int pageSize, out int totalCount)
        {
            // IRecordODO: Change IRecordotal Count Later
            totalCount = 0; //_repository.Select(_expression).Count();
            return _repository.Select(_expression, _orderBy, page, pageSize);
        }

        public IEnumerable<IRecord> Select()
        {
            return _repository.Select(_expression, _orderBy);
        }

        public IEnumerable<IRecordResult> Select<IRecordResult>(Expression<Func<IRecord, IRecordResult>> selector)
        {
            return _repository.Select(_expression, _orderBy).Select(selector);
        }

        public async Task<IEnumerable<IRecord>> SelectAsync()
        {
            return await _repository.SelectAsync(_expression, _orderBy).ConfigureAwait(false);
        }
    }
}