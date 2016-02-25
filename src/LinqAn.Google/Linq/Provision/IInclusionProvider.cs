using System;
using System.Linq.Expressions;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Provision
{
    internal interface IInclusionProvider
    {
        void Include<TProperty>(Expression<Func<IRecord, TProperty>> includeExpression) where TProperty : class, new();
    }
}