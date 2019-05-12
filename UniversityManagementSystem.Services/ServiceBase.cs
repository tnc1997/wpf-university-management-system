using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines generic implementations for members which are shared between services.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public abstract class ServiceBase<TEntity> : IService<TEntity> where TEntity : class
    {
        /// <inheritdoc />
        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            // Creates a new context in order to query the database.
            using (var context = new ApplicationDbContext())
            {
                return await GetQueryable(context).ToListAsync();
            }
        }

        /// <inheritdoc />
        public async Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> specification)
        {
            // Creates a new context in order to query the database.
            using (var context = new ApplicationDbContext())
            {
                // Entity Framework does not execute the query until the `ToListAsync` method is called, which means
                // that the `WHERE` clause containing the specification is included in the query to be executed.
                return await GetQueryable(context).Where(specification.Expression).ToListAsync();
            }
        }

        /// <summary>
        ///     Gets the queryable which represents the query to be executed in the database.
        /// </summary>
        /// <remarks>
        ///     By default this method returns the result of calling the <see cref="GetDbSet" /> method, which simply
        ///     returns all of the entities corresponding to the <see cref="TEntity" /> type from the database.
        /// </remarks>
        /// <param name="context">The context used to query the database.</param>
        /// <returns>The queryable which represents the query to be executed in the database.</returns>
        protected virtual IQueryable<TEntity> GetQueryable(ApplicationDbContext context)
        {
            return GetDbSet(context);
        }

        /// <summary>
        ///     Gets the entity's <see cref="DbSet{TEntity}" /> which represents the entity's repository.
        /// </summary>
        /// <param name="context">The context used to query the database.</param>
        /// <returns>The entity's <see cref="DbSet{TEntity}" /> which represents the entity's repository.</returns>
        protected abstract DbSet<TEntity> GetDbSet(ApplicationDbContext context);
    }
}