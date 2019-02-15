using System;
using System.Linq.Expressions;

namespace UniversityManagementSystem.Specifications
{
    /// <summary>
    ///     Declares generic members that each specification must implement.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface ISpecification<TEntity>
    {
        /// <summary>
        ///     Gets the expression.
        /// </summary>
        Expression<Func<TEntity, bool>> Expression { get; }

        /// <summary>
        ///     Performs an and operation with another specification.
        /// </summary>
        /// <param name="other">The other specification.</param>
        /// <returns>The anded specification.</returns>
        ISpecification<TEntity> And(ISpecification<TEntity> other);

        /// <summary>
        ///     Checks if a value satisfies the specification.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value satisfies the specification; otherwise, false.</returns>
        bool IsSatisfiedBy(TEntity value);

        /// <summary>
        ///     Performs an or operation with another specification.
        /// </summary>
        /// <param name="other">The other specification.</param>
        /// <returns>The ored specification</returns>
        ISpecification<TEntity> Or(ISpecification<TEntity> other);
    }
}