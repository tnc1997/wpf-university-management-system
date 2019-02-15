using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;

namespace UniversityManagementSystem.Services
{
    public abstract class ServiceBase<TEntity> where TEntity : class
    {
        protected abstract DbSet<TEntity> GetDbSet(ApplicationDbContext context);
    }
}