﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace LinqAn.Google.Linq.Core
{
    /// <summary>
    ///     A basic abstract LINQ query provider
    /// </summary>
    internal abstract class QueryProvider : IAsyncQueryProvider
    {
        IQueryable<S> IQueryProvider.CreateQuery<S>(Expression expression)
        {
            return new Query<S>(this, expression);
        }

        IQueryable IQueryProvider.CreateQuery(Expression expression)
        {
            var elementType = expression.Type.GetElementType();
            try
            {
                return
                    (IQueryable)
                        Activator.CreateInstance(typeof (Query<>).MakeGenericType(elementType), this, expression);
            }
            catch (TargetInvocationException tie)
            {
                throw tie.InnerException;
            }
        }

        S IQueryProvider.Execute<S>(Expression expression)
        {
            return (S) Execute(expression);
        }

        object IQueryProvider.Execute(Expression expression)
        {
            return Execute(expression);
        }

        public virtual Task<object> ExecuteAsync(Expression expression, CancellationToken token = default(CancellationToken))
        {
            return Task.Run(() => Execute(expression), token);
        }

        public virtual Task<S> ExecuteAsync<S>(Expression expression, CancellationToken token = default(CancellationToken))
        {
            return Task.Run(() => (S)Execute(expression), token);
        }

        public abstract object Execute(Expression expression);
    }
}