using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class ClassificationDimService : DimServiceBase<ClassificationDim>, IClassificationDimService
    {
        protected override DbSet<ClassificationDim> GetDbSet(ApplicationDbContext context)
        {
            return context.ClassificationDims;
        }

        protected override IQueryable<ClassificationDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Classification);
        }
    }
}