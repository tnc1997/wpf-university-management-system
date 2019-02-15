using System.Threading.Tasks;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Services
{
    public interface IFactService<TFact> where TFact : IFact
    {
        Task<int> GetSumAsync();
        Task<int> GetSumAsync(ISpecification<TFact> specification);

        /*Task<int> GetNoOfAssignmentsAsync();
        Task<int> GetNoOfAssignmentsAsync(int yearId);
        Task<int> GetNoOfAssignmentsAsync(int yearId, int moduleId);
        
        Task<int> GetNoOfBooksAsync();
        Task<int> GetNoOfBooksAsync(int yearId);
        Task<int> GetNoOfBooksAsync(int yearId, int libraryId);
        
        Task<int> GetNoOfGraduatesAsync();
        Task<int> GetNoOfGraduatesAsync(int yearId);
        Task<int> GetNoOfGraduatesAsync(int yearId, int courseId);
        
        Task<int> GetNoOfHallsAsync();
        Task<int> GetNoOfHallsAsync(int yearId);
        Task<int> GetNoOfHallsAsync(int yearId, int campusId);
        
        Task<int> GetNoOfLecturesAsync();
        Task<int> GetNoOfLecturesAsync(int yearId);
        Task<int> GetNoOfLecturesAsync(int yearId, int roomId);
        Task<int> GetNoOfLecturesAsync(int yearId, int roomId, int moduleId);
        
        Task<int> GetNoOfLibrariesAsync();
        Task<int> GetNoOfLibrariesAsync(int yearId);
        Task<int> GetNoOfLibrariesAsync(int yearId, int campusId);
        
        Task<int> GetNoOfModulesAsync();
        Task<int> GetNoOfModulesAsync(int yearId);
        Task<int> GetNoOfModulesAsync(int yearId, int courseId);
        
        Task<int> GetNoOfRentalsAsync();
        Task<int> GetNoOfRentalsAsync(int yearId);
        Task<int> GetNoOfRentalsAsync(int yearId, int bookId);
        Task<int> GetNoOfRentalsAsync(int yearId, int bookId, int userId);

        Task<int> GetNoOfRoomsAsync();
        Task<int> GetNoOfRoomsAsync(int yearId);
        Task<int> GetNoOfRoomsAsync(int yearId, int campusId);
        
        Task<int> GetNoOfStudentsAsync();
        Task<int> GetNoOfStudentsAsync(int yearId);
        Task<int> GetNoOfStudentsAsync(int yearId, int classificationId);
        Task<int> GetNoOfStudentsAsync(int yearId, int classificationId, int moduleId);*/
    }
}