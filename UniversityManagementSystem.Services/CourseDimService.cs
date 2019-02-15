using System.Data.Entity;
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
    }
}