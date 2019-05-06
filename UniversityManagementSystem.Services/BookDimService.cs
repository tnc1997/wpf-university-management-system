using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform book dimension related business logic.
    /// </summary>
    public class BookDimService : DimServiceBase<BookDim>, IBookDimService
    {
        /// <inheritdoc />
        protected override DbSet<BookDim> GetDbSet(ApplicationDbContext context)
        {
            return context.BookDims;
        }

        /// <inheritdoc />
        protected override IQueryable<BookDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .OrderBy(dim => dim.Name)
                .ThenBy(dim => dim.Author);
        }
    }
}