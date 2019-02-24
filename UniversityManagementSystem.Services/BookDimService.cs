using System.Data.Entity;
using System.Linq;
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

        protected override IQueryable<BookDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .OrderBy(dim => dim.Name)
                .ThenBy(dim => dim.Author);
        }
    }
}