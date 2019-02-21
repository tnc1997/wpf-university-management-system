using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class CountryDimService : DimServiceBase<CountryDim>, ICountryDimService
    {
        protected override DbSet<CountryDim> GetDbSet(ApplicationDbContext context)
        {
            return context.CountryDims;
        }
    }
}