using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class BookDimService : DimServiceBase<BookDim>, IBookDimService
    {
        protected override DbSet<BookDim> GetDbSet(ApplicationDbContext context)
        {
            return context.BookDims;
        }
    }
}