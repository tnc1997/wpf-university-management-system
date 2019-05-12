using System.Threading.Tasks;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares fact specific members which each fact service must implement.
    /// </summary>
    /// <typeparam name="TFact">The type of the fact.</typeparam>
    public interface IFactService<TFact> : IService<TFact> where TFact : IFact
    {
        /// <summary>
        ///     Gets the sum of the count of each fact.
        /// </summary>
        /// <returns>The sum of the count of each fact.</returns>
        Task<int> GetSumAsync();

        /// <summary>
        ///     Gets the sum of the count of each fact that satisfies a specification.
        /// </summary>
        /// <param name="specification">The specification used to filter each fact.</param>
        /// <returns>The sum of the count of each fact that satisfies a specification.</returns>
        Task<int> GetSumAsync(ISpecification<TFact> specification);
    }
}