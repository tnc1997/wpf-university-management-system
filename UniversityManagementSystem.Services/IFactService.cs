using System.Threading.Tasks;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    public interface IFactService<TFact> : IService<TFact> where TFact : IFact
    {
        Task<int> GetSumAsync();
        Task<int> GetSumAsync(ISpecification<TFact> specification);
    }
}