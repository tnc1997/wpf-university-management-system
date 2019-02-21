using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class ResultFactService : FactServiceBase<ResultFact>, IResultFactService
    {
        protected override DbSet<ResultFact> GetDbSet(ApplicationDbContext context)
        {
            return context.ResultFacts;
        }

        protected override IQueryable<ResultFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ClassificationDim)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.ClassificationDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}