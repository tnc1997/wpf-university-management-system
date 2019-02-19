using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    public abstract class FactServiceBase<TFact> : ServiceBase<TFact>, IFactService<TFact> where TFact : class, IFact
    {
        public async Task<int> GetSumAsync()
        {
            using (var context = new ApplicationDbContext())
            {
                var dbSet = GetDbSet(context);

                if (!dbSet.Any()) return 0;

                return await dbSet.SumAsync(fact => fact.Count);
            }
        }

        public async Task<int> GetSumAsync(ISpecification<TFact> specification)
        {
            using (var context = new ApplicationDbContext())
            {
                var dbSet = GetDbSet(context);

                if (!dbSet.Any(specification.Expression)) return 0;

                return await dbSet.Where(specification.Expression).SumAsync(fact => fact.Count);
            }
        }

        protected override IQueryable<TFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(fact => fact.YearDim);
        }
    }
}