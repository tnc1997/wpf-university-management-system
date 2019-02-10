using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Initializers.Seeds;

namespace UniversityManagementSystem.Data.Initializers
{
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override async void Seed(ApplicationDbContext context)
        {
            context.Assignments.AddRange(AssignmentsSeed.ToList());

            context.Books.AddRange(BooksSeed.ToList());

            context.Campuses.AddRange(CampusesSeed.ToList());

            context.CourseModules.AddRange(CourseModulesSeed.ToList());

            context.Courses.AddRange(CoursesSeed.ToList());

            context.Enrolments.AddRange(EnrolmentsSeed.ToList());

            context.Graduations.AddRange(GraduationsSeed.ToList());

            context.Halls.AddRange(HallsSeed.ToList());

            context.Lectures.AddRange(LecturesSeed.ToList());

            context.Libraries.AddRange(LibrariesSeed.ToList());

            context.LibraryBooks.AddRange(LibraryBooksSeed.ToList());

            context.Modules.AddRange(ModulesSeed.ToList());

            context.Rentals.AddRange(RentalsSeed.ToList());

            context.Results.AddRange(ResultsSeed.ToList());

            context.Rooms.AddRange(RoomsSeed.ToList());

            context.Runs.AddRange(RunsSeed.ToList());

            context.Users.AddRange(UsersSeed.ToList());

            await context.SaveChangesAsync();
        }
    }
}