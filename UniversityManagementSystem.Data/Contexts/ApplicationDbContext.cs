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

            modelBuilder.Entity<FactAssignment>()
                .HasKey(assignment => new {assignment.ModuleId, assignment.YearId});

            modelBuilder.Entity<FactBook>()
                .HasKey(book => new {book.LibraryId, book.YearId});

            modelBuilder.Entity<FactGraduate>()
                .HasKey(graduate => new {graduate.CourseId, graduate.YearId});

            modelBuilder.Entity<FactHall>()
                .HasKey(hall => new {hall.CampusId, hall.YearId});

            modelBuilder.Entity<FactLecture>()
                .HasKey(lecture => new {lecture.ModuleId, lecture.RoomId, lecture.YearId});

            modelBuilder.Entity<FactLibrary>()
                .HasKey(library => new {library.CampusId, library.YearId});

            modelBuilder.Entity<FactModule>()
                .HasKey(module => new {module.CourseId, module.YearId});

            modelBuilder.Entity<FactRental>()
                .HasKey(rental => new {rental.UserId, rental.BookId, rental.YearId});

            modelBuilder.Entity<FactRoom>()
                .HasKey(room => new {room.CampusId, room.YearId});

            modelBuilder.Entity<FactStudent>()
                .HasKey(student => new {student.ModuleId, student.ClassificationId, student.YearId});

            #endregion

            #endregion
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

        public DbSet<DimBook> DimBooks { get; set; }

        public DbSet<DimCampus> DimCampuses { get; set; }

        public DbSet<DimCourse> DimCourses { get; set; }

        public DbSet<DimLibrary> DimLibraries { get; set; }

        public DbSet<DimModule> DimModules { get; set; }

        public DbSet<DimRoom> DimRooms { get; set; }

        public DbSet<DimUser> DimUsers { get; set; }

        public DbSet<DimYear> DimYears { get; set; }

        public DbSet<FactAssignment> FactAssignments { get; set; }

        public DbSet<FactBook> FactBooks { get; set; }

        public DbSet<FactGraduate> FactGraduates { get; set; }

        public DbSet<FactHall> FactHalls { get; set; }

        public DbSet<FactLecture> FactLectures { get; set; }

        public DbSet<FactLibrary> FactLibraries { get; set; }

        public DbSet<FactModule> FactModules { get; set; }

        public DbSet<FactRental> FactRentals { get; set; }

        public DbSet<FactRoom> FactRooms { get; set; }

        public DbSet<FactStudent> FactStudents { get; set; }

        #endregion
    }
}