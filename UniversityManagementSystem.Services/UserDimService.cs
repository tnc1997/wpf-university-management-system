using System.Data.Entity;
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
    }
}