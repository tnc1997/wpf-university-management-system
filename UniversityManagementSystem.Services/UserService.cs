using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;
using static BCrypt.Net.BCrypt;

namespace UniversityManagementSystem.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public async Task<User> GetAsync(string username, string password)
        {
            using (var context = new ApplicationDbContext())
            {
                var user = await GetDbSet(context).SingleOrDefaultAsync(user1 => user1.UserName == username);

                return user == null || !Verify(password, user.PasswordHash) ? null : user;
            }
        }

        protected override DbSet<User> GetDbSet(ApplicationDbContext context)
        {
            return context.Users;
        }

        protected override IQueryable<User> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(user => user.Course);
        }
    }
}