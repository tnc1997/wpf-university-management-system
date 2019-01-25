using System.Data.Entity.Migrations;
using UniversityManagementSystem.Data.Contexts;

namespace UniversityManagementSystem.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}