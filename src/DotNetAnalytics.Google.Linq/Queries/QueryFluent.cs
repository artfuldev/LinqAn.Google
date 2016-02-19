using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queries
{
    public class QueryFluent<T> : IQueryFluent<T> where T : IRecord
    {
        #region Private Fields
        private readonly Expression<Func<T, bool>> _expression;
        private readonly RepositoryAsync<T> _repository;
        private Func<IQueryable<T>, IOrderedQueryable<T>> _orderBy;
        #endregion Private Fields

        #region Constructors
        public QueryFluent(RepositoryAsync<T> repository)
        {
            _repository = repository;
        }

        public QueryFluent(RepositoryAsync<T> repository, IQueryObject<T> queryObject)
            : this(repository)
        {
            _expression = queryObject.Query();
        }

        public QueryFluent(RepositoryAsync<T> repository, Expression<Func<T, bool>> expression)
            : this(repository)
        {
            _expression = expression;
        }

        #endregion Constructors
        public IQueryFluent<T> OrderBy(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            _orderBy = orderBy;
            return this;
        }

        public IQueryFluent<T> Include(Expression<Func<T, object>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SelectPage(int page, int pageSize, out int totalCount)
        {
            // TODO: Change Total Count Later
            totalCount = 0;//_repository.Select(_expression).Count();
            return _repository.Select(_expression, _orderBy, page, pageSize);
        }

        public IEnumerable<T> Select()
        {
            return _repository.Select(_expression, _orderBy);
        }

        public IEnumerable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
        {
            return _repository.Select(_expression, _orderBy).Select(selector);
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await _repository.SelectAsync(_expression, _orderBy).ConfigureAwait(false);
        }
    }
}