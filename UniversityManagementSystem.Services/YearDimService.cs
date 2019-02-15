using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class YearDimService : DimServiceBase<YearDim>, IYearDimService
    {
        protected override DbSet<YearDim> GetDbSet(ApplicationDbContext context)
        {
            return context.YearDims;
        }
    }
}