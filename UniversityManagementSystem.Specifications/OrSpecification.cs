using System;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;

namespace UniversityManagementSystem.Specifications
{
    /// <inheritdoc />
    /// <summary>
    ///     Defines implementations for the inherited members which represent an or specification.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public class OrSpecification<TEntity> : CompositeSpecificationBase<TEntity>
    {
        /// <summary>
        ///     Constructs an instance of the or specification using a left and right specification.
        /// </summary>
        /// <param name="left">The left hand side specification.</param>
        /// <param name="right">The right hand side specification.</param>
        public OrSpecification(ISpecification<TEntity> left, ISpecification<TEntity> right) : base(left, right)
        {
            Expression = Lambda<Func<TEntity, bool>>(OrElse(LeftExpression, RightExpression), ParameterExpression);
        }

        public override Expression<Func<TEntity, bool>> Expression { get; }
    }
}