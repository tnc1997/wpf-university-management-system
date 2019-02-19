create table "S1502752"."AssignmentFacts"
(
  "ModuleDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_AssignmentFacts" primary key ("ModuleDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_AssignmentFacts_ModuleDimId" on "S1502752"."AssignmentFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_AssignmentFacts_YearDimId" on "S1502752"."AssignmentFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."ModuleDims"
(
  "Id" number(10, 0) not null,
  "Code" nvarchar2(2000) null,
  "Title" nvarchar2(2000) null,
  constraint "PK_ModuleDims" primary key ("Id")
) segment creation immediate
/

create table "S1502752"."LectureFacts"
(
  "ModuleDimId" number(10, 0) not null,
  "RoomDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_LectureFacts" primary key ("ModuleDimId", "RoomDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_LectureFacts_ModuleDimId" on "S1502752"."LectureFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_LectureFacts_RoomDimId" on "S1502752"."LectureFacts" ("RoomDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_LectureFacts_YearDimId" on "S1502752"."LectureFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."RoomDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_RoomDims" primary key ("Id")
) segment creation immediate
/

create table "S1502752"."YearDims"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  constraint "PK_YearDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_YearDims"
/

create or replace trigger "S1502752"."TR_YearDims"
  before insert on "S1502752"."YearDims"
  for each row
begin
  select "S1502752"."SQ_YearDims".nextval into :new."Id" from dual;
end;
/

create table "S1502752"."BookFacts"
(
  "LibraryDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_BookFacts" primary key ("LibraryDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_BookFacts_LibraryDimId" on "S1502752"."BookFacts" ("LibraryDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_BookFacts_YearDimId" on "S1502752"."BookFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."LibraryDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_LibraryDims" primary key ("Id")
) segment creation immediate
/

create table "S1502752"."GraduationFacts"
(
  "CourseDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_GraduationFacts" primary key ("CourseDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_GraduationFacts_CourseDimId" on "S1502752"."GraduationFacts" ("CourseDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_GraduationFacts_YearDimId" on "S1502752"."GraduationFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."CourseDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CourseDims" primary key ("Id")
) segment creation immediate
/

create table "S1502752"."ModuleFacts"
(
  "CourseDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_ModuleFacts" primary key ("CourseDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_ModuleFacts_CourseDimId" on "S1502752"."ModuleFacts" ("CourseDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_ModuleFacts_YearDimId" on "S1502752"."ModuleFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."HallFacts"
(
  "CampusDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_HallFacts" primary key ("CampusDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_HallFacts_CampusDimId" on "S1502752"."HallFacts" ("CampusDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_HallFacts_YearDimId" on "S1502752"."HallFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."CampusDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CampusDims" primary key ("Id")
) segment creation immediate
/

create table "S1502752"."LibraryFacts"
(
  "CampusDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_LibraryFacts" primary key ("CampusDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_LibraryFacts_CampusDimId" on "S1502752"."LibraryFacts" ("CampusDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_LibraryFacts_YearDimId" on "S1502752"."LibraryFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."RoomFacts"
(
  "CampusDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_RoomFacts" primary key ("CampusDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_RoomFacts_CampusDimId" on "S1502752"."RoomFacts" ("CampusDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_RoomFacts_YearDimId" on "S1502752"."RoomFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."RentalFacts"
(
  "UserDimId" number(10, 0) not null,
  "BookDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_RentalFacts" primary key ("UserDimId", "BookDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_RentalFacts_BookDimId" on "S1502752"."RentalFacts" ("BookDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_RentalFacts_UserDimId" on "S1502752"."RentalFacts" ("UserDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_RentalFacts_YearDimId" on "S1502752"."RentalFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."BookDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "Author" nvarchar2(2000) null,
  constraint "PK_BookDims" primary key ("Id")
) segment creation immediate
/

create table "S1502752"."UserDims"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  constraint "PK_UserDims" primary key ("Id")
) segment creation immediate
/

create table "S1502752"."StudentFacts"
(
  "ModuleDimId" number(10, 0) not null,
  "ClassificationDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_StudentFacts" primary key ("ModuleDimId", "ClassificationDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_StudentFacts_Clas_203880886" on "S1502752"."StudentFacts" ("ClassificationDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_StudentFacts_ModuleDimId" on "S1502752"."StudentFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_StudentFacts_YearDimId" on "S1502752"."StudentFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."ClassificationDims"
(
  "Id" number(10, 0) not null,
  "Classification" nvarchar2(2000) null,
  constraint "PK_ClassificationDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_ClassificationDims"
/

create or replace trigger "S1502752"."TR_ClassificationDims"
  before insert on "S1502752"."ClassificationDims"
  for each row
begin
  select "S1502752"."SQ_ClassificationDims".nextval into :new."Id" from dual;
end;
/

create table "S1502752"."Assignments"
(
  "Id" number(10, 0) not null,
  "Title" nvarchar2(2000) null,
  "Details" nvarchar2(2000) null,
  "Deadline" date not null,
  "RunId" number(10, 0) not null,
  constraint "PK_Assignments" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Assignments"
/

create or replace trigger "S1502752"."TR_Assignments"
  before insert on "S1502752"."Assignments"
  for each row
begin
  select "S1502752"."SQ_Assignments".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Assignments_RunId" on "S1502752"."Assignments" ("RunId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Results"
(
  "Id" number(10, 0) not null,
  "Grade" number(10, 0) not null,
  "Feedback" nvarchar2(2000) null,
  "UserId" number(10, 0) not null,
  "AssignmentId" number(10, 0) not null,
  constraint "PK_Results" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Results"
/

create or replace trigger "S1502752"."TR_Results"
  before insert on "S1502752"."Results"
  for each row
begin
  select "S1502752"."SQ_Results".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Results_AssignmentId" on "S1502752"."Results" ("AssignmentId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Results_UserId" on "S1502752"."Results" ("UserId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Users"
(
  "Id" number(10, 0) not null,
  "UserName" nvarchar2(2000) null,
  "PasswordHash" nvarchar2(2000) null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  "CourseId" number(10, 0) not null,
  constraint "PK_Users" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Users"
/

create or replace trigger "S1502752"."TR_Users"
  before insert on "S1502752"."Users"
  for each row
begin
  select "S1502752"."SQ_Users".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Users_CourseId" on "S1502752"."Users" ("CourseId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Courses"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "CampusId" number(10, 0) not null,
  constraint "PK_Courses" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Courses"
/

create or replace trigger "S1502752"."TR_Courses"
  before insert on "S1502752"."Courses"
  for each row
begin
  select "S1502752"."SQ_Courses".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Courses_CampusId" on "S1502752"."Courses" ("CampusId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Campus"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_Campus" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Campus"
/

create or replace trigger "S1502752"."TR_Campus"
  before insert on "S1502752"."Campus"
  for each row
begin
  select "S1502752"."SQ_Campus".nextval into :new."Id" from dual;
end;
/

create table "S1502752"."Halls"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "CampusId" number(10, 0) not null,
  constraint "PK_Halls" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Halls"
/

create or replace trigger "S1502752"."TR_Halls"
  before insert on "S1502752"."Halls"
  for each row
begin
  select "S1502752"."SQ_Halls".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Halls_CampusId" on "S1502752"."Halls" ("CampusId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Libraries"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "CampusId" number(10, 0) not null,
  constraint "PK_Libraries" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Libraries"
/

create or replace trigger "S1502752"."TR_Libraries"
  before insert on "S1502752"."Libraries"
  for each row
begin
  select "S1502752"."SQ_Libraries".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Libraries_CampusId" on "S1502752"."Libraries" ("CampusId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."LibraryBooks"
(
  "LibraryId" number(10, 0) not null,
  "BookId" number(10, 0) not null,
  constraint "PK_LibraryBooks" primary key ("LibraryId", "BookId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_LibraryBooks_BookId" on "S1502752"."LibraryBooks" ("BookId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_LibraryBooks_LibraryId" on "S1502752"."LibraryBooks" ("LibraryId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Books"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "Author" nvarchar2(2000) null,
  constraint "PK_Books" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Books"
/

create or replace trigger "S1502752"."TR_Books"
  before insert on "S1502752"."Books"
  for each row
begin
  select "S1502752"."SQ_Books".nextval into :new."Id" from dual;
end;
/

create table "S1502752"."Rentals"
(
  "Id" number(10, 0) not null,
  "CheckoutDate" date not null,
  "ReturnDate" date not null,
  "UserId" number(10, 0) not null,
  "BookId" number(10, 0) not null,
  constraint "PK_Rentals" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Rentals"
/

create or replace trigger "S1502752"."TR_Rentals"
  before insert on "S1502752"."Rentals"
  for each row
begin
  select "S1502752"."SQ_Rentals".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Rentals_BookId" on "S1502752"."Rentals" ("BookId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Rentals_UserId" on "S1502752"."Rentals" ("UserId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Rooms"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "CampusId" number(10, 0) not null,
  constraint "PK_Rooms" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Rooms"
/

create or replace trigger "S1502752"."TR_Rooms"
  before insert on "S1502752"."Rooms"
  for each row
begin
  select "S1502752"."SQ_Rooms".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Rooms_CampusId" on "S1502752"."Rooms" ("CampusId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Lectures"
(
  "Id" number(10, 0) not null,
  "DateTime" date not null,
  "Duration" number(10, 0) not null,
  "RunId" number(10, 0) not null,
  "RoomId" number(10, 0) not null,
  constraint "PK_Lectures" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Lectures"
/

create or replace trigger "S1502752"."TR_Lectures"
  before insert on "S1502752"."Lectures"
  for each row
begin
  select "S1502752"."SQ_Lectures".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Lectures_RoomId" on "S1502752"."Lectures" ("RoomId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Lectures_RunId" on "S1502752"."Lectures" ("RunId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Runs"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  "Semester" nvarchar2(2000) null,
  "ModuleId" number(10, 0) not null,
  constraint "PK_Runs" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Runs"
/

create or replace trigger "S1502752"."TR_Runs"
  before insert on "S1502752"."Runs"
  for each row
begin
  select "S1502752"."SQ_Runs".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Runs_ModuleId" on "S1502752"."Runs" ("ModuleId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Enrolments"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  "UserId" number(10, 0) not null,
  "RunId" number(10, 0) not null,
  constraint "PK_Enrolments" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Enrolments"
/

create or replace trigger "S1502752"."TR_Enrolments"
  before insert on "S1502752"."Enrolments"
  for each row
begin
  select "S1502752"."SQ_Enrolments".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Enrolments_RunId" on "S1502752"."Enrolments" ("RunId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Enrolments_UserId" on "S1502752"."Enrolments" ("UserId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Modules"
(
  "Id" number(10, 0) not null,
  "Code" nvarchar2(2000) null,
  "Title" nvarchar2(2000) null,
  constraint "PK_Modules" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Modules"
/

create or replace trigger "S1502752"."TR_Modules"
  before insert on "S1502752"."Modules"
  for each row
begin
  select "S1502752"."SQ_Modules".nextval into :new."Id" from dual;
end;
/

create table "S1502752"."CourseModules"
(
  "CourseId" number(10, 0) not null,
  "ModuleId" number(10, 0) not null,
  constraint "PK_CourseModules" primary key ("CourseId", "ModuleId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_CourseModules_CourseId" on "S1502752"."CourseModules" ("CourseId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_CourseModules_ModuleId" on "S1502752"."CourseModules" ("ModuleId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Graduations"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  "UserId" number(10, 0) not null,
  "CourseId" number(10, 0) not null,
  constraint "PK_Graduations" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Graduations"
/

create or replace trigger "S1502752"."TR_Graduations"
  before insert on "S1502752"."Graduations"
  for each row
begin
  select "S1502752"."SQ_Graduations".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Graduations_CourseId" on "S1502752"."Graduations" ("CourseId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_Graduations_UserId" on "S1502752"."Graduations" ("UserId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

alter table "S1502752"."AssignmentFacts" add constraint "FK_AssignmentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1502752"."ModuleDims" ("Id") on delete cascade
/

alter table "S1502752"."AssignmentFacts" add constraint "FK_AssignmentFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."LectureFacts" add constraint "FK_LectureFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1502752"."ModuleDims" ("Id") on delete cascade
/

alter table "S1502752"."LectureFacts" add constraint "FK_LectureFacts_RoomDimId" foreign key ("RoomDimId") references "S1502752"."RoomDims" ("Id") on delete cascade
/

alter table "S1502752"."LectureFacts" add constraint "FK_LectureFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."BookFacts" add constraint "FK_BookFacts_LibraryDimId" foreign key ("LibraryDimId") references "S1502752"."LibraryDims" ("Id") on delete cascade
/

alter table "S1502752"."BookFacts" add constraint "FK_BookFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."GraduationFacts" add constraint "FK_GraduationFacts_CourseDimId" foreign key ("CourseDimId") references "S1502752"."CourseDims" ("Id") on delete cascade
/

alter table "S1502752"."GraduationFacts" add constraint "FK_GraduationFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."ModuleFacts" add constraint "FK_ModuleFacts_CourseDimId" foreign key ("CourseDimId") references "S1502752"."CourseDims" ("Id") on delete cascade
/

alter table "S1502752"."ModuleFacts" add constraint "FK_ModuleFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."HallFacts" add constraint "FK_HallFacts_CampusDimId" foreign key ("CampusDimId") references "S1502752"."CampusDims" ("Id") on delete cascade
/

alter table "S1502752"."HallFacts" add constraint "FK_HallFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."LibraryFacts" add constraint "FK_LibraryFacts_CampusDimId" foreign key ("CampusDimId") references "S1502752"."CampusDims" ("Id") on delete cascade
/

alter table "S1502752"."LibraryFacts" add constraint "FK_LibraryFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."RoomFacts" add constraint "FK_RoomFacts_CampusDimId" foreign key ("CampusDimId") references "S1502752"."CampusDims" ("Id") on delete cascade
/

alter table "S1502752"."RoomFacts" add constraint "FK_RoomFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."RentalFacts" add constraint "FK_RentalFacts_BookDimId" foreign key ("BookDimId") references "S1502752"."BookDims" ("Id") on delete cascade
/

alter table "S1502752"."RentalFacts" add constraint "FK_RentalFacts_UserDimId" foreign key ("UserDimId") references "S1502752"."UserDims" ("Id") on delete cascade
/

alter table "S1502752"."RentalFacts" add constraint "FK_RentalFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."StudentFacts" add constraint "FK_StudentFacts_Clas_992188120" foreign key ("ClassificationDimId") references "S1502752"."ClassificationDims" ("Id") on delete cascade
/

alter table "S1502752"."StudentFacts" add constraint "FK_StudentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1502752"."ModuleDims" ("Id") on delete cascade
/

alter table "S1502752"."StudentFacts" add constraint "FK_StudentFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."Assignments" add constraint "FK_Assignments_RunId" foreign key ("RunId") references "S1502752"."Runs" ("Id") on delete cascade
/

alter table "S1502752"."Results" add constraint "FK_Results_AssignmentId" foreign key ("AssignmentId") references "S1502752"."Assignments" ("Id") on delete cascade
/

alter table "S1502752"."Results" add constraint "FK_Results_UserId" foreign key ("UserId") references "S1502752"."Users" ("Id") on delete cascade
/

alter table "S1502752"."Users" add constraint "FK_Users_CourseId" foreign key ("CourseId") references "S1502752"."Courses" ("Id") on delete cascade
/

alter table "S1502752"."Courses" add constraint "FK_Courses_CampusId" foreign key ("CampusId") references "S1502752"."Campus" ("Id") on delete cascade
/

alter table "S1502752"."Halls" add constraint "FK_Halls_CampusId" foreign key ("CampusId") references "S1502752"."Campus" ("Id") on delete cascade
/

alter table "S1502752"."Libraries" add constraint "FK_Libraries_CampusId" foreign key ("CampusId") references "S1502752"."Campus" ("Id") on delete cascade
/

alter table "S1502752"."LibraryBooks" add constraint "FK_LibraryBooks_BookId" foreign key ("BookId") references "S1502752"."Books" ("Id") on delete cascade
/

alter table "S1502752"."LibraryBooks" add constraint "FK_LibraryBooks_LibraryId" foreign key ("LibraryId") references "S1502752"."Libraries" ("Id") on delete cascade
/

alter table "S1502752"."Rentals" add constraint "FK_Rentals_BookId" foreign key ("BookId") references "S1502752"."Books" ("Id") on delete cascade
/

alter table "S1502752"."Rentals" add constraint "FK_Rentals_UserId" foreign key ("UserId") references "S1502752"."Users" ("Id") on delete cascade
/

alter table "S1502752"."Rooms" add constraint "FK_Rooms_CampusId" foreign key ("CampusId") references "S1502752"."Campus" ("Id") on delete cascade
/

alter table "S1502752"."Lectures" add constraint "FK_Lectures_RoomId" foreign key ("RoomId") references "S1502752"."Rooms" ("Id") on delete cascade
/

alter table "S1502752"."Lectures" add constraint "FK_Lectures_RunId" foreign key ("RunId") references "S1502752"."Runs" ("Id") on delete cascade
/

alter table "S1502752"."Runs" add constraint "FK_Runs_ModuleId" foreign key ("ModuleId") references "S1502752"."Modules" ("Id") on delete cascade
/

alter table "S1502752"."Enrolments" add constraint "FK_Enrolments_RunId" foreign key ("RunId") references "S1502752"."Runs" ("Id") on delete cascade
/

alter table "S1502752"."Enrolments" add constraint "FK_Enrolments_UserId" foreign key ("UserId") references "S1502752"."Users" ("Id") on delete cascade
/

alter table "S1502752"."CourseModules" add constraint "FK_CourseModules_CourseId" foreign key ("CourseId") references "S1502752"."Courses" ("Id") on delete cascade
/

alter table "S1502752"."CourseModules" add constraint "FK_CourseModules_ModuleId" foreign key ("ModuleId") references "S1502752"."Modules" ("Id") on delete cascade
/

alter table "S1502752"."Graduations" add constraint "FK_Graduations_CourseId" foreign key ("CourseId") references "S1502752"."Courses" ("Id") on delete cascade
/

alter table "S1502752"."Graduations" add constraint "FK_Graduations_UserId" foreign key ("UserId") references "S1502752"."Users" ("Id") on delete cascade
/

create table "S1502752"."__MigrationHistory"
(
  "MigrationId" nvarchar2(150) not null,
  "ContextKey" nvarchar2(300) not null,
  "Model" blob not null,
  "ProductVersion" nvarchar2(32) not null,
  constraint "PK___MigrationHistory" primary key ("MigrationId", "ContextKey")
) segment creation immediate
/

declare
  model_blob blob;
begin
  dbms_lob.createtemporary(model_blob, true);
  dbms_lob.append(model_blob, to_blob(cast('1F8B0800000000000400ED5DDDAE1BB991BE5F60DF41D065801CD90E82DD0C8E13383EF66490F1D8F07102EC95D096E8731A23B50EA4D6C47EB65CEC23ED2B6CFFB2F9535564B34976B7AC9BF19C264516C98FC52259FCEAFFFEFDBFB77FF9BADF2D7E63C7537AC85E2E9FDF3C5B2E58B6396CD3ECE1E5F29C7FF9FD7F2FFFF2E7FFFC8FDB37DBFDD7C53FDB7C7F28F315BFCC4E2F978F79FEF4C36A75DA3CB27D72BAD9A79BE3E174F892DF6C0EFB55B23DAC5E3C7BF6A7D5F3E72B5614B12CCA5A2C6E3F9EB33CDDB3EA8FE2CFD7876CC39EF273B27B77D8B2DDA9F95EA4DC57A52E7E49F6ECF4946CD8CBE53FB2B41237FFF62EC99207B667597EFFED94B3FDCD5D922737455939FB9A9F968B57BB3429E4BB67BB2FCB459265873CC90BE97FF8C789DDE7C743F670FF547C48769FBE3DB122DF976477624DAB7EE8B2DB36F0D98BB281ABEE874E1DB4E44D2F1AFFA6E8A4FC5B295ED5012F97AF4EA7F4212B5BFC36D9E462DE22F7DFD937E943F1E9C3F1F0C48EF9B78FEC4B5342D1BFE71DBB4BF73F6D978B9539FFFFB0E408E6BE5DA9F5F15F4355958D78B9FC29CBFFF062B9F8E5BCDB259F778CF7F98A2C4890614831AF0F05E87A16F14BF25BFA508D26D6B8E5E223DB55394E8FE9538DB61B9EBA9647AC00E5DBE361FFF1B0138B5033AD3F25C707568A7A30E5BC3F9C8F9B1E62375D090ADDA4512223593481B17C90B8B7AB0EE624F8BB2E77C0BD0B80CD801394CA7D7E38B21F59C68E49CEB61F923C67C74277FC72C82C80B9656D4D85622A34EF72F12EF9FA33CB1EF2C797CB423B14CAF66DFA956DDB4F4DF5852A2C3475F1ABFC7836D6F229CD7721AA41B1A6E1C8FF4469F1649E282D426D85FF996DF2F391E1920B19D68232E8A40633683305CED5775ADFE7E72DD9CF4206585A3083262D9C6BD0AC163A20C67AF6F170D8CF6BF51324FEBE1651C719A6EA047A1EDA8ADA8C02286893B6967546272794AE4D2D305388E51D93124A471776A394D6F3BFEDD80B5BD3CBFFC65C6C8DEB951348D5B94422D969F85BC4CE68F87F2A97C0A215361AD797A6B4B1A506D8EFEA389BEC7C5BB1FF7A38FC8A0BDCA6AEB9DAEA2455D3344DA465E8AB2B7F3C26DB7395804B28E781E4847368D222D9FACAFCB764B7C3A56D532139D5344D422D435FD98C1AC86901C29069D440A4A8E9E76372FC4618F75D06A8338164DDB007F2F4EDD2DA5C31ED9E3029F554E46061908C1F0BE59010A0ECD22119F554DD30D2B3F496B158B6E89511954F4903CDB641B2F5DABA011202C9E4B68D92D37AD56E95AFCBB2DD4C8C289B30B9AE4BDB3E75ADA3945839D8C23AAC6931291D536372269FDB925E4680BA1AA05682DB5144D79F333247A7B81BA1ED3E27606ADB7A0ABD4EC32FDB682E102866F7F114E77245AAEAD2141B6F1C081F9EBAD64CF80E' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('4368264DC3E1397DAA39E79D848A7BC386C309F95D7F5FF5DE20BD67B3A71C085F150F66A007D86D081314DC6F7442113B8E2E93876BC1ABCA9EB2CA76820E7CB987E0CB878EEEBD9D2624F4A297DB3319276027FBA7F3290EB0C5AA2E0ED86DE36065DEA6AE85A339418DEBC9BAFD01E4F16979F43A1554118D1E1BBAD919BC2FAF76C6203B833E077600A5665510C00D72CA2A4C33F89CB593883A69ED72053A2304E5D453F173425AC2BE6715D7D561CAAB8323C091A30E04613ED60887FB0E4A482F8B453B63AEF09E2ABC7B2B45C89D2020AA7B5DECA0B2F90133BFC47281F33F4E0C862798BB3C0E8D027D41AC218815E4BDB4F9D3340DBDF82871255DA0CA771F4A32E803A1E6E96BF73483088AD8A4612202C99A88501E9FBB9BDED7CBDA3CC76FA09DAF46AF3B1C471FF557E7FCF1708CB99332B92F38CC52E892129B264E106BA7EC8541EC6D7A3CE57170F67312AC2667A439285B1569944276429AE03812C339FFF52E399DD22FE9A6EA9B28368C37377D50F64BB367B446C2E74F6AAEB5ECE4241C459139F5A3523ABB9B7B1DD60AC72733EA9CA41FD6F830811C1CC42821FD9CF46A4099D16265EBE02D3732E65A62741AF43605B58361BB19EB049ACEDBFC12D112EAFDA552CD1DCB9374778A5151B2DDA5196FD25DD12B9FD2D2A6EAFBC0ED9CF55EE4082BEB74DEA1AEC8659AF0A841DE2A2A898023B29AA3F71DC33983053B6742B1F2B31C3949174A491FF616AB6AE1254EBED237860D33A4DE32B6FD9C6C7E0D3FB34A337EA8D9D761C2DFDC1227CEF0E9A51FC46013B0CF5116BAB55A73CD20EFA9DAEFE0C9154F1C34AD2AB92E705295ED8AB35FFF50181DFF3A1CB77F4B4E8FE16BBB8C8308D041CB9F32A8CB233C1CD7253C00A7C6FA3BE286DB24F65D58DF64C7C3AE593B018178F2BA56119D48728A269492ECFEC4D0F4BC50134C49221E14BA89561F11514FB6349184CFC8232D57517093CD4A7343C7609A5A1FE0187D89BA3B92D2A9EE753D2A9DAA3CC2E9A9F10C05FC9DDA14C4FF8E27F7456FFDBBFA648772F8AE73AC5BB5A96A452919518E729E80CA4817524BA41492A380CD7AE1BAA0C08EF1CA6A33C06DF1AA05869F5BF1D9396402C3BE8ADAFCEEE34B89BFA75FB72A47769A6D3E83AFE8DBB4DE0FE82B0FAA14E99EC6BF0A90474EC1DC235DA52AFD60709F48401CE133E8054909D2CB33FE3A2167B02C5BCC21C8E75C05D0101FD92B4E6680136BF586F89D5280312BDD6FA58F0629589961DD024A974E4CC634B094C787F37759E00006861EEE8403B8177C7807FA4360D565989FCF5A0683ECE52325829E78720EB7D5FF9B2F0C22D304C4A9B39FDB55B3CEC7D1CDA8E87ACE00C8CB0D9E231E8FA4EAE9AB1D49557523475255DAC05BB1B2A04BC4FAEB47B6F9F570CECBABDBE1D7B82C3F1F332F45F9B8' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('008BB46E580013F63896413BF88ACBE2CC1691433ACF757EA97389D3E3E28C6C8B1D3BF40CC6D9B6AE39FA48FEEC75051E9DD4B7FA8EB165D7893E68A72F11B69DDA1DA886EFCE47C9B3CD91BFDAC1BD073883F2E8225421CE159208BDB48C571F0E41DDEC91BD81DAEFA02B104F1C66F114625DE0C47020E455FD2ED99E9D7216C270077D9343F8EE204B83BD0B9AB644202E6ADE2FEFABD902DDDD9712E057F765AA23992DDE57C6D909F5923675FB79AA13A4356523819819D5678483A94E1BA427781F5FB50554828F6D8C5FE75864B9B19C622AA4E10938782B63EDAD83CB337C4FD3CCB80BC4F585461BEAE987D16A54C40FA3F987F4C368FE717002A7F8F5484D0E138EC95A7E80A3933BE83BEF428B1B85CEB6E93B4F1C9D1803DB564657C85EBE3FB01F0BEC1FE4C17E709815A484CACC714263E74B74890A781A8645447FE09E9E6538E3AD2BFC5153A387032E21556F6BA3D82D1D3669F5636982DE01D15BE426BEC9B60B51F503BFE824ADD75E29CC5EB1069F7779FAB44B37855C2F97CF97EA7C7A9FDDB11DCBD9E2D5A694AF3C4F3C6DAAC733EA9C2A64E92F1C5F513BE194A0A68A84BFD32A2E663A3B96532DD9BD2E46333F266996EB6A21CD36E953B2B3ED2EA5004BCD52F603AF4A4DB9634F2C2B95826DAFD8C840BFA95FF13A95C13275DAED4A00258D55382E1B06054390B60E0662204023064CE503308B33079CC049B6210230C9319A0728C1F0661866E858671D6478D0BF284A930E13E838519CF048F54F0438521D61533D15E3330616B1406CD8C01BA3B27563CFF91DA220D218EE39F2226EE8A808D034F4888D0428594DACE51B8ABE82AEAE642816412709A188A240930E5ED409C62355854124D53F31166EA2176CAA37C4E28A01472DFE1336E278302897D126CA05501443ED3AE10F133E02F6B0F198830EC463B06028B108C8D2C14588711145195A043BEA8453C25C85D18BC6EE8A005063AFD8C840C78789815530760A7DF08205525137C37D55251DE12736FE079C03C14D887604048FCFECE0685AB1A988391EA138C7751B173F2E0867B8762391F430A098C2EAB92F8CC63AE60448BA091140498FD31C800985DD412D362A068FB090768115E2189254BCAA4E2C1E972C90F188774E0CB311EF03AB159A0C3D12F1804789CC613848C1227568473CBDEF67E8184EB1B13EE494076E43BC631E788CE6074AD3924D861BF20AC839AED484FC91A138C3351A085984E1848A5F245F11F64520152E6E16FA106F400404E2E3320F4DA845A532C284D08183E03747ED87091F137833D47B5A10580C1C78445817F39F28774EA0C3848F003A6C3CE600BA56642B9F1C28F3743C20C6F7C9A1FA27020EA98E980316A1385ED8A09341BDE4CBE6784824E3010A06014F0E8443A27322C090E8059BDAA9D098315008C5F8' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('C2069C0CF8D50D388FDF18058564C8C78828243A27020A895EB0A99D0AE71A6507C2C536EF41B4ACE02EA4C7709365CFC928C4C58FB11741C7650E8BB1213A150618DB5055C2198A1EAF2ECE3D8A655CBB4E5231D262A05B15ABDE8B805DBBCEB13ACCB18A171903D170B0400C1E86C8818EA830953FAF3731641B22A0941C239BFAC77F13030586B4810CB1D27B00E41CD77A42FEC8509CE16AAFC705C32D42344898686C5641EA7A199A68683FE801CBF4E08736208AA5898C894DDD7214BA11BD72785809D46243624CA8F771511D71F49835AA8F6D500F1CB53762D88660BBAD6C414EA339DA054B4BAD890D2A18F440BE56E97BA5A205DA888A57E7CB1445EC08C002FA7E06A852A2226048C0422468BE320E7E323344182C790490C1E330039CE9DCEF182A082278F96624E2B508129A41433F2496C75B11B05B22A00EED029BBAE1E81E510FA2D7402809F594586152578F9EFB1F3B2B3103226277C061B32474B45366A9EFE7822920E6B2060199D7C903A6E4D0A8F21DDD6431250A1D0F5362DFDBD4DA529E8D698649F1770C66131C8CC77149A24BC717BCE9618E903F9E7D068D8D4DED54DCAC589EA3A6AD0018CB41F617EDEB2B3AC31D0020760CD5A6F7FD0C6C7F29EA01AA77C010089AFF9B03719B12E88386EAF8C882A48EA1B980FEB7A9B68D9C318EBE52620AA04A060B302080A1E4258FC3C2864433B0BA2AF0C5BF0677480C1506B7DE0A6A3553FD28489309ECB1A145D8ECBB81EDE219F4D06348188A78D8758218287504808163301F7891DB4A2C3C813780CD6B7F09CB1D1563B3DA654A6165A8E5498F3133D642A9C7A27230099D9748B51F22AD8F6AA3A7AEBDA01804D8A0920109D4CBE7365A80BD2AA3621918EFB6C7D76884F811B0478C8DD5369313FE8F8F4230D008021335E8846714AA915E54E7C889A350163F360AE5B1B1A91D8BFD120985628C1D0C1E60C09DA8B08065B1DB5A788D97207542047001CD9D01A8F4F826D87012C14E201E32370EB2192EACA8F01130878EC90C1655357E8D0538B0ADE960D4CD6B738A081E176FB3DA9E3693A394C144935C67C24DB6A8B4C88D3096C8F4CA7F2CF74334E34C6EF10CD458350F6A4773FA3D749B097B081DF1153417057CFE6CF744C1F9E9B3DA0F11A005B579623AEB4D156CADF84D5EFC821DDB37084FE508D42F043F9789ECABFE02A5FCE13DCBB5670BF583D4C51B1EC60D0977A22D907281FC2D185496F008CF508C44A4A217249190188A6A62E440C5F0A84786229A77455011FC2197A1882E00895E4617CBC1D42B3C8805D82942641243416A2C00BD309522D8502067EB86CA1248D2ADD083C924F2671B0AEA7869F5623A522753A35A0635B0511D699DDDA8A15816C91D2DB08C95D311A4990A611D2507500CEB180E2C308DF40E678C3114D110444045' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('70BA0F4311D2837ABD18E91DA769C0D557D6E0C0EB2FED0DC58A9E019482B518B9DA708046AD5E872DBA1BEB6BCB398E4F70CBF90497D0B857594C6B6C4A5BCEC314AC9FBB11DACDE5FAE5005A4CEDEB68317BB0A9633987F1F96BA549302D62BB3A132BB3B9FE2AF6B75E7D79CC67F829BFF4840A10EE9DADD61A7C9DB19C0F7831F2A1BDF58A4CAFC65A4182850858615A64BE85905FB5CAE8307EC0692DF01BBE5FE10D946D42CD38B629B3DD7808656AED52373572BF58F4191CEC15E82F8BA8B052BBE8B8B0429B64A397E8293A12AC55CF3B7410187814E81F738052A931648852A12D9D1D4FF40C1959D4B2AB1DBA068B8309F48E55C84CA94DA6A09942B3BA8D0AD147A658976167191493119A64C6D88DF28CA0A2378AE32EEEA0A81946055D14CA13DA30B86BB4F88040B7D03104A526A051046DC4A74B023A02439E433FE021EB800EB18C6F079C9602BF81BA48DCD9127D640E4C2794A9B56B709F81A1D3D0B55EC9675A92E5ECF80A6F46121956CDAAD387F50D31B34CD1BEB07610B3CBA157E2CC3024B014D02B3621A8906B3253EF1826814DA981F51010E508D240A66048B29E20C221891340387AA2B40E11C548284D90DFD7025ECFE1EE0C0C5DC1958CC62557CE4FACE11666321990C7AAB707761031B38C6162D0A61073CAA96BE2CC26201E09B277B0460C11B744D937983B848854120A285A780CAA3FCC10418368B8F7451C6468111B807EA0A33A48D2A3711D6C14225D52D87E008308103B48CBFD35196EC075EF18797F0D71DA23BB23351BBDAD5172637B2463BF509CF5E2FC13E51FDC2B10C73AD02B462A76EDC6DFA257BA8B1BA257280EF560BD02707E438A55CF4528442D33A85CF166984A0B6CC8D224D4904DDB83B65A3648ED88ABC52515B873A32C5E3BBE69A102B9AD833B13E63F06FAD08228596A194D956CD9208B12431F13435CBC86EE31CF408AB47768D744B27F356E58502B9104B28A1AC12864259DD4DC1893FA08238D054F82FD6DAD395529BAAB86C94C812DB04667AA19EDCC6627ADD1906A6752BE0CDE96DD04B17541F213CD3855E94F140BD76CDDAA842716BDE6BE23269A4CB13F42FB56A2E1C22DBF79FF1BA7FD3AE72062BB12C4849AB50953132A76ABD968851905F52305B03467EBAC26C243CD3280270FB0A064A63CCD10B331C2646E3C53E7B937B7F6AF419BABBF68806495DE33B835577AB9A058F31E67BA441F864F779C650C9AAB20CF9825508DE5A1C0071489E3510FA1FE50BA2BED5886507C8D478FE15C2792C617999670170A808909F27390B998F453062B6709997DC9D46F2E63AC700041E34CD104C9438510058972571E54D47023FC3EC1AC3A999B06683F415E23490ED3D708728B2E60440FC08435863E1CD4704CD153BC2A88C898BAEFDDF6D04A5F62F340500FB37D68' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('70D5F83EFAE25DA3E9B0D016CE2E0A32D104EA9C40F051002E04302385B60FE16E87469F04988322C8C606623E30750B449080B742A14818DE2D0A29827628E2CF01A17E8A8F7A1E002FF5012701F9ADBE595AB48870CA507F234EFA1598E705FE941CF426B0F524883223D467CB745718D606EC6DF3B06E08BD3C48AF69516D00BDB60566ADF2DED63C667819019B2CBDF2446E64E057A0DAF589F60ED4242E5E0278F3021E0F124D2E5F8B963FE76F0F79DAEDEA7EF3C8F649F3E1765564D9B0A7FC9CEC0AC5C376A736E15DF2F494660FA7EE97CD97C5FD53B22987E9F7F7CBC5D7FD2E3BBD5C3EE6F9D30FABD5A92AFA74B34F37C7C3E9F025BFD91CF6AB647B58BD78F6EC4FABE7CF57FBBA8CD546EA51F5A524AF293F1C9307A6A49608D9B2B7E9F194DF2579F2392995D7EBED5ECBD6E7A5655B25FCE0521FBBD6F5BFFD5DF9FF0DACB2F4B762C48BF4774956485F9672FFED94B3FD4D29EE4D23C8497DB3A9D4D175F8DBA20FCA5C557730705F0017501471BF4976C9B17D05ABBE3B28DFC1BE3EECCEFB0C4850018B97270474134B23E2BCE1651593BF3C7417CB693EE965DCAE941E528769A58D933281D4E1B70287700F130417E83594052488DF623DAE0E5BDFF12ADFAACBC3A5BF5EA74AF894E63BA588E6D36446DCE0C3E161CCC5A7D2FD479DFC752C2DD03CEA504B133E5F350A822FFE682608B6DAF7F3FD7185FE328C2E29FF2BFFBEFE329971E217CD41C609B95FB71827F49761C6A9AC4E9F98131A27EA2D928781E24C10FD470AFF29D6D9DD1B2775D0E494AB72C5166FE1315998B5BB63F47058BA891F7FA75AD6FC44CCC3A029CC29FD07CE54003163EA4753EA284A09D7D98C80437873160417E87B3B0B4810BFFD4EA7B2F8B62EE05ED9710A533FBE4EDF2080A01EDF798003278DEA0F06FCA76877B7CF8C342888095728609ABC7BA5154693636FD36C3439FEDBEF54934B6F16439AD1AE4760D4AFAF3338D8B155404070AA3CB783AB2B1462428151AFD67C808157E00207E2C758A737AFE2D401143EDB0F60F3EE502D4BF87C0516719417CE46680930DD0EF226691F6025BC3AE78F07E5D8B6FD3699D1E6EF55838C76CB55DA7FB4D15F8619EDCAB7411F72E1B37D593F275051DDD7C98CBDE1EDAA87F1174966FB6380FC35D6FBBE2F59B587B59AB90265B8AE2ED81E547FD61C662FAAB1113BEC49CD6584D14672C514DC2634B2F4030EAFDE5B833CB7620D621F2F1BAC8C3B962769F9844D2C857FEC534EB2DDA519530B6ABFF6F039A9C3584AFE267064CB1177469803A9975D514528EEB223827F18067CE55D9932DACDA71E361163DBCFC9E657C524E25FED4B6A2380A8DBBA7E6DEAA6B05A969C32192062AEDB9E0C6B47AB3A1604CBBA7433B8FB6A5FD28762C5FBD7E1B8FD5B727A944B9353E662EED3375DF0' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('35D7A4808DB34F78BB0F76BE0C9ECFF9407DCE099F7E4E6BB8DB07D0016F8D9CAF8CA637DE235EF406BCE475BCE09DDEF0CC7E3A76040C216F05DD6F04AF431EEA2E18E3BFF137EA10C18CFDC8C3BF460DA7FA4788936DFFFB1EE8B26752A31870F81CC7ADDF808D3D5D6771A1D2B20E053A7DA88258B99C3EC03F0C747EF9C836BF1ECEE56351F5A99A94D2E3D889E5E763A697277E8F7D1E310B9D53B3F88401234052640345F06753D539F331117026191FE64113BECEC134C07E1966C44B55F0295547BDFBDAA3A4F311B87EE9BE86393347CB28660DF4D073521844A85A7CE81A9D17CB46D540BF0A833BFB177A5809F745EB8B962BA5745FED4BAA6FBAE1FBEF49E145A0EC0A829A2EE8657FEC10BF9D2A82FC983533B8E16B499D82800626DEB2400CF6C34036F6F7400321939705BC6E701E74FAE7FE6E7A66AFEB4506AE200329C402EE3F8CD48F2F5BDD4FECD251E3D152B3F0DA9B2FFC6FCEA3D5705849E45A55EB4BAAACAAD5A7864F4B25B5AAB32C174517FD966E4B42ABF7C764B3633735F4B665BE579B0D3B95FE6569691BF0AC458EF44B61A97D3AFCCAB297CBE7CF6F5E2C17AF766972AAB9CDFA1377B1ED7E753A6DA5431B61A6684E11BA9BE4EDDFD937756CDAD1FFC8BE400E931A679A9E1FF54CBC5DA9F5DD82CAAAF9711DC63B3BEF3F97D6ED8723DBA4A78A0AEEF9B3E5A2846A915AFCDF2FE7DD2EF95CFEF125D99DF480E1B83B65980A1A874A1F858B13851C648463CA6E7C5D062A64F795464A53F66FC971F3981C8B99F22EF9FA33CB1EF2C797CB02FF52B1F9F16C2CB5B15B86156B3D1C28F953980947F039CD6E7A0A6DB9CE7F6BC081AC50739CFDF5E96BA4690A72344DA2D72AEBF34756583749CEB61F923C67C7AC2C81556D70027D6448C2B44A76BD4BD328F9D569725D579D63BFC821344993984053563B144D915DE791C4267EA78754D57576580F32423C749D1C563B99EBC4B8D8890193FA580E2F45FCE07978C5AAAEC36BAFF7609A9EABDEB3B3A6AE33E36267064C80731DDE4B195E0613DAD80D30C16103E426586AFC8241102BCC48092DB962ADD7D9CA7589454B6D5DBE232DDD2013CD1C474378DDEA7B48BAD7AE910605A58609730563C5F132BBCB18B055573D6DBF19A2F96126A1237C5F35A8F43391E63B46DF72917DECE5365B2F96F3C6F82FB8E591A94BDE56CF71FADE0CD73EA6918D7A9D93E52211D570BF04B22B38238C6F60B5DE6C61E4965963A2024FE761B948D875642FBE912113BFF82E7D0696327663111DCA10EBCA458239D0A8F19784239CE35F47CDAF95AA139E5CFB74EA3301242DB90EDB4C864D27B0E8E582D6E3407E80F359D8F3F5E85DEFDAE7D7E9C2A21F5E43BC1F17395A32B1C8907308815164403161B7AEA3CC7B9DB8E322917459CB24C4BE7191C3D6517C0C98B5' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('1DBB479879EBF1901328BCA10389AB14548A8D8B0497BF07167AD91DC3876F9DD3BD028F0A098439E30A8C49991063DCB740340917098B4B78E58A335BF471D6B7DC61638415B68EFAE1E6C9484A1423A4B8C8E9325F2D1AE7D2E5D5E974D8A4151A54EFA0B54C00A11EE9BFC9B68B8F879DF88B56D49295E246F8FAEEBCCBD3A75DBA290428A4D6485ADE67776CC772B678B5C9AB86BD4E4E1B20A448D9882D26854257218AA226C9F2FC4EABA6403B3B96804B76AF0FD9293F26A94E45F2E198669BF429D969BDA0E4B49C4665F378996ACA1D7B62593907E0C6DAD4483BA6AD780D4A8F9BFAE2762540884696406EB0C67827A6862A9190419443FA3E7F3CA1BC13930553435CB01624C73554CB72208E20FF76E13802191EA681228A7E2406861AD751EB85AEA57D1007907FFB2E163990F8220C981C963822B2659C058E131BAC5B120B1C4C020B82A41084CF5120C5E9364429BA8F41608431408441124C2882D46560108901A356DE354C3333257D34067822EAA05EC8195BFB705E81B5CC1382ABA08E6A421C3EE16B140C29AC26A2286A52103C21841B61104551B82035D2D4143190D5516BAC317692A9814A6003D1B78F9702268CF2640E409AFEDA36168422AE6F3D0134F60A272BCF194068ECA52D22941C16B6B1E1C4092BD62DB510612A71761A6955EBBE46C113A7401285E83E8659D1605E9E302882399E90BA686E93881BFEDA3242F88BA68621912F083878B81424A1B448B300D3F497B6F160147151EB0BA2B157B496296A36CA88535BA9373397A28660EE2EA4AEF1751007D0F415D018D089A87A7A01676CBDD39A6D3380CD18267444D8F432A0C7864D7BFF6A75873F3E74C6BBC38F69F2F4BCC31F1B430DA3DDBA6351C421D4B2DFA9975511172D2EA5BC6C099F830008E4FD0B03208CCE12A98D62A48C819F8683CF0A3F2D5F9F3874FCDB45E307642A9C047E28FED3281633177706C6CF58F0896937F783CFD8CB9746F4B716F82789E3688D1F50DAC5EBA951E02552678AF248DFC3ECE969BEC4305043994291EAECA83E63A04E907C369ED8E3812BAA27765F508DEF892D8269FA4BE078308AB808F605D1D8AB60CD9629F861A30012B2C0CECFD12CA98ADF53B6A2EA4F41C083754D18FC40ECA5484D32D5E588F7F88D6B9AE90A1FB8EE88049986CE50F78A0B7ACF11032E1051235253475632DA41F51A64289C0E4E2AAA3FF5747AF618D1090CA78990E6CA77EA2069B90581ABF7D94305E44D9C265ACAD3CBB54018489F3D6B07CF71C1A289207D0F76EE1C1132D6D5C1B48B518F0CD700D9E134E0D230FBE92784330709C45838617C004CEEF25584760F71A1F8D03B62747CB4D41F639A28E2DA637A656A63275CDCE2D3C78E88BCFE5024C1B1FCBCA66EE256A4A0AA73D7EC8D5B9DEA14A967EC7D50ED07B206A8' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('597B0E51586F1CC8132720934644171C6B0A8DF1B4C83913CE6C09FA957326A3A4FC3B325F86E571B12FA8A8DCA56190D2F354B821661C052B9CBA73ADF3BA4E01291DB5A858BFF075CE38417853270D93C96E7FC6414AAC4D503FA88CBA0F2A979F66AD9CE2DA33828112479BF4B24F46D42522CDEC1A0C26E6703917F472B0A1C4D5A56813027256C4BB2884887F91FA08A6DFE80802F98A552F29C045EA3B40508F118D8D208CFE3912821AEC146AD0C49F3B1E722C96C8D9E1C476291C191E1D6BC6D4172881351CA63199FDE284F1A223B58DBC3409C899EC4E692CCCC4DA2BF544CCA89BA51AAE15564C8480E329192BB0CE4EB158C371649552CAB9AE5D3FE93770E35D3CC775BA8D77F16CED6E1B5187BCA9024614BFC98B5FB023C7E8965541CCEF923CF99C00164BF9AB7B966BFEC1B56BFD1B1E8602E1ADBEDF3CB27D52243EFFE3B317FFF5C717C570D7512D54966E7588D59A85072A5AA5421A5A1FCF63AE4A7A01AE5526A5A2D5498FE04D1572F27AAD329E8256D4E43057C21F666895F014B4922687B9928E2C58ABA54B42ABE968B68D4324F06AEB232424E203C433996B53D9FDB41AD50C68AD2A97AFA966816855AB544843EBE3796C2718D24031D130C5EC1AD6717468757549684D1DC39FB1033B0A24BD03BB34BC03DB3CD698C4D486986A42A5BDDA406AEB9248C561590FEB1E14EB350989785DAC7B8E6FA342E0F1E229A402B11A2BFECE5FAB84A7A0953439CC95488FD0B48AA454B432E9FDB011ECFA4B611DF47A1E1CFC6A5EB308E25D3C611C58190636C8ACED450095750281C8DA30B6010A821203446C953BAAD98D6ADD56FBA1AACFA8F7ACD438A2C20DEADB5A9FE2BAD4A847538B2E921C17B19AEA5493D6AE9F0CD8E83744B919349BADA646B5B45143DBAD39C87A63586BACED6EDCE636DBDB160D288FC375F9CBAFB8F8E579BFA960C165402B5E48432BE1796C4D35D44C339A68B6AA09AD474E36A829DB3AC58344C2C2B6B2AEF5DA846D31B0A9D482462D84FCEA2E938E30055C06092B7151B7F455DBF943DE6EA2055115A026A9A72E72632D3A020EE607748245D43F6F1D00ECC3AB5F4BDF07371D0C3D07B4DC1CA24E3EDD92F7F495E0FCDBE88DC662A501EDB60AAB2635413969A8C4E7DFA6027828B817847763103079F4B473897AF084CF4407A8A727D56FBB8F831BAD85A2021A4C87ABF232CEA19B89874E02DA6B196709B858519B2E7C251A0F9F255505A849833B028CF483AE6C5444206FCDD74F998405C17FB309A09BA2D778817A8CE62271548026DB445CF1D2EC982087E27E40F3DC141E4486B87A6C5843BCFB4A345E3DDAAC7EDA7DF4B57429CCF0F8DA4551C87B6B3470F829AE7C019A4EE0DC187BC10BC8E3341908028018A751C6593D73E676ADEFE612C34BD3DA7B19DBD0CDD428D681' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('66D234EC5E9A195A558194E0C41EC3726FE53C63A3ECAD200E6BC4D026A98A359B596D32FF460159BBBBA9A12C7C1EDC6088741968B0919B59F34C511BCCBF8DDC6080251852537AAE008A2A42730DACB690B1D58307575E9AB01BAC7A89D25389AE01AEDFAA52A4EF833B07265F05FAC482A5D5DBC959FCA613F3C0C828EA6522C469B24E6D094E7C92FF1239F342CEBB0CB35FBCFF6C667EFDC9D3BE8AF330A25B2A98A9113038016B936C9C7C3D2A9C3178B2BF5AC60CC4F40209353C344BBC32E5F696BFBD11D12A8A0CCF43C394FB5A712FE4C9AA92B9D9109B8A2070D32C2ACD9CB269A0F643E9BB27E3A2E61343AD0A806E6C60E3E4AB63C188F0D7A4DA69026D12E49FABB92A2BD6E0684D82589BF02987933BB9CEA0318029B00C21BBF250AA45F43AE05B717FD79E352D0E7EDB09D0E6F4170FDA8942BB501F23A530B940A34591BDC88DEB1C26EAB6957F5BDDE2595A340E0D94E94780E611FC24831AA7397954BF12BE7A6C1AA62E29528D811A337CF32496070497300BC4A0710B3BDF206A02F4AA91603070337F815FC98E3BC26FDB04BF4D6E4B3534197E2F0C3C9DD6F6BB9368B2F8F81BBD4F04DE867B68A205DC075D1C12A035BC69F60059DDEF4BB928F4DB544CAD924F7007EAD5184D949E84A253117A32EA610CADBAC4F168993F6244CE94E1478E83F70EC34F56CAD78FE5AFF9A33B9E76BBAA7D189B0FC59FF9E1983C94BA8AED4ED5D7DB5531C9F374CFEABFEE58693EF1226E8B3233563DBEEC0A6DF3FC947D39B46F0D1589DA2C6D72ABDA589E6C933C7975CCD32FC9262F9237AC30D8B287E5E29FC9EE5C9A06FBCF6CFB53F6FE9C3F9DF3A2C96CFF7927ED4ACA378B54FDB72B4DE6DBF74FE55F271F4D28C44C8B26B0F7D95FCFE96ECBE57E9BEC54EC6245948F217F64C5F77A2CF3E25FF6F08D97F4CB21B32CA8E93EFE86F313DB3FED8AC24EEFB3FBE43786CB66EE43B9C76EEFD2E4E198EC4F4D19DDEF8B3F0BF86DF75FFFFCFFFDE728A0BA450200' as long raw)));
  insert into "S1502752"."__MigrationHistory"("MigrationId", "ContextKey", "Model", "ProductVersion")
  values ('201902181105592_InitialCommit', 'UniversityManagementSystem.Data.Migrations.Configuration', model_blob, '6.0.0-20911');
end;
