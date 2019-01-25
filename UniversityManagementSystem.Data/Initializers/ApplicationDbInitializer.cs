using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;

namespace UniversityManagementSystem.Data.Initializers
{
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
        }
    }
}