using System;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;
using static System.Runtime.InteropServices.Marshal;
using static BCrypt.Net.BCrypt;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform user related business logic.
    /// </summary>
    public class UserService : ServiceBase<User>, IUserService
    {
        /// <inheritdoc />
        public async Task<User> GetAsync(string username, string password)
        {
            // Creates a new context in order to query the database.
            using (var context = new ApplicationDbContext())
            {
                // Gets the single user that matches the username, or null in the default case where no user is found.
                var user = await GetDbSet(context).SingleOrDefaultAsync(user1 => user1.UserName == username);

                // If the user is null or the passwords do not match, then return null; otherwise, return the user.
                return user == null || !Verify(password, user.PasswordHash) ? null : user;
            }
        }

        /// <inheritdoc />
        public async Task<User> GetAsync(string username, SecureString password)
        {
            // Creates a new context in order to query the database.
            using (var context = new ApplicationDbContext())
            {
                // Gets the single user that matches the username, or null in the default case where no user is found.
                var user = await GetDbSet(context).SingleOrDefaultAsync(user1 => user1.UserName == username);

                // If the user is null, then return null.
                if (user == null) return null;
                
                var test = new System.Net.NetworkCredential(string.Empty, password).Password;
                
                var bstrPassword = SecureStringToBSTR(password);
                var stringPassword = PtrToStringBSTR(bstrPassword);
                ZeroFreeBSTR(bstrPassword);
                bstrPassword = default(IntPtr);

                // Verifies that the string password matches the hashed password.
                var isValid = Verify(stringPassword, user.PasswordHash);

                stringPassword = string.Empty;

                // If the credentials are valid, then return the user; otherwise, return null.
                return isValid ? user : null;
            }
        }

        /// <inheritdoc />
        protected override DbSet<User> GetDbSet(ApplicationDbContext context)
        {
            return context.Users;
        }

        /// <inheritdoc />
        protected override IQueryable<User> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(user => user.Course);
        }
    }
}