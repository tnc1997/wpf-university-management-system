using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares user dimension specific members that each user dimension service must implement.
    /// </summary>
    public interface IUserDimService : IDimService<UserDim>
    {
    }
}