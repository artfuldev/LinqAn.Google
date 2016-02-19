using System;
using System.Linq.Expressions;

namespace DotNetAnalytics.Google.Linq.Core
{
    /// <summary>
    /// Finds the first sub-expression that is of a specified type
    /// </summary>
    public class TypedSubtreeFinder : ExpressionVisitor
    {
        Expression _root;
        readonly Type _type;

        private TypedSubtreeFinder(Type type)
        {
            _type = type;
        }

        public static Expression Find(Expression expression, Type type)
        {
            var finder = new TypedSubtreeFinder(type);
            finder.Visit(expression);
            return finder._root;
        }

        protected override Expression Visit(Expression exp)
        {
            var result = base.Visit(exp);
            if (_root != null || result == null) return result;

            // remember the first sub-expression that produces an IQueryable
            if (_type.IsAssignableFrom(result.Type))
                _root = result;

            return result;
        }
    }
}