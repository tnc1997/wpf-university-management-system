using System.Data.Entity.Migrations;

namespace UniversityManagementSystem.Data.Migrations
{
    public partial class DimensionalModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "S1502752.DimBooks",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(),
                        Author = c.String()
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
                .PrimaryKey(t => new {t.UserId, t.BookId, t.YearId})
                .ForeignKey("S1502752.DimBooks", t => t.BookId, true)
                .ForeignKey("S1502752.DimUsers", t => t.UserId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.BookId)
                .Index(t => t.UserId)
                .Index(t => t.YearId);

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
                    "S1502752.DimYears",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Year = c.Decimal(false, 10, 0)
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
                .PrimaryKey(t => new {t.ModuleId, t.YearId})
                .ForeignKey("S1502752.DimModules", t => t.ModuleId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.ModuleId)
                .Index(t => t.YearId);

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
                    "S1502752.FactLectures",
                    c => new
                    {
                        ModuleId = c.Decimal(false, 10, 0),
                        RoomId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfLectures = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.ModuleId, t.RoomId, t.YearId})
                .ForeignKey("S1502752.DimModules", t => t.ModuleId, true)
                .ForeignKey("S1502752.DimRooms", t => t.RoomId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.ModuleId)
                .Index(t => t.RoomId)
                .Index(t => t.YearId);

            CreateTable(
                    "S1502752.DimRooms",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactStudents",
                    c => new
                    {
                        ModuleId = c.Decimal(false, 10, 0),
                        ClassificationId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfStudents = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.ModuleId, t.ClassificationId, t.YearId})
                .ForeignKey("S1502752.DimClassifications", t => t.ClassificationId, true)
                .ForeignKey("S1502752.DimModules", t => t.ModuleId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.ClassificationId)
                .Index(t => t.ModuleId)
                .Index(t => t.YearId);

            CreateTable(
                    "S1502752.DimClassifications",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Classification = c.String()
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
                .PrimaryKey(t => new {t.LibraryId, t.YearId})
                .ForeignKey("S1502752.DimLibraries", t => t.LibraryId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.LibraryId)
                .Index(t => t.YearId);

            CreateTable(
                    "S1502752.DimLibraries",
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
                .PrimaryKey(t => new {t.CourseId, t.YearId})
                .ForeignKey("S1502752.DimCourses", t => t.CourseId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.CourseId)
                .Index(t => t.YearId);

            CreateTable(
                    "S1502752.DimCourses",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactModules",
                    c => new
                    {
                        CourseId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfModules = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CourseId, t.YearId})
                .ForeignKey("S1502752.DimCourses", t => t.CourseId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.CourseId)
                .Index(t => t.YearId);

            CreateTable(
                    "S1502752.FactHalls",
                    c => new
                    {
                        CampusId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfHalls = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusId, t.YearId})
                .ForeignKey("S1502752.DimCampus", t => t.CampusId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.CampusId)
                .Index(t => t.YearId);

            CreateTable(
                    "S1502752.DimCampus",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.FactLibraries",
                    c => new
                    {
                        CampusId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfLibraries = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusId, t.YearId})
                .ForeignKey("S1502752.DimCampus", t => t.CampusId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.CampusId)
                .Index(t => t.YearId);

            CreateTable(
                    "S1502752.FactRooms",
                    c => new
                    {
                        CampusId = c.Decimal(false, 10, 0),
                        YearId = c.Decimal(false, 10, 0),
                        NoOfRooms = c.Decimal(false, 10, 0)
                    })
                .PrimaryKey(t => new {t.CampusId, t.YearId})
                .ForeignKey("S1502752.DimCampus", t => t.CampusId, true)
                .ForeignKey("S1502752.DimYears", t => t.YearId, true)
                .Index(t => t.CampusId)
                .Index(t => t.YearId);
        }

        public override void Down()
        {
            DropForeignKey("S1502752.FactRentals", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactHalls", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactRooms", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactRooms", "CampusId", "S1502752.DimCampus");
            DropForeignKey("S1502752.FactLibraries", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactLibraries", "CampusId", "S1502752.DimCampus");
            DropForeignKey("S1502752.FactHalls", "CampusId", "S1502752.DimCampus");
            DropForeignKey("S1502752.FactGraduates", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactModules", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactModules", "CourseId", "S1502752.DimCourses");
            DropForeignKey("S1502752.FactGraduates", "CourseId", "S1502752.DimCourses");
            DropForeignKey("S1502752.FactBooks", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactBooks", "LibraryId", "S1502752.DimLibraries");
            DropForeignKey("S1502752.FactAssignments", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactStudents", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactStudents", "ModuleId", "S1502752.DimModules");
            DropForeignKey("S1502752.FactStudents", "ClassificationId", "S1502752.DimClassifications");
            DropForeignKey("S1502752.FactLectures", "YearId", "S1502752.DimYears");
            DropForeignKey("S1502752.FactLectures", "RoomId", "S1502752.DimRooms");
            DropForeignKey("S1502752.FactLectures", "ModuleId", "S1502752.DimModules");
            DropForeignKey("S1502752.FactAssignments", "ModuleId", "S1502752.DimModules");
            DropForeignKey("S1502752.FactRentals", "UserId", "S1502752.DimUsers");
            DropForeignKey("S1502752.FactRentals", "BookId", "S1502752.DimBooks");
            DropIndex("S1502752.FactRentals", new[] {"YearId"});
            DropIndex("S1502752.FactHalls", new[] {"YearId"});
            DropIndex("S1502752.FactRooms", new[] {"YearId"});
            DropIndex("S1502752.FactRooms", new[] {"CampusId"});
            DropIndex("S1502752.FactLibraries", new[] {"YearId"});
            DropIndex("S1502752.FactLibraries", new[] {"CampusId"});
            DropIndex("S1502752.FactHalls", new[] {"CampusId"});
            DropIndex("S1502752.FactGraduates", new[] {"YearId"});
            DropIndex("S1502752.FactModules", new[] {"YearId"});
            DropIndex("S1502752.FactModules", new[] {"CourseId"});
            DropIndex("S1502752.FactGraduates", new[] {"CourseId"});
            DropIndex("S1502752.FactBooks", new[] {"YearId"});
            DropIndex("S1502752.FactBooks", new[] {"LibraryId"});
            DropIndex("S1502752.FactAssignments", new[] {"YearId"});
            DropIndex("S1502752.FactStudents", new[] {"YearId"});
            DropIndex("S1502752.FactStudents", new[] {"ModuleId"});
            DropIndex("S1502752.FactStudents", new[] {"ClassificationId"});
            DropIndex("S1502752.FactLectures", new[] {"YearId"});
            DropIndex("S1502752.FactLectures", new[] {"RoomId"});
            DropIndex("S1502752.FactLectures", new[] {"ModuleId"});
            DropIndex("S1502752.FactAssignments", new[] {"ModuleId"});
            DropIndex("S1502752.FactRentals", new[] {"UserId"});
            DropIndex("S1502752.FactRentals", new[] {"BookId"});
            DropTable("S1502752.FactRooms");
            DropTable("S1502752.FactLibraries");
            DropTable("S1502752.DimCampus");
            DropTable("S1502752.FactHalls");
            DropTable("S1502752.FactModules");
            DropTable("S1502752.DimCourses");
            DropTable("S1502752.FactGraduates");
            DropTable("S1502752.DimLibraries");
            DropTable("S1502752.FactBooks");
            DropTable("S1502752.DimClassifications");
            DropTable("S1502752.FactStudents");
            DropTable("S1502752.DimRooms");
            DropTable("S1502752.FactLectures");
            DropTable("S1502752.DimModules");
            DropTable("S1502752.FactAssignments");
            DropTable("S1502752.DimYears");
            DropTable("S1502752.DimUsers");
            DropTable("S1502752.FactRentals");
            DropTable("S1502752.DimBooks");
        }
    }
}