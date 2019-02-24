using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class CourseDimService : DimServiceBase<CourseDim>, ICourseDimService
    {
        protected override DbSet<CourseDim> GetDbSet(ApplicationDbContext context)
        {
            return context.CourseDims;
        }

        protected override IQueryable<CourseDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Name);
        }
    }
}