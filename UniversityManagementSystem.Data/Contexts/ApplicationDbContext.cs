using System.Data.Entity;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Data.Initializers;

namespace UniversityManagementSystem.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Default")
        {
            Database.SetInitializer(new ApplicationDbInitializer());
        }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Campus> Campuses { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseModule> CourseModules { get; set; }

        public DbSet<Enrolment> Enrolments { get; set; }

        public DbSet<Graduation> Graduations { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Lecture> Lectures { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<LibraryBook> LibraryBooks { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Run> Runs { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("S1502752");

            #region Composite Primary Keys

            modelBuilder.Entity<CourseModule>()
                .HasKey(courseModule => new {courseModule.CourseId, courseModule.ModuleId});

            modelBuilder.Entity<LibraryBook>()
                .HasKey(libraryBook => new {libraryBook.LibraryId, libraryBook.BookId});

            #endregion
        }
    }
}