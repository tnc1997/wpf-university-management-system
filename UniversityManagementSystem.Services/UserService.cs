using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        protected override DbSet<User> GetDbSet(ApplicationDbContext context)
        {
            return context.Users;
        }
    }
}