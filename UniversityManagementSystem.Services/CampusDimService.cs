using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class CampusDimService : DimServiceBase<CampusDim>, ICampusDimService
    {
        protected override DbSet<CampusDim> GetDbSet(ApplicationDbContext context)
        {
            return context.CampusDims;
        }
    }
}