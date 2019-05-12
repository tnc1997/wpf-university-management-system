using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform country dimension related business logic.
    /// </summary>
    public class CountryDimService : DimServiceBase<CountryDim>, ICountryDimService
    {
        /// <inheritdoc />
        protected override DbSet<CountryDim> GetDbSet(ApplicationDbContext context)
        {
            return context.CountryDims;
        }
    }
}