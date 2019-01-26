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
        
        #region Operational Database

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
        
        #endregion

        #region Data Warehouse

        public DbSet<Entities.Dimensions.Book> DimBooks { get; set; }
        
        public DbSet<Entities.Dimensions.Campus> DimCampuses { get; set; }
        
        public DbSet<Entities.Dimensions.Course> DimCourses { get; set; }
        
        public DbSet<Entities.Dimensions.Module> DimModules { get; set; }
        
        public DbSet<Entities.Dimensions.Time> DimTimes { get; set; }
        
        public DbSet<Entities.Facts.Graduate> FactGraduates { get; set; }
        
        public DbSet<Entities.Facts.Hall> FactHalls { get; set; }
        
        public DbSet<Entities.Facts.Library> FactLibraries { get; set; }
        
        public DbSet<Entities.Facts.Rental> FactRentals { get; set; }
        
        public DbSet<Entities.Facts.Room> FactRooms { get; set; }
        
        public DbSet<Entities.Facts.Student> FactStudents { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("S1502752");

            #region Operational Database
            
            #region Composite Primary Keys

            modelBuilder.Entity<CourseModule>()
                .HasKey(courseModule => new {courseModule.CourseId, courseModule.ModuleId});

            modelBuilder.Entity<LibraryBook>()
                .HasKey(libraryBook => new {libraryBook.LibraryId, libraryBook.BookId});
            
            #endregion

            #endregion

            #region Data Warehouse

            #region Composite Primary Keys

            modelBuilder.Entity<Entities.Facts.Graduate>()
                .HasKey(graduate => new {graduate.CourseId, graduate.TimeId});

            modelBuilder.Entity<Entities.Facts.Hall>()
                .HasKey(hall => new {hall.CampusId});

            modelBuilder.Entity<Entities.Facts.Library>()
                .HasKey(library => new {library.CampusId});

            modelBuilder.Entity<Entities.Facts.Rental>()
                .HasKey(rental => new {rental.BookId});

            modelBuilder.Entity<Entities.Facts.Room>()
                .HasKey(room => new {room.CampusId});

            modelBuilder.Entity<Entities.Facts.Student>()
                .HasKey(student => new {student.CampusId, student.CourseId, student.ModuleId, student.TimeId});

            #endregion

            #endregion
        }
    }
}