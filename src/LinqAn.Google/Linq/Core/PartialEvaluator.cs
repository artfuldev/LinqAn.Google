using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace LinqAn.Google.Linq.Core
{
    /// <summary>
    ///     Rewrites an expression tree so that locally isolatable sub-expressions are evaluated and converted into
    ///     ConstantExpression nodes.
    /// </summary>
    public static class PartialEvaluator
    {
        /// <summary>
        ///     Performs evaluation & replacement of independent sub-trees
        /// </summary>
        /// <param name="expression">The root of the expression tree.</param>
        /// <returns>A new tree with sub-trees evaluated and replaced.</returns>
        public static Expression Eval(Expression expression)
        {
            return Eval(expression, null, null);
        }

        /// <summary>
        ///     Performs evaluation & replacement of independent sub-trees
        /// </summary>
        /// <param name="expression">The root of the expression tree.</param>
        /// <param name="fnCanBeEvaluated">
        ///     A function that decides whether a given expression node can be part of the local
        ///     function.
        /// </param>
        /// <returns>A new tree with sub-trees evaluated and replaced.</returns>
        public static Expression Eval(Expression expression, Func<Expression, bool> fnCanBeEvaluated)
        {
            return Eval(expression, fnCanBeEvaluated, null);
        }

        public static Expression Eval(Expression expression, Func<Expression, bool> fnCanBeEvaluated,
            Func<ConstantExpression, Expression> fnPostEval)
        {
            if (fnCanBeEvaluated == null)
                fnCanBeEvaluated = CanBeEvaluatedLocally;
            return SubtreeEvaluator.Eval(Nominator.Nominate(fnCanBeEvaluated, expression), fnPostEval, expression);
        }

        private static bool CanBeEvaluatedLocally(Expression expression)
        {
            return expression.NodeType != ExpressionType.Parameter;
        }

        /// <summary>
        ///     Evaluates & replaces sub-trees when first candidate is reached (top-down)
        /// </summary>
        private class SubtreeEvaluator : System.Linq.Expressions.ExpressionVisitor
        {
            private readonly HashSet<Expression> _candidates;
            private readonly Func<ConstantExpression, Expression> _onEval;

            private SubtreeEvaluator(HashSet<Expression> candidates, Func<ConstantExpression, Expression> onEval)
            {
                _candidates = candidates;
                _onEval = onEval;
            }

            internal static Expression Eval(HashSet<Expression> candidates, Func<ConstantExpression, Expression> onEval,
                Expression exp)
            {
                return new SubtreeEvaluator(candidates, onEval).Visit(exp);
            }

            public override Expression Visit(Expression exp)
            {
                if (exp == null)
                {
                    return null;
                }
                if (_candidates.Contains(exp))
                {
                    return Evaluate(exp);
                }
                return base.Visit(exp);
            }

            private Expression PostEval(ConstantExpression e)
            {
                if (_onEval != null)
                {
                    return _onEval(e);
                }
                return e;
            }

            private Expression Evaluate(Expression e)
            {
                var type = e.Type;
                if (e.NodeType == ExpressionType.Convert)
                {
                    // check for unnecessary convert & strip them
                    var u = (UnaryExpression) e;
                    if (u.Operand.Type.GetNonNullableType() == type.GetNonNullableType())
                    {
                        e = ((UnaryExpression) e).Operand;
                    }
                }
                if (e.NodeType == ExpressionType.Constant)
                {
                    // in case we actually threw out a nullable conversion above, simulate it here
                    // don't post-eval nodes that were already constants
                    if (e.Type == type)
                    {
                        return e;
                    }
                    if (e.Type.GetNonNullableType() == type.GetNonNullableType())
                    {
                        return Expression.Constant(((ConstantExpression) e).Value, type);
                    }
                }
                var me = e as MemberExpression;
                if (me != null)
                {
                    // member accesses off of constant's are common, and yet since these partial evals
                    // are never re-used, using reflection to access the member is faster than compiling  
                    // and invoking a lambda
                    var ce = me.Expression as ConstantExpression;
                    if (ce != null)
                    {
                        return PostEval(Expression.Constant(me.Member.GetValue(ce.Value), type));
                    }
                }
                if (type.GetTypeInfo().IsValueType)
                {
                    e = Expression.Convert(e, typeof (object));
                }
                var lambda = Expression.Lambda<Func<object>>(e);
                var fn = lambda.Compile();
                return PostEval(Expression.Constant(fn(), type));
            }
        }

        /// <summary>
        ///     Performs bottom-up analysis to determine which nodes can possibly
        ///     be part of an evaluated sub-tree.
        /// </summary>
        private class Nominator : System.Linq.Expressions.ExpressionVisitor
        {
            private readonly HashSet<Expression> _candidates;
            private readonly Func<Expression, bool> _fnCanBeEvaluated;
            private bool _cannotBeEvaluated;

            private Nominator(Func<Expression, bool> fnCanBeEvaluated)
            {
                _candidates = new HashSet<Expression>();
                _fnCanBeEvaluated = fnCanBeEvaluated;
            }

            internal static HashSet<Expression> Nominate(Func<Expression, bool> fnCanBeEvaluated, Expression expression)
            {
                var nominator = new Nominator(fnCanBeEvaluated);
                nominator.Visit(expression);
                return nominator._candidates;
            }

            protected override Expression VisitConstant(ConstantExpression c)
            {
                return base.VisitConstant(c);
            }

            public override Expression Visit(Expression expression)
            {
                if (expression != null)
                {
                    var saveCannotBeEvaluated = _cannotBeEvaluated;
                    _cannotBeEvaluated = false;
                    base.Visit(expression);
                    if (!_cannotBeEvaluated)
                    {
                        if (_fnCanBeEvaluated(expression))
                        {
                            _candidates.Add(expression);
                        }
                        else
                        {
                            _cannotBeEvaluated = true;
                        }
                    }
                    _cannotBeEvaluated |= saveCannotBeEvaluated;
                }
                return expression;
            }
        }
    }
}