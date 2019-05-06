using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares rental fact specific members that each rental fact service must implement.
    /// </summary>
    public interface IRentalFactService : IFactService<RentalFact>
    {
    }
}