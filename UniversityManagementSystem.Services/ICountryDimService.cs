using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Declares country dimension specific members that each country dimension service must implement.
    /// </summary>
    public interface ICountryDimService : IDimService<CountryDim>
    {
    }
}