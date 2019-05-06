using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform room dimension related business logic.
    /// </summary>
    public class RoomDimService : DimServiceBase<RoomDim>, IRoomDimService
    {
        /// <inheritdoc />
        protected override DbSet<RoomDim> GetDbSet(ApplicationDbContext context)
        {
            return context.RoomDims;
        }
    }
}