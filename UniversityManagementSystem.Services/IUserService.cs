using System.Collections.Generic;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAsync();
    }
}