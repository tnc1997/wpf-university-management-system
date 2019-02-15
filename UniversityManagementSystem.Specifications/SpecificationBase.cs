using System;
using System.Linq.Expressions;

namespace UniversityManagementSystem.Specifications
{
    /// <inheritdoc />
    /// <summary>
    ///     Defines generic implementations for members which are shared between specifications.
    /// </summary>
    public abstract class SpecificationBase<TEntity> : ISpecification<TEntity>
    {
        /// <inheritdoc />
        public abstract Expression<Func<TEntity, bool>> Expression { get; }

        /// <inheritdoc />
        public ISpecification<TEntity> And(ISpecification<TEntity> other)
        {
            if (other == null) throw new ArgumentNullException(nameof(other));

            return new AndSpecification<TEntity>(this, other);
        }

        /// <inheritdoc />
        public ISpecification<TEntity> Or(ISpecification<TEntity> other)
        {
            if (other == null) throw new ArgumentNullException(nameof(other));

            return new OrSpecification<TEntity>(this, other);
        }

        /// <inheritdoc />
        public bool IsSatisfiedBy(TEntity value)
        {
            return Expression.Compile()(value);
        }

        /// <summary>
        ///     Performs an and operation between two specifications.
        /// </summary>
        /// <param name="left">The left hand side specification.</param>
        /// <param name="right">The right hand side specification.</param>
        /// <returns>The anded specification.</returns>
        public static ISpecification<TEntity> operator &(
            SpecificationBase<TEntity> left,
            SpecificationBase<TEntity> right
        )
        {
            if (left == null) throw new ArgumentNullException(nameof(left));
            if (right == null) throw new ArgumentNullException(nameof(right));

            return left.And(right);
        }

        /// <summary>
        ///     Performs an or operation between two specifications.
        /// </summary>
        /// <param name="left">The left hand side specification.</param>
        /// <param name="right">The right hand side specification.</param>
        /// <returns>The ored specification.</returns>
        public static ISpecification<TEntity> operator |(
            SpecificationBase<TEntity> left,
            SpecificationBase<TEntity> right
        )
        {
            if (left == null) throw new ArgumentNullException(nameof(left));
            if (right == null) throw new ArgumentNullException(nameof(right));

            return left.Or(right);
        }
    }
}