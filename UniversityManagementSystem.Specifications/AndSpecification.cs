using System;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;

namespace UniversityManagementSystem.Specifications
{
    /// <summary>
    ///     Defines implementations for the inherited members which represent an and specification.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public class AndSpecification<TEntity> : CompositeSpecificationBase<TEntity>
    {
        /// <summary>
        ///     Constructs an instance of the and specification using a left and right specification.
        /// </summary>
        /// <param name="left">The left hand side specification.</param>
        /// <param name="right">The right hand side specification.</param>
        public AndSpecification(ISpecification<TEntity> left, ISpecification<TEntity> right) : base(left, right)
        {
            Expression = Lambda<Func<TEntity, bool>>(AndAlso(LeftExpression, RightExpression), ParameterExpression);
        }

        /// <inheritdoc />
        public override Expression<Func<TEntity, bool>> Expression { get; }
    }
}