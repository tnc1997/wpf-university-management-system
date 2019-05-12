using System.Data.Entity;
using System.Data.Entity.Migrations;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Initializers.Seeds;

namespace UniversityManagementSystem.Data.Initializers
{
    /// <summary>
    ///     Defines members which initialize the database. If the database does not exist, then this class will create
    ///     all the tables and seed them with the data contained in the seed classes automatically.
    /// </summary>
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        /// <inheritdoc />
        protected override async void Seed(ApplicationDbContext context)
        {
            context.Campuses.AddOrUpdate(CampusesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Countries.AddOrUpdate(CountriesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Modules.AddOrUpdate(ModulesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Roles.AddOrUpdate(RolesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Runs.AddOrUpdate(RunsSeed.ToArray());
            await context.SaveChangesAsync();

            context.Assignments.AddOrUpdate(AssignmentsSeed.ToArray());
            await context.SaveChangesAsync();

            context.Books.AddOrUpdate(BooksSeed.ToArray());
            await context.SaveChangesAsync();

            context.Courses.AddOrUpdate(CoursesSeed.ToArray());
            await context.SaveChangesAsync();

            context.CourseModules.AddOrUpdate(CourseModulesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Users.AddOrUpdate(UsersSeed.ToArray());
            await context.SaveChangesAsync();

            context.UserRoles.AddOrUpdate(UserRolesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Results.AddOrUpdate(ResultsSeed.ToArray());
            await context.SaveChangesAsync();

            context.Rentals.AddOrUpdate(RentalsSeed.ToArray());
            await context.SaveChangesAsync();

            context.Enrolments.AddOrUpdate(EnrolmentsSeed.ToArray());
            await context.SaveChangesAsync();

            context.Rooms.AddOrUpdate(RoomsSeed.ToArray());
            await context.SaveChangesAsync();

            context.Lectures.AddOrUpdate(LecturesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Halls.AddOrUpdate(HallsSeed.ToArray());
            await context.SaveChangesAsync();

            context.Libraries.AddOrUpdate(LibrariesSeed.ToArray());
            await context.SaveChangesAsync();

            context.LibraryBooks.AddOrUpdate(LibraryBooksSeed.ToArray());
            await context.SaveChangesAsync();

            context.Graduations.AddOrUpdate(GraduationsSeed.ToArray());
            await context.SaveChangesAsync();
        }
    }
}