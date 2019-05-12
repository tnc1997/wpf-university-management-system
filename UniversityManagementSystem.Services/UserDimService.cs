using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform user dimension related business logic.
    /// </summary>
    public class UserDimService : DimServiceBase<UserDim>, IUserDimService
    {
        /// <inheritdoc />
        protected override DbSet<UserDim> GetDbSet(ApplicationDbContext context)
        {
            return context.UserDims;
        }

        /// <inheritdoc />
        protected override IQueryable<UserDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .OrderBy(dim => dim.FirstName)
                .ThenBy(dim => dim.LastName);
        }
    }
}