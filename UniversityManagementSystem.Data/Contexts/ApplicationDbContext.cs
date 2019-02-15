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

            modelBuilder.Entity<AssignmentFact>()
                .HasKey(assignment => new {assignment.ModuleDimId, assignment.YearDimId});

            modelBuilder.Entity<BookFact>()
                .HasKey(book => new {book.LibraryDimId, book.YearDimId});

            modelBuilder.Entity<GraduationFact>()
                .HasKey(graduate => new {graduate.CourseDimId, graduate.YearDimId});

            modelBuilder.Entity<HallFact>()
                .HasKey(hall => new {hall.CampusDimId, hall.YearDimId});

            modelBuilder.Entity<LectureFact>()
                .HasKey(lecture => new {lecture.ModuleDimId, lecture.RoomDimId, lecture.YearDimId});

            modelBuilder.Entity<LibraryFact>()
                .HasKey(library => new {library.CampusDimId, library.YearDimId});

            modelBuilder.Entity<ModuleFact>()
                .HasKey(module => new {module.CourseDimId, module.YearDimId});

            modelBuilder.Entity<RentalFact>()
                .HasKey(rental => new {rental.UserDimId, rental.BookDimId, rental.YearDimId});

            modelBuilder.Entity<RoomFact>()
                .HasKey(room => new {room.CampusDimId, room.YearDimId});

            modelBuilder.Entity<StudentFact>()
                .HasKey(student => new {student.ModuleDimId, student.ClassificationDimId, student.YearDimId});

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

        public DbSet<BookDim> BookDims { get; set; }

        public DbSet<CampusDim> CampusDims { get; set; }
        
        public DbSet<ClassificationDim> ClassificationDims { get; set; }

        public DbSet<CourseDim> CourseDims { get; set; }

        public DbSet<LibraryDim> LibraryDims { get; set; }

        public DbSet<ModuleDim> ModuleDims { get; set; }

        public DbSet<RoomDim> RoomDims { get; set; }

        public DbSet<UserDim> UserDims { get; set; }

        public DbSet<YearDim> YearDims { get; set; }

        public DbSet<AssignmentFact> AssignmentFacts { get; set; }

        public DbSet<BookFact> BookFacts { get; set; }

        public DbSet<GraduationFact> GraduationFacts { get; set; }

        public DbSet<HallFact> HallFacts { get; set; }

        public DbSet<LectureFact> LectureFacts { get; set; }

        public DbSet<LibraryFact> LibraryFacts { get; set; }

        public DbSet<ModuleFact> ModuleFacts { get; set; }

        public DbSet<RentalFact> RentalFacts { get; set; }

        public DbSet<RoomFact> RoomFacts { get; set; }

        public DbSet<StudentFact> StudentFacts { get; set; }

        #endregion
    }
}