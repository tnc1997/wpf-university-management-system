using System.Threading.Tasks;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public interface IUserService : IService<User>
    {
        Task<User> GetAsync(string username, string password);
    }
}