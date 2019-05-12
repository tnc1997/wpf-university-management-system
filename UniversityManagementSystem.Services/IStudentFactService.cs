using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares student fact specific members that each student fact service must implement.
    /// </summary>
    public interface IStudentFactService : IFactService<StudentFact>
    {
    }
}