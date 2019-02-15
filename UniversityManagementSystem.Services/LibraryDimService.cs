using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class LibraryDimService : DimServiceBase<LibraryDim>, ILibraryDimService
    {
        protected override DbSet<LibraryDim> GetDbSet(ApplicationDbContext context)
        {
            return context.LibraryDims;
        }
    }
}