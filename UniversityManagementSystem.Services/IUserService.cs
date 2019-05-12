using System.Security;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares user specific members which each user service must implement.
    /// </summary>
    public interface IUserService : IService<User>
    {
        /// <summary>
        ///     Gets the user that matches a username and a password.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>The user that matches the username and the password.</returns>
        Task<User> GetAsync(string username, string password);

        /// <summary>
        ///     Gets the user that matches a username and a password.
        /// </summary>
        /// <remarks>
        ///    https://stackoverflow.com/q/39647911
        /// </remarks>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>The user that matches the username and the password.</returns>
        Task<User> GetAsync(string username, SecureString password);
    }
}