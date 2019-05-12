using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines generic implementations for members which are shared between fact services.
    /// </summary>
    /// <typeparam name="TFact">The type of the fact.</typeparam>
    public abstract class FactServiceBase<TFact> : ServiceBase<TFact>, IFactService<TFact> where TFact : class, IFact
    {
        /// <inheritdoc />
        public async Task<int> GetSumAsync()
        {
            // Creates a new context in order to query the database.
            using (var context = new ApplicationDbContext())
            {
                var dbSet = GetDbSet(context);

                // If the fact table does not contain any facts, then return 0.
                if (!dbSet.Any()) return 0;

                // Sums the count of each of the facts in the fact table.
                return await dbSet.SumAsync(fact => fact.Count);
            }
        }

        /// <inheritdoc />
        public async Task<int> GetSumAsync(ISpecification<TFact> specification)
        {
            // Creates a new context in order to query the database.
            using (var context = new ApplicationDbContext())
            {
                var dbSet = GetDbSet(context);

                // If the fact table does not contain any facts that satisfy the specification, then return 0.
                if (!dbSet.Any(specification.Expression)) return 0;

                // Sums the count of each of the facts in the fact table that satisfy the specification.
                return await dbSet.Where(specification.Expression).SumAsync(fact => fact.Count);
            }
        }

        /// <inheritdoc />
        protected override IQueryable<TFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(fact => fact.YearDim);
        }
    }
}