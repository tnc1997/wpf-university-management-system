using System.Data.Entity.Migrations;

namespace UniversityManagementSystem.Data.Migrations
{
    public partial class DimensionalModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("S1502752.FactRentals", "BookId", "S1502752.DimBooks");
            DropForeignKey("S1502752.FactRentals", "UserId", "S1502752.DimUsers");
            DropForeignKey("S1502752.FactAssignments", "ModuleId", "S1502752.DimModules");
            DropForeignKey("S1502752.FactLectures", "ModuleId", "S1502752.DimModules");
            DropForeignKey("S1502752.FactLectures", "RoomId", "S1502752.DimRooms");
            DropForeignKey("S1502752.FactLectures", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactStudents", "ClassificationId", "S1502752.DimClassifications");
            DropForeignKey("S1502752.FactStudents", "ModuleId", "S1502752.DimModules");
            DropForeignKey("S1502752.FactStudents", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactAssignments", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactBooks", "LibraryId", "S1502752.DimLibraries");
            DropForeignKey("S1502752.FactBooks", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactGraduates", "CourseId", "S1502752.DimCourses");
            DropForeignKey("S1502752.FactModules", "CourseId", "S1502752.DimCourses");
            DropForeignKey("S1502752.FactModules", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactGraduates", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactHalls", "CampusId", "S1502752.DimCampus");
            DropForeignKey("S1502752.FactLibraries", "CampusId", "S1502752.DimCampus");
            DropForeignKey("S1502752.FactLibraries", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactRooms", "CampusId", "S1502752.DimCampus");
            DropForeignKey("S1502752.FactRooms", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactHalls", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactRentals", "YearId", "S1502752.DimYears");
            DropIndex("S1502752.FactRentals", new[] {"BookId"});
            DropIndex("S1502752.FactRentals", new[] {"UserId"});
            DropIndex("S1502752.FactAssignments", new[] {"ModuleId"});
            DropIndex("S1502752.FactLectures", new[] {"ModuleId"});
            DropIndex("S1502752.FactLectures", new[] {"RoomId"});
            DropIndex("S1502752.FactLectures", new[] {"YearId"});
            DropIndex("S1502752.FactStudents", new[] {"ClassificationId"});
            DropIndex("S1502752.FactStudents", new[] {"ModuleId"});
            DropIndex("S1502752.FactStudents", new[] {"YearId"});
            DropIndex("S1502752.FactAssignments", new[] {"YearId"});
            DropIndex("S1502752.FactBooks", new[] {"LibraryId"});
            DropIndex("S1502752.FactBooks", new[] {"YearId"});
            DropIndex("S1502752.FactGraduates", new[] {"CourseId"});
            DropIndex("S1502752.FactModules", new[] {"CourseId"});
            DropIndex("S1502752.FactModules", new[] {"YearId"});
            DropIndex("S1502752.FactGraduates", new[] {"YearId"});
            DropIndex("S1502752.FactHalls", new[] {"CampusId"});
            DropIndex("S1502752.FactLibraries", new[] {"CampusId"});
            DropIndex("S1502752.FactLibraries", new[] {"YearId"});
            DropIndex("S1502752.FactRooms", new[] {"CampusId"});
            DropIndex("S1502752.FactRooms", new[] {"YearId"});
            DropIndex("S1502752.FactHalls", new[] {"YearId"});
            DropIndex("S1502752.FactRentals", new[] {"YearId"});
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
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Code = c.String(),
                        Title = c.String()
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
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
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
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
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
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
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
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
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
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(),
                        Author = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.UserDims",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        FirstName = c.String(),
                        LastName = c.String()
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
                        Classification = c.String()
                    })
                .PrimaryKey(t => t.Id);

            DropTable("S1502752.DimBooks");
            DropTable("S1502752.FactRentals");
            DropTable("S1502752.DimUsers");
            DropTable("S1502752.DimYears");
            DropTable("S1502752.FactAssignments");
            DropTable("S1502752.DimModules");
            DropTable("S1502752.FactLectures");
            DropTable("S1502752.DimRooms");
            DropTable("S1502752.FactStudents");
            DropTable("S1502752.DimClassifications");
            DropTable("S1502752.FactBooks");
            DropTable("S1502752.DimLibraries");
            DropTable("S1502752.FactGraduates");
            DropTable("S1502752.DimCourses");
            DropTable("S1502752.FactModules");
            DropTable("S1502752.FactHalls");
            DropTable("S1502752.DimCampus");
            DropTable("S1502752.FactLibraries");
            DropTable("S1502752.FactRooms");
        }

