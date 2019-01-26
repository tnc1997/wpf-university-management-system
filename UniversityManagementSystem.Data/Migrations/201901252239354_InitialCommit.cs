﻿using System.Data.Entity.Migrations;

namespace UniversityManagementSystem.Data.Migrations
{
    public partial class InitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "S1502752.Assignments",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Title = c.String(),
                        Details = c.String(),
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
                        Feedback = c.String(),
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
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
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
                        Name = c.String(),
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
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "S1502752.Halls",
                    c => new
                    {
                        Id = c.Decimal(false, 10, 0, identity: true),
                        Name = c.String(),
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
                        Name = c.String(),
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
                        Name = c.String(),
                        Author = c.String()
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
                        Name = c.String(),
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
                        Semester = c.String(),
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
                        Code = c.String(),
                        Title = c.String()
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
        }
    }
}