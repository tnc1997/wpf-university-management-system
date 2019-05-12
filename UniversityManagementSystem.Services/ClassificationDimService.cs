using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform classification dimension related business logic.
    /// </summary>
    public class ClassificationDimService : DimServiceBase<ClassificationDim>, IClassificationDimService
    {
        /// <inheritdoc />
        protected override DbSet<ClassificationDim> GetDbSet(ApplicationDbContext context)
        {
            return context.ClassificationDims;
        }

        /// <inheritdoc />
        protected override IQueryable<ClassificationDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Classification);
        }
    }
}