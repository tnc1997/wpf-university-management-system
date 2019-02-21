using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
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

            bool Predicate(System.Reflection.PropertyInfo propertyInfo) =>
                propertyInfo.PropertyType == typeof(string) &&
                propertyInfo.GetCustomAttributes(typeof(MaxLengthAttribute), false).Length == 0;

            void ConfigurationAction(ConventionPrimitivePropertyConfiguration propertyConfiguration) =>
                propertyConfiguration.HasMaxLength(2000);

            modelBuilder
                .Properties()
                .Where(Predicate)
                .Configure(ConfigurationAction);

            #region Operational Database

            #region Composite Primary Keys

            modelBuilder
                .Entity<CourseModule>()
                .HasKey(courseModule => new {courseModule.CourseId, courseModule.ModuleId});

            modelBuilder
                .Entity<LibraryBook>()
                .HasKey(libraryBook => new {libraryBook.LibraryId, libraryBook.BookId});

            modelBuilder
                .Entity<UserRole>()
                .HasKey(userRole => new {userRole.UserId, userRole.RoleId});

            #endregion

            #endregion

            #region Data Warehouse

            #region Composite Primary Keys

            modelBuilder
                .Entity<AssignmentFact>()
                .HasKey(assignment => new {assignment.ModuleDimId, assignment.YearDimId});

            modelBuilder
                .Entity<BookFact>()
                .HasKey(book => new {book.LibraryDimId, book.YearDimId});

            modelBuilder
                .Entity<EnrolmentFact>()
                .HasKey(enrolment => new {enrolment.ModuleDimId, enrolment.YearDimId});

            modelBuilder
                .Entity<GraduationFact>()
                .HasKey(graduate => new {graduate.CourseDimId, graduate.YearDimId});

            modelBuilder
                .Entity<HallFact>()
                .HasKey(hall => new {hall.CampusDimId, hall.YearDimId});

            modelBuilder
                .Entity<LectureFact>()
                .HasKey(lecture => new {lecture.ModuleDimId, lecture.RoomDimId, lecture.YearDimId});

            modelBuilder
                .Entity<LibraryFact>()
                .HasKey(library => new {library.CampusDimId, library.YearDimId});

            modelBuilder
                .Entity<ModuleFact>()
                .HasKey(module => new {module.CourseDimId, module.YearDimId});

            modelBuilder
                .Entity<RentalFact>()
                .HasKey(rental => new {rental.UserDimId, rental.BookDimId, rental.YearDimId});

            modelBuilder
                .Entity<RoomFact>()
                .HasKey(room => new {room.CampusDimId, room.YearDimId});

            modelBuilder
                .Entity<ResultFact>()
                .HasKey(result => new {result.ModuleDimId, result.ClassificationDimId, result.YearDimId});

            modelBuilder
                .Entity<StudentFact>()
                .HasKey(student => new {student.CountryDimId, student.YearDimId});

            #endregion

            #region Disable Auto-Generated Primary Keys
            
            modelBuilder
                .Entity<BookDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder
                .Entity<CampusDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder
                .Entity<CountryDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder
                .Entity<CourseDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder
                .Entity<LibraryDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder
                .Entity<ModuleDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder
                .Entity<RoomDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder
                .Entity<UserDim>()
                .Property(dim => dim.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            #endregion

            #endregion
        }

        #region Operational Database

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Campus> Campuses { get; set; }
        
        public DbSet<Country> Countries { get; set; }

        public DbSet<CourseModule> CourseModules { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrolment> Enrolments { get; set; }

        public DbSet<Graduation> Graduations { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Lecture> Lectures { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<LibraryBook> LibraryBooks { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public DbSet<Result> Results { get; set; }
        
        public DbSet<Role> Roles { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Run> Runs { get; set; }
        
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<User> Users { get; set; }

        #endregion

        #region Data Warehouse
        
        #region Dims

        public DbSet<BookDim> BookDims { get; set; }

        public DbSet<CampusDim> CampusDims { get; set; }
        
        public DbSet<ClassificationDim> ClassificationDims { get; set; }
        
        public DbSet<CountryDim> CountryDims { get; set; }

        public DbSet<CourseDim> CourseDims { get; set; }

        public DbSet<LibraryDim> LibraryDims { get; set; }

        public DbSet<ModuleDim> ModuleDims { get; set; }

        public DbSet<RoomDim> RoomDims { get; set; }

        public DbSet<UserDim> UserDims { get; set; }

        public DbSet<YearDim> YearDims { get; set; }
        
        #endregion
        
        #region Facts

        public DbSet<AssignmentFact> AssignmentFacts { get; set; }

        public DbSet<BookFact> BookFacts { get; set; }
        
        public DbSet<EnrolmentFact> EnrolmentFacts { get; set; }

        public DbSet<GraduationFact> GraduationFacts { get; set; }

        public DbSet<HallFact> HallFacts { get; set; }

        public DbSet<LectureFact> LectureFacts { get; set; }

        public DbSet<LibraryFact> LibraryFacts { get; set; }

        public DbSet<ModuleFact> ModuleFacts { get; set; }

        public DbSet<RentalFact> RentalFacts { get; set; }

        public DbSet<ResultFact> ResultFacts { get; set; }

        public DbSet<RoomFact> RoomFacts { get; set; }

        public DbSet<StudentFact> StudentFacts { get; set; }
        
        #endregion

        #endregion
    }
}