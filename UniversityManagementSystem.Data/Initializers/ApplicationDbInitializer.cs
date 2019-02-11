using System.Data.Entity;
using System.Data.Entity.Migrations;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Initializers.Seeds;

namespace UniversityManagementSystem.Data.Initializers
{
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override async void Seed(ApplicationDbContext context)
        {
            context.Campuses.AddOrUpdate(CampusesSeed.ToArray());
            await context.SaveChangesAsync();

            context.Modules.AddOrUpdate(ModulesSeed.ToArray());
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