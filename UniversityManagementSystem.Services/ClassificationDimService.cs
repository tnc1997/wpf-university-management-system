using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class ClassificationDimService : DimServiceBase<ClassificationDim>, IClassificationDimService
    {
        protected override DbSet<ClassificationDim> GetDbSet(ApplicationDbContext context)
        {
            return context.ClassificationDims;
        }
    }
}