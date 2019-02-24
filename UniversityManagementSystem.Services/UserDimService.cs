using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class UserDimService : DimServiceBase<UserDim>, IUserDimService
    {
        protected override DbSet<UserDim> GetDbSet(ApplicationDbContext context)
        {
            return context.UserDims;
        }

        protected override IQueryable<UserDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .OrderBy(dim => dim.FirstName)
                .ThenBy(dim => dim.LastName);
        }
    }
}