using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform library dimension related business logic.
    /// </summary>
    public class LibraryDimService : DimServiceBase<LibraryDim>, ILibraryDimService
    {
        /// <inheritdoc />
        protected override DbSet<LibraryDim> GetDbSet(ApplicationDbContext context)
        {
            return context.LibraryDims;
        }
    }
}