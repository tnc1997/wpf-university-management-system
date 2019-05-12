using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares generic members that each service must implement.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IService<TEntity>
    {
        /// <summary>
        ///     Gets all the entities from the repository.
        /// </summary>
        /// <returns>All the entities.</returns>
        Task<IEnumerable<TEntity>> GetAsync();

        /// <summary>
        ///     Gets all the entities from the repository that satisfy a specification.
        /// </summary>
        /// <param name="specification">The specification used to filter all the entities.</param>
        /// <returns>All the entities that satisfy the specification.</returns>
        Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> specification);
    }
}