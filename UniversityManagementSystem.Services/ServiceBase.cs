using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    public abstract class ServiceBase<TEntity> : IService<TEntity> where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            using (var context = new ApplicationDbContext())
            {
                return await GetQueryable(context).ToListAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> specification)
        {
            using (var context = new ApplicationDbContext())
            {
                return await GetQueryable(context).Where(specification.Expression).ToListAsync();
            }
        }

        protected virtual IQueryable<TEntity> GetQueryable(ApplicationDbContext context)
        {
            return GetDbSet(context);
        }

        protected abstract DbSet<TEntity> GetDbSet(ApplicationDbContext context);
    }
}