        public override void Down()
        {
            CreateTable(
                    "S1502752.FactRooms",
                    c => new
                    {
                        CampusId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfRooms = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusId, t.YearId});

            CreateTable(
                    "S1502752.FactLibraries",
                    c => new
                    {
                        CampusId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfLibraries = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusId, t.YearId});

            CreateTable(
                    "S1502752.DimCampus",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactHalls",
                    c => new
                    {
                        CampusId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfHalls = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusId, t.YearId});

            CreateTable(
                    "S1502752.FactModules",
                    c => new
                    {
                        CourseId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfModules = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CourseId, t.YearId});

            CreateTable(
                    "S1502752.DimCourses",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactGraduates",
                    c => new
                    {
                        CourseId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfGraduates = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CourseId, t.YearId});

            CreateTable(
                    "S1502752.DimLibraries",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactBooks",
                    c => new
                    {
                        LibraryId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfBooks = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.LibraryId, t.YearId});

            CreateTable(
                    "S1502752.DimClassifications",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Classification = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactStudents",
                    c => new
                    {
                        ModuleId = c.Decimal(false, 10, 0),
                        ClassificationId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfStudents = c.Decimal(false, 10, 0),
                        DimCampus_Id = c.Decimal(precision: 10, scale: 0)
                    })
                .PrimaryKey(t => new {t.ModuleId, t.ClassificationId, t.YearId});

            CreateTable(
                    "S1502752.DimRooms",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactLectures",
                    c => new
                    {
                        ModuleId = c.Decimal(false, 10, 0),
                        RoomId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfLectures = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.ModuleId, t.RoomId, t.YearId});

            CreateTable(
                    "S1502752.DimModules",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Code = c.String(),
                        Title = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactAssignments",
                    c => new
                    {
                        ModuleId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfAssignments = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.ModuleId, t.YearId});

            CreateTable(
                    "S1502752.DimYears",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Year = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.DimUsers",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        FirstName = c.String(),
                        LastName = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactRentals",
                    c => new
                    {
                        UserId = c.Decimal(false, 10, 0),
                        BookId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfRentals = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.UserId, t.BookId, t.YearId});

            CreateTable(
                    "S1502752.DimBooks",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(),
                        Author = c.String()
                    })
                .PrimaryKey(t => t.Id);

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
            CreateIndex("S1502752.FactRentals", "YearId");
            CreateIndex("S1502752.FactHalls", "YearId");
            CreateIndex("S1502752.FactStudents", "DimCampus_Id");
            CreateIndex("S1502752.FactRooms", "YearId");
            CreateIndex("S1502752.FactRooms", "CampusId");
            CreateIndex("S1502752.FactLibraries", "YearId");
            CreateIndex("S1502752.FactLibraries", "CampusId");
            CreateIndex("S1502752.FactHalls", "CampusId");
            CreateIndex("S1502752.FactGraduates", "YearId");
            CreateIndex("S1502752.FactModules", "YearId");
            CreateIndex("S1502752.FactModules", "CourseId");
            CreateIndex("S1502752.FactGraduates", "CourseId");
            CreateIndex("S1502752.FactBooks", "YearId");
            CreateIndex("S1502752.FactBooks", "LibraryId");
            CreateIndex("S1502752.FactAssignments", "YearId");
            CreateIndex("S1502752.FactStudents", "YearId");
            CreateIndex("S1502752.FactStudents", "ModuleId");
            CreateIndex("S1502752.FactStudents", "ClassificationId");
            CreateIndex("S1502752.FactLectures", "YearId");
            CreateIndex("S1502752.FactLectures", "RoomId");
            CreateIndex("S1502752.FactLectures", "ModuleId");
            CreateIndex("S1502752.FactAssignments", "ModuleId");
            CreateIndex("S1502752.FactRentals", "UserId");
            CreateIndex("S1502752.FactRentals", "BookId");
            AddForeignKey("S1502752.FactRentals", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactHalls", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactStudents", "DimCampus_Id", "S1502752.DimCampus", "Id");
            AddForeignKey("S1502752.FactRooms", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactRooms", "CampusId", "S1502752.DimCampus", "Id", true);
            AddForeignKey("S1502752.FactLibraries", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactLibraries", "CampusId", "S1502752.DimCampus", "Id", true);
            AddForeignKey("S1502752.FactHalls", "CampusId", "S1502752.DimCampus", "Id", true);
            AddForeignKey("S1502752.FactGraduates", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactModules", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactModules", "CourseId", "S1502752.DimCourses", "Id", true);
            AddForeignKey("S1502752.FactGraduates", "CourseId", "S1502752.DimCourses", "Id", true);
            AddForeignKey("S1502752.FactBooks", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactBooks", "LibraryId", "S1502752.DimLibraries", "Id", true);
            AddForeignKey("S1502752.FactAssignments", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactStudents", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactStudents", "ModuleId", "S1502752.DimModules", "Id", true);
            AddForeignKey("S1502752.FactStudents", "ClassificationId", "S1502752.DimClassifications", "Id", true);
            AddForeignKey("S1502752.FactLectures", "YearId", "S1502752.DimYears", "Id", true);
            AddForeignKey("S1502752.FactLectures", "RoomId", "S1502752.DimRooms", "Id", true);
            AddForeignKey("S1502752.FactLectures", "ModuleId", "S1502752.DimModules", "Id", true);
            AddForeignKey("S1502752.FactAssignments", "ModuleId", "S1502752.DimModules", "Id", true);
            AddForeignKey("S1502752.FactRentals", "UserId", "S1502752.DimUsers", "Id", true);
            AddForeignKey("S1502752.FactRentals", "BookId", "S1502752.DimBooks", "Id", true);
        }
    }
}