using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    public interface IService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> specification);
    }
}