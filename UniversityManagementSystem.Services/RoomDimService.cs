using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class RoomDimService : DimServiceBase<RoomDim>, IRoomDimService
    {
        protected override DbSet<RoomDim> GetDbSet(ApplicationDbContext context)
        {
            return context.RoomDims;
        }
    }
}