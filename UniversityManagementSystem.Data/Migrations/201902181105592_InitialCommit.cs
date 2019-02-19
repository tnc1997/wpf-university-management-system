using System.Data.Entity.Migrations;

namespace UniversityManagementSystem.Data.Migrations
{
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "S1502752.AssignmentFacts",
                    c => new
                    {
                        ModuleDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.ModuleDimId, t.YearDimId})
                .ForeignKey("S1502752.ModuleDims", t => t.ModuleDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.ModuleDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.ModuleDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0),
                        Code = c.String(maxLength: 2000),
                        Title = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.LectureFacts",
                    c => new
                    {
                        ModuleDimId = c.Decimal(false, 10, 0),
                        RoomDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.ModuleDimId, t.RoomDimId, t.YearDimId})
                .ForeignKey("S1502752.ModuleDims", t => t.ModuleDimId, true)
                .ForeignKey("S1502752.RoomDims", t => t.RoomDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.ModuleDimId)
                .Index(t => t.RoomDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.RoomDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0),
                        Name = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.YearDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Year = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.BookFacts",
                    c => new
                    {
                        LibraryDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.LibraryDimId, t.YearDimId})
                .ForeignKey("S1502752.LibraryDims", t => t.LibraryDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.LibraryDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.LibraryDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0),
                        Name = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.GraduationFacts",
                    c => new
                    {
                        CourseDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CourseDimId, t.YearDimId})
                .ForeignKey("S1502752.CourseDims", t => t.CourseDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.CourseDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.CourseDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0),
                        Name = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.ModuleFacts",
                    c => new
                    {
                        CourseDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CourseDimId, t.YearDimId})
                .ForeignKey("S1502752.CourseDims", t => t.CourseDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.CourseDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.HallFacts",
                    c => new
                    {
                        CampusDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusDimId, t.YearDimId})
                .ForeignKey("S1502752.CampusDims", t => t.CampusDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.CampusDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.CampusDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0),
                        Name = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.LibraryFacts",
                    c => new
                    {
                        CampusDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusDimId, t.YearDimId})
                .ForeignKey("S1502752.CampusDims", t => t.CampusDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.CampusDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.RoomFacts",
                    c => new
                    {
                        CampusDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusDimId, t.YearDimId})
                .ForeignKey("S1502752.CampusDims", t => t.CampusDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.CampusDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.RentalFacts",
                    c => new
                    {
                        UserDimId = c.Decimal(false, 10, 0),
                        BookDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.UserDimId, t.BookDimId, t.YearDimId})
                .ForeignKey("S1502752.BookDims", t => t.BookDimId, true)
                .ForeignKey("S1502752.UserDims", t => t.UserDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.BookDimId)
                .Index(t => t.UserDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.BookDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0),
                        Name = c.String(maxLength: 2000),
                        Author = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.UserDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0),
                        FirstName = c.String(maxLength: 2000),
                        LastName = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.StudentFacts",
                    c => new
                    {
                        ModuleDimId = c.Decimal(false, 10, 0),
                        ClassificationDimId = c.Decimal(false, 10, 0),
                        YearDimId = c.Decimal(false, 10, 0),
                        Count = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.ModuleDimId, t.ClassificationDimId, t.YearDimId})
                .ForeignKey("S1502752.ClassificationDims", t => t.ClassificationDimId, true)
                .ForeignKey("S1502752.ModuleDims", t => t.ModuleDimId, true)
                .ForeignKey("S1502752.YearDims", t => t.YearDimId, true)
                .Index(t => t.ClassificationDimId)
                .Index(t => t.ModuleDimId)
                .Index(t => t.YearDimId);

            CreateTable(
                    "S1502752.ClassificationDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Classification = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.Assignments",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Title = c.String(maxLength: 2000),
                        Details = c.String(maxLength: 2000),
                        Deadline = c.DateTime(false),
                        RunId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Runs", t => t.RunId, true)
                .Index(t => t.RunId);

            CreateTable(
                    "S1502752.Results",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Grade = c.Decimal(false, 10, 0),
                        Feedback = c.String(maxLength: 2000),
                        UserId = c.Decimal(false, 10, 0),
                        AssignmentId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Assignments", t => t.AssignmentId, true)
                .ForeignKey("S1502752.Users", t => t.UserId, true)
                .Index(t => t.AssignmentId)
                .Index(t => t.UserId);

            CreateTable(
                    "S1502752.Users",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        UserName = c.String(maxLength: 2000),
                        PasswordHash = c.String(maxLength: 2000),
                        FirstName = c.String(maxLength: 2000),
                        LastName = c.String(maxLength: 2000),
                        CourseId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Courses", t => t.CourseId, true)
                .Index(t => t.CourseId);

            CreateTable(
                    "S1502752.Courses",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(maxLength: 2000),
                        CampusId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Campus", t => t.CampusId, true)
                .Index(t => t.CampusId);

            CreateTable(
                    "S1502752.Campus",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.Halls",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(maxLength: 2000),
                        CampusId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Campus", t => t.CampusId, true)
                .Index(t => t.CampusId);

            CreateTable(
                    "S1502752.Libraries",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(maxLength: 2000),
                        CampusId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Campus", t => t.CampusId, true)
                .Index(t => t.CampusId);

            CreateTable(
                    "S1502752.LibraryBooks",
                    c => new
                    {
                        LibraryId = c.Decimal(false, 10, 0),
                        BookId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.LibraryId, t.BookId})
                .ForeignKey("S1502752.Books", t => t.BookId, true)
                .ForeignKey("S1502752.Libraries", t => t.LibraryId, true)
                .Index(t => t.BookId)
                .Index(t => t.LibraryId);

            CreateTable(
                    "S1502752.Books",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(maxLength: 2000),
                        Author = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.Rentals",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        CheckoutDate = c.DateTime(false),
                        ReturnDate = c.DateTime(false),
                        UserId = c.Decimal(false, 10, 0),
                        BookId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Books", t => t.BookId, true)
                .ForeignKey("S1502752.Users", t => t.UserId, true)
                .Index(t => t.BookId)
                .Index(t => t.UserId);

            CreateTable(
                    "S1502752.Rooms",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(maxLength: 2000),
                        CampusId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Campus", t => t.CampusId, true)
                .Index(t => t.CampusId);

            CreateTable(
                    "S1502752.Lectures",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        DateTime = c.DateTime(false),
                        Duration = c.Decimal(false, 10, 0),
                        RunId = c.Decimal(false, 10, 0),
                        RoomId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Rooms", t => t.RoomId, true)
                .ForeignKey("S1502752.Runs", t => t.RunId, true)
                .Index(t => t.RoomId)
                .Index(t => t.RunId);

            CreateTable(
                    "S1502752.Runs",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Year = c.Decimal(false, 10, 0),
                        Semester = c.String(maxLength: 2000),
                        ModuleId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Modules", t => t.ModuleId, true)
                .Index(t => t.ModuleId);

            CreateTable(
                    "S1502752.Enrolments",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Year = c.Decimal(false, 10, 0),
                        UserId = c.Decimal(false, 10, 0),
                        RunId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Runs", t => t.RunId, true)
                .ForeignKey("S1502752.Users", t => t.UserId, true)
                .Index(t => t.RunId)
                .Index(t => t.UserId);

            CreateTable(
                    "S1502752.Modules",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Code = c.String(maxLength: 2000),
                        Title = c.String(maxLength: 2000)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.CourseModules",
                    c => new
                    {
                        CourseId = c.Decimal(false, 10, 0),
                        ModuleId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CourseId, t.ModuleId})
                .ForeignKey("S1502752.Courses", t => t.CourseId, true)
                .ForeignKey("S1502752.Modules", t => t.ModuleId, true)
                .Index(t => t.CourseId)
                .Index(t => t.ModuleId);

            CreateTable(
                    "S1502752.Graduations",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Year = c.Decimal(false, 10, 0),
                        UserId = c.Decimal(false, 10, 0),
                        CourseId = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1502752.Courses", t => t.CourseId, true)
                .ForeignKey("S1502752.Users", t => t.UserId, true)
                .Index(t => t.CourseId)
                .Index(t => t.UserId);
        }

        public override void Down()
        {
            DropForeignKey("S1502752.Results", "UserId", "S1502752.Users");
            DropForeignKey("S1502752.Users", "CourseId", "S1502752.Courses");
            DropForeignKey("S1502752.Graduations", "UserId", "S1502752.Users");
            DropForeignKey("S1502752.Graduations", "CourseId", "S1502752.Courses");
            DropForeignKey("S1502752.Runs", "ModuleId", "S1502752.Modules");
            DropForeignKey("S1502752.CourseModules", "ModuleId", "S1502752.Modules");
            DropForeignKey("S1502752.CourseModules", "CourseId", "S1502752.Courses");
            DropForeignKey("S1502752.Lectures", "RunId", "S1502752.Runs");
            DropForeignKey("S1502752.Enrolments", "UserId", "S1502752.Users");
            DropForeignKey("S1502752.Enrolments", "RunId", "S1502752.Runs");
            DropForeignKey("S1502752.Assignments", "RunId", "S1502752.Runs");
            DropForeignKey("S1502752.Lectures", "RoomId", "S1502752.Rooms");
            DropForeignKey("S1502752.Rooms", "CampusId", "S1502752.Campus");
            DropForeignKey("S1502752.LibraryBooks", "LibraryId", "S1502752.Libraries");
            DropForeignKey("S1502752.Rentals", "UserId", "S1502752.Users");
            DropForeignKey("S1502752.Rentals", "BookId", "S1502752.Books");
            DropForeignKey("S1502752.LibraryBooks", "BookId", "S1502752.Books");
            DropForeignKey("S1502752.Libraries", "CampusId", "S1502752.Campus");
            DropForeignKey("S1502752.Halls", "CampusId", "S1502752.Campus");
            DropForeignKey("S1502752.Courses", "CampusId", "S1502752.Campus");
            DropForeignKey("S1502752.Results", "AssignmentId", "S1502752.Assignments");
            DropForeignKey("S1502752.StudentFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.StudentFacts", "ModuleDimId", "S1502752.ModuleDims");
            DropForeignKey("S1502752.StudentFacts", "ClassificationDimId", "S1502752.ClassificationDims");
            DropForeignKey("S1502752.RentalFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.RentalFacts", "UserDimId", "S1502752.UserDims");
            DropForeignKey("S1502752.RentalFacts", "BookDimId", "S1502752.BookDims");
            DropForeignKey("S1502752.LectureFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.HallFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.RoomFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.RoomFacts", "CampusDimId", "S1502752.CampusDims");
            DropForeignKey("S1502752.LibraryFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.LibraryFacts", "CampusDimId", "S1502752.CampusDims");
            DropForeignKey("S1502752.HallFacts", "CampusDimId", "S1502752.CampusDims");
            DropForeignKey("S1502752.GraduationFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.ModuleFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.ModuleFacts", "CourseDimId", "S1502752.CourseDims");
            DropForeignKey("S1502752.GraduationFacts", "CourseDimId", "S1502752.CourseDims");
            DropForeignKey("S1502752.BookFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.BookFacts", "LibraryDimId", "S1502752.LibraryDims");
            DropForeignKey("S1502752.AssignmentFacts", "YearDimId", "S1502752.YearDims");
            DropForeignKey("S1502752.LectureFacts", "RoomDimId", "S1502752.RoomDims");
            DropForeignKey("S1502752.LectureFacts", "ModuleDimId", "S1502752.ModuleDims");
            DropForeignKey("S1502752.AssignmentFacts", "ModuleDimId", "S1502752.ModuleDims");
            DropIndex("S1502752.Results", new[] {"UserId"});
            DropIndex("S1502752.Users", new[] {"CourseId"});
            DropIndex("S1502752.Graduations", new[] {"UserId"});
            DropIndex("S1502752.Graduations", new[] {"CourseId"});
            DropIndex("S1502752.Runs", new[] {"ModuleId"});
            DropIndex("S1502752.CourseModules", new[] {"ModuleId"});
            DropIndex("S1502752.CourseModules", new[] {"CourseId"});
            DropIndex("S1502752.Lectures", new[] {"RunId"});
            DropIndex("S1502752.Enrolments", new[] {"UserId"});
            DropIndex("S1502752.Enrolments", new[] {"RunId"});
            DropIndex("S1502752.Assignments", new[] {"RunId"});
            DropIndex("S1502752.Lectures", new[] {"RoomId"});
            DropIndex("S1502752.Rooms", new[] {"CampusId"});
            DropIndex("S1502752.LibraryBooks", new[] {"LibraryId"});
            DropIndex("S1502752.Rentals", new[] {"UserId"});
            DropIndex("S1502752.Rentals", new[] {"BookId"});
            DropIndex("S1502752.LibraryBooks", new[] {"BookId"});
            DropIndex("S1502752.Libraries", new[] {"CampusId"});
            DropIndex("S1502752.Halls", new[] {"CampusId"});
            DropIndex("S1502752.Courses", new[] {"CampusId"});
            DropIndex("S1502752.Results", new[] {"AssignmentId"});
            DropIndex("S1502752.StudentFacts", new[] {"YearDimId"});
            DropIndex("S1502752.StudentFacts", new[] {"ModuleDimId"});
            DropIndex("S1502752.StudentFacts", new[] {"ClassificationDimId"});
            DropIndex("S1502752.RentalFacts", new[] {"YearDimId"});
            DropIndex("S1502752.RentalFacts", new[] {"UserDimId"});
            DropIndex("S1502752.RentalFacts", new[] {"BookDimId"});
            DropIndex("S1502752.LectureFacts", new[] {"YearDimId"});
            DropIndex("S1502752.HallFacts", new[] {"YearDimId"});
            DropIndex("S1502752.RoomFacts", new[] {"YearDimId"});
            DropIndex("S1502752.RoomFacts", new[] {"CampusDimId"});
            DropIndex("S1502752.LibraryFacts", new[] {"YearDimId"});
            DropIndex("S1502752.LibraryFacts", new[] {"CampusDimId"});
            DropIndex("S1502752.HallFacts", new[] {"CampusDimId"});
            DropIndex("S1502752.GraduationFacts", new[] {"YearDimId"});
            DropIndex("S1502752.ModuleFacts", new[] {"YearDimId"});
            DropIndex("S1502752.ModuleFacts", new[] {"CourseDimId"});
            DropIndex("S1502752.GraduationFacts", new[] {"CourseDimId"});
            DropIndex("S1502752.BookFacts", new[] {"YearDimId"});
            DropIndex("S1502752.BookFacts", new[] {"LibraryDimId"});
            DropIndex("S1502752.AssignmentFacts", new[] {"YearDimId"});
            DropIndex("S1502752.LectureFacts", new[] {"RoomDimId"});
            DropIndex("S1502752.LectureFacts", new[] {"ModuleDimId"});
            DropIndex("S1502752.AssignmentFacts", new[] {"ModuleDimId"});
            DropTable("S1502752.Graduations");
            DropTable("S1502752.CourseModules");
            DropTable("S1502752.Modules");
            DropTable("S1502752.Enrolments");
            DropTable("S1502752.Runs");
            DropTable("S1502752.Lectures");
            DropTable("S1502752.Rooms");
            DropTable("S1502752.Rentals");
            DropTable("S1502752.Books");
            DropTable("S1502752.LibraryBooks");
            DropTable("S1502752.Libraries");
            DropTable("S1502752.Halls");
            DropTable("S1502752.Campus");
            DropTable("S1502752.Courses");
            DropTable("S1502752.Users");
            DropTable("S1502752.Results");
            DropTable("S1502752.Assignments");
            DropTable("S1502752.ClassificationDims");
            DropTable("S1502752.StudentFacts");
            DropTable("S1502752.UserDims");
            DropTable("S1502752.BookDims");
            DropTable("S1502752.RentalFacts");
            DropTable("S1502752.RoomFacts");
            DropTable("S1502752.LibraryFacts");
            DropTable("S1502752.CampusDims");
            DropTable("S1502752.HallFacts");
            DropTable("S1502752.ModuleFacts");
            DropTable("S1502752.CourseDims");
            DropTable("S1502752.GraduationFacts");
            DropTable("S1502752.LibraryDims");
            DropTable("S1502752.BookFacts");
            DropTable("S1502752.YearDims");
            DropTable("S1502752.RoomDims");
            DropTable("S1502752.LectureFacts");
            DropTable("S1502752.ModuleDims");
            DropTable("S1502752.AssignmentFacts");
        }
    }
}