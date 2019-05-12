using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;

namespace UniversityManagementSystem.Specifications
{
    /// <inheritdoc />
    /// <summary>
    ///     Defines generic implementations for members which are shared between composite specifications.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public abstract class CompositeSpecificationBase<TEntity> : SpecificationBase<TEntity>
    {
        protected CompositeSpecificationBase(ISpecification<TEntity> left, ISpecification<TEntity> right)
        {
            ParameterExpression = Parameter(typeof(TEntity));

            var leftVisitor = new ReplaceExpressionVisitor(left.Expression.Parameters[0], ParameterExpression);
            LeftExpression = leftVisitor.Visit(left.Expression.Body);

            var rightVisitor = new ReplaceExpressionVisitor(right.Expression.Parameters[0], ParameterExpression);
            RightExpression = rightVisitor.Visit(right.Expression.Body);
        }

        /// <summary>
        ///     Gets the left hand side expression.
        /// </summary>
        protected Expression LeftExpression { get; }

        /// <summary>
        ///     Gets the right hand side expression.
        /// </summary>
        protected Expression RightExpression { get; }

        /// <summary>
        ///     Gets the parameter expression.
        /// </summary>
        protected ParameterExpression ParameterExpression { get; }
    }
}