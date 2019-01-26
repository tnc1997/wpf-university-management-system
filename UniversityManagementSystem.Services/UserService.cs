using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class UserService : IUserService
    {
        public async Task<IEnumerable<User>> GetAsync()
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Users.ToListAsync();
            }
        }
    }
}