using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LinqAn.Google.Linq.Core
{
    /// <summary>
    ///     A default implementation of <seealso cref="IQueryable" /> for use with <seealso cref="QueryProvider" />
    /// </summary>
    internal class Query<T> : IOrderedQueryable<T>
    {
        public Query(QueryProvider provider)
            : this(provider, (Type) null)
        {
        }

        public Query(QueryProvider provider, Type staticType)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }
            Provider = provider;
            Expression = staticType != null ? Expression.Constant(this, staticType) : Expression.Constant(this);
        }

        public Query(QueryProvider provider, Expression expression)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!typeof (IQueryable<T>).IsAssignableFrom(expression.Type))
            {
                throw new ArgumentOutOfRangeException(nameof(expression));
            }
            Provider = provider;
            Expression = expression;
        }

        public Expression Expression { get; }

        public Type ElementType => typeof (T);

        public IQueryProvider Provider { get; }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>) Provider.Execute(Expression)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) Provider.Execute(Expression)).GetEnumerator();
        }

        public override string ToString()
        {
            if (Expression.NodeType == ExpressionType.Constant &&
                ((ConstantExpression) Expression).Value == this)
            {
                return "Query(" + typeof (T) + ")";
            }
            return Expression.ToString();
        }
    }
}