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

create sequence "S1502752"."SQ_ModuleDims"
/

create or replace trigger "S1502752"."TR_ModuleDims"
  before insert on "S1502752"."ModuleDims"
  for each row
begin
  select "S1502752"."SQ_ModuleDims".nextval into :new."Id" from dual;
end;
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

create sequence "S1502752"."SQ_RoomDims"
/

create or replace trigger "S1502752"."TR_RoomDims"
  before insert on "S1502752"."RoomDims"
  for each row
begin
  select "S1502752"."SQ_RoomDims".nextval into :new."Id" from dual;
end;
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

create sequence "S1502752"."SQ_LibraryDims"
/

create or replace trigger "S1502752"."TR_LibraryDims"
  before insert on "S1502752"."LibraryDims"
  for each row
begin
  select "S1502752"."SQ_LibraryDims".nextval into :new."Id" from dual;
end;
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

create sequence "S1502752"."SQ_CourseDims"
/

create or replace trigger "S1502752"."TR_CourseDims"
  before insert on "S1502752"."CourseDims"
  for each row
begin
  select "S1502752"."SQ_CourseDims".nextval into :new."Id" from dual;
end;
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

create sequence "S1502752"."SQ_CampusDims"
/

create or replace trigger "S1502752"."TR_CampusDims"
  before insert on "S1502752"."CampusDims"
  for each row
begin
  select "S1502752"."SQ_CampusDims".nextval into :new."Id" from dual;
end;
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

create sequence "S1502752"."SQ_BookDims"
/

create or replace trigger "S1502752"."TR_BookDims"
  before insert on "S1502752"."BookDims"
  for each row
begin
  select "S1502752"."SQ_BookDims".nextval into :new."Id" from dual;
end;
/

create table "S1502752"."UserDims"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  constraint "PK_UserDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_UserDims"
/

create or replace trigger "S1502752"."TR_UserDims"
  before insert on "S1502752"."UserDims"
  for each row
begin
  select "S1502752"."SQ_UserDims".nextval into :new."Id" from dual;
end;
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
  dbms_lob.append(model_blob, to_blob(cast('1F8B0800000000000400ED5DDDAE1BB991BE5F60DF41D065801CD90E82DD0C8E13383EF66490F1D8F07102EC95D096E8731A23B50EA4D6C47EB65CEC23ED2B6CFFB2F9535564B34976B7AC9BF19C264516C98FC52259FCEAFFFEFDBFB77FF9BADF2D7E63C7537AC85E2E9FDF3C5B2E58B6396CD3ECE1E5F29C7FF9FD7F2FFFF2E7FFFC8FDB37DBFDD7C53FDB7C7F28F315BFCC4E2F978F79FEF4C36A75DA3CB27D72BAD9A79BE3E174F892DF6C0EFB55B23DAC5E3C7BF6A7D5F3E72B5614B12CCA5A2C6E3F9EB33CDDB3EA8FE2CFD7876CC39EF273B27B77D8B2DDA9F95EA4DC57A52E7E49F6ECF4946CD8CBE53FB2B41237FFF62EC99207B667597EFFED94B3FDCD5D922737455939FB9A9F968B57BB3429E4BB67BB2FCB459265873CC90BE97FF8C789DDE7C743F670FF547C48769FBE3DB122DF976477624DAB7EE8B2DB36F0D98BB281ABEE874E1DB4E44D2F1AFFA6E8A4FC5B295ED5012F97AF4EA7F4212B5BFC36D9E462DE22F7DFD937E943F1E9C3F1F0C48EF9B78FEC4B5342D1BFE71DBB4BF73F6D978B9539FFFFB0E408E6BE5DA9F5F15F4355958D78B9FC29CBFFF062B9F8E5BCDB259F778CF7F98A2C4890614831AF0F05E87A16F14BF25BFA508D26D6B8E5E223DB55394E8FE9538DB61B9EBA9647AC00E5DBE361FFF1B0138B5033AD3F25C707568A7A30E5BC3F9C8F9B1E62375D090ADDA4512223593481B17C90B8B7AB0EE624F8BB2E77C0BD0B80CD801394CA7D7E38B21F59C68E49CEB61F923C67C7AC2C8355ED308373CBDADA0AE55468DFE5E25DF2F567963DE48F2F9785862814EEDBF42BDBB69F1A110A755868EBE257F9F16C9C029FD27C17A21A146F1A96FC4F961653E6C9D2A2D456F89FD9263F1F192EB990612D28844E6A3083365BE05C7DA7F67D7EDE92FD2C6480A5053368D2C2B906CD6CA10362AC691F0F87FDBC564041E2EF6B21759C61AA4EA0E7A1ADA8CD28808236696B5967747242E9DAD402338558E23129A1747471374A693DFFDB8EBDC075BDFC6FCC05D7B8663901559D4F249A9D20D0A2F602215036CD97B6B4B1A706D8F1EA389BEC7D5BB1FF7A38FC8A0BDCA6AEB9EAEA2455D3346DA465E8AB2F7F3C26DB7395804B28E781E4847368D222D9FACAFCB764B7C3A56D532139D5344D422D435FD98C1AC86911C29069D440A4A8E9E76372FC4618F85D06A8338164DDB807F2F4EDD2DA6431EDA03029F554E48061908C1F0BE59010A0ECD22119F554DD38D2B3F496B158B6E89511954F49034DB741B2F5DABE011202C9E4D68D92D37AD56E95AFCBB2DD4C8C281B31B9AE4BDB4275ADA3945839D8C23AAC6931291D536372269F5B935E4680BA1AA05682DB7144D79F17688EC6DE91D0B69F1338B5ED3D85602708C8769A0B0C8A197E3CC5B96891AABA34E5C61B07C287A7AE3533BEC3109A49D37278' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('4E9FAACE7937A1E2DEB0E970427ED7DF57DD3758F7D9EC2D074258C58419EC01761DC22405F71D9D50C4CEA3CBE4E19AF0AAB6A7ACB69DA0035FF421F8F2A1A77B6FAB0909BDE8E6F66CC609D8C9FEE97C8A036CB1AA8B0376DB385899B7A96BE1884E50E37AB26E8300797C5A1FBD4E075544A3C7876EB606EFCBABAD31D8D6A0CF841D80A959160478839CB80A530D3E73ED24A24E5DBB5C81CE0B4139F554FCCC9096B0EFB9C5758598F20AE10870E4C80341988F75C2E1EE8312D2CB82D1CE982BBCA70AEFDE4A11722D0888EA5E973CA86C7EC0CC2FB45CE0FC8F1383E109E62E8F45A3405F106B086205792F6DFE344D432F414A5C4997A9F23D88920CFA43A879FADA3DCD2082223669988840B2262294C7E70EA7F755B336CFF1DB68E76BD2EB2E6780DFFAAB73FE7838C6DC4D99DC191C662A7469894D152798B5D3F60261F6363D9EF23858FB3909569333DA1C94AE8A364A313BA14D702689E1B4FF7A979C4EE9977453F54D145BC69BFB3E28FBA5D9355A23E1732835D75A767C128EA4C89CFAB1299DDDCDE50E6B85E3531A754ED20F6E7C98420E4E6394907E4E7D35A05CE082253732E65A627424F43605B50362BB19EB049ACE03FD12D112EA5DA652CD1DCB9374778A5151B2DDA5196FD25DD12B9FD2D2A6EAFBF0ED9CF55EE4082BEB74DEA1EEC9659AF0D041DE322A898073B29AA3F75DC33983053B6742B1F2531D3949174A491FF646AB6AE1254EBED24F860D33A4DE32B6FD9C6C7E0D3FB34A337EA8D9D761C2DFDC1227CEF0E9A51FC86013B0CF9116BAB55A73CD20EFA9DAEFE009164F1C34AD2AB92E705295ED8AB35FFF50181DFF3A1CB77F4B4E8FE16BBB8C8308D059CB9F32A8CB23BC1DD7253C0007C7FA3BE296DB24F65D58DF64C7C3AE593B018178F2BA56119D48728A269492ECFEECD0F4E450134C49221E19BA89561F1151CFB8349184CFC8C32D57517093CD4A7343C7609A5A1FE0287D89BA3B92D2A9EE773D2A9DAA3CC2F9A9F11205FC9EDA14C4178F27F7456FFDBBFA648772FEAE73AC5BB5A96A452919518E729E80CA4817524BA41492A380CD7AE1BAA0C04EF2CA6A33C085F1AA05869F5BF1D9396402C33E8BDAFCEEE35389BFB15FB72A4776A06D3E832FEBDBB4DE8FEA2B4FAA14E99EC6CF0A90474EC1DC245DA52AFD6170DF48401CE133E80D4909D2CB4BFE3A2167B02C5BCC21C8FF5C05D0105FD92B4E6680136BF586F89F5280312BDD6FA59F0629589961DD024A974E4CC634B094C787137859E00056861E6E8503F8187C7809FA4360D56598AFCF5A0683ECE92325821E79720EB7D5FF9B2F0C22D304C4A9B3BFDB55B3CEC7D9CDA8E87ACE00C8D30D9E231E8FA4EAE9AB1D49557523475255DAC05BB1B2A04BC4FAEB47B6F9F570CECBABDBE1D7B82C3F1F332F45F9B8008BB46E580013F63C' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('96413BF88ACBE2CC1691433ACF757EB17389D3E3E28C6C8B1D3BF41CC6D9B6AE79FB485EED75051E9DECB7FA8EB168D7893EE8A82F11B69DDA1DA886EFCE47C9B3CD91D7DAC1BD073883F2E8225421CE159208EDB48C571F0E41DDEC91BD81DAEFA02B104F1C66F114625DE0C47020E955FD2ED99E9D7216C270077D9343F8EE204B83BD0B9AB644202E6ADE2FEFABD902DDDD9712E057F765AA23C12DDE57C6D909F5923675FB79AA130436652381581AD567848FA94E1BA427781F5FB50554828F6D8C5FE75864B9B19C622AA4E10938782B63EDAD83CB337C4FD3CCB80BC4F5854621EAE987D16A54C40FA3F987F4C368FE717002A7B8F6484D0E938FC95A7E80A3933BE83BEF428B1B85CEB6E93B4F1C9D1803DB564657C85EBE3FB01F0BEC1FE4C17E709815A484CACC714263E74B74890A781A8645447FE09E9E653803AE2BFC5153A387032E21556F6BA3D82D1D3669F5636982DE01115DE426BEC9B60B51F503BFE824ADD75E29FC5EB1069F7779FAB44B37855C2F97CF97EA7C7A9FDDB11DCBD9E2D5A694AF3C4F3C6DAAC733EA9C2A64E92F1C5F513BE19480A78A84BFD32A2E663A3B96532DD9BD2E46333F266996EB6A21CD36E953B2B3ED2EA5004BCD52F603AF4A4DB9634F2C2B95826DAFD8C840BFA95FF13A95C13275DAED4A00258D55385E1B060543F0B60E0662804023064CE503308B33079CC049B6210230C9319A0728C190671866E8F8671D647830C0284A930E1FE838519CF048F54F0438521D61533D15FB330616B1E06CD8C01B23B57563CFF91DA220D2180A3AF2226EE8A808D034F4888D0428594DACE51B8AC682AEAE646816412709E189A240930E68D409C6A357854124D53F31166EA2176CAA37C4E78A01472D261436E278802897D126CA05501443ED3AE10F133E02F6B0F198830EC4E3B16028B108CED2C14588771145195A043FEA8453C25E85D18BC6EE8A005063AFD8C840C78A898155308E0A7DF08205555137C37D55251DED2736FE079C03C14D887604048FCFECE0685AB1A9E8391EA138C7751B173F2E0867B8762391F530A098C2ECB92F8CC63AE60448BA091140498FD31C800985DF412D362A168FB090760116E2189254ECAA4E2C1EA32C90F188774E0CB311EF03AB159A0C4112F1804789D0613848C1227668473CBDEF67E8584EB1B13EE494076E43BC631E788CE6074AD3924D861DF20AC839AED484FC91A138C3351A085D84E1848A63245F11F6452015366E16FA106F400404E2E3320F4DA845A732C284D08183E03747ED87091F137833D47B5A40580C1C78745817F39F28774EA0C3848F003A6C3CE600BA56642B9F1C28F3743C20C6F7C9A1FA27020EA98E980316A1585ED8A09381BDE4CBE6784824E3020A06014F0E8443A27322C090E8059BDAA91099315008C5F8C2069C0CF8D50D388F' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('E318058564E8C78828243A27020A895EB0A99D0AEB1A6507C2C536EF41B4ACE02EA4C7709365CFC928C4C58FB11741C7650E8BB1213A150618DB5055C2198A1EAF2ECE3D8A655CBB4E5231D262A05B15ABDE8B805DBBCEB13ACCB18A171903D170B0400C1E86C8818EA830953FAF3731641B22A0941C239BFAC77F13030586B4810CB1D27B00E41CD77A42FEC8509CE16AAFC705C32D42344898686C5641EA7A199A68683FE801CBF4E08736208AA5898C894DDD7214BA11BD72785809D46243624CA8F771511D71F49835AA8F6D500F1CB53762D88660BBAD6C414EA339DA054B4BAD890D2A18F440BE56E97BA5A205DA888A57E7CB1445EC08C002FA7E06A852A2226048C0422468BE320E7E323344182C790490C1E330039CE9DCEF182A082278F96624E2B508129A41433F2496C75B11B05B22A00EED029BBAE1E81E510FA2D7402809F594586152578F9EFB1F3B2B3103226277C061B32474B45366A9EFE7822920E6B2060199D7C903A6E4D0A8F21DDD6431250A1D0F5362DFDBD4DA529E8D698649F1770C66131C8CC77149A24BC717BCE9618E903F9E7D068D8D4DED54DCAC589EA3A6AD0018CB41F617EDEB2B3AC31D0020760CD5A6F7FD0C6C7F29EA01AA77C010089AFF9B03719B12E88386EAF8C882A48EA1B980FEB7A9B68D9C318EBE52620AA04A060B302080A1E4258FC3C2864433B0BA2AF0C5BF0677480C1506B7DE0A6A3553FD28489309ECB1A145D8ECBB81EDE219F4D06348188A78D8758218287504808163301F7891DB4A2C3C813780CD6B7F09CB1D1563B3DA654A6165A8E5498F3133D642A9C7A27230099D9748B51F22AD8F6AA3A7AEBDA01804D8A0920109D4CBE7365A80BD2AA3621918EFB6C7D76884F811B0478C8DD5369313FE8F8F4230D008021335E8846714AA915E54E7C889A350163F360AE5B1B1A91D8BFD120985628C1D0C1E60C09DA8B08065B1DB5A788D97207542047001CD9D01A8F4F826D87012C14E201E32370EB2192EACA8F01130878EC90C1655357E8D0538B0ADE960D4CD6B738A081E176FB3DA9E3693A394C144935C67C24DB6A8B4C88D3096C8F4CA7F2CF74334E34C6EF10CD458350F6A4773FA3D749B097B081DF1153417057CFE6CF744C1F9E9B3DA0F11A005B579623AEB4D156CADF84D5EFC821DDB37084FE508D42F043F9789ECABFE02A5FCE13DCBB5670BF583D4C51B1EC60D0977A22D907281FC2D185496F008CF508C44A4A217249190188A6A62E440C5F0A84786229A77455011FC2197A1882E00895E4617CBC1D42B3C8805D82942641243416A2C00BD309522D8502067EB86CA1248D2ADD083C924F2671B0AEA7869F5623A522753A35A0635B0511D699DDDA8A15816C91D2DB08C95D311A4990A611D2507500CEB180E2C308DF40E678C3114D11044404570BA0F4311D2837ABD' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('18E91DA769C0D557D6E0C0EB2FED0DC58A9E019482B518B9DA708046AD5E872DBA1BEB6BCB398E4F70CBF90497D0B857594C6B6C4A5BCEC314AC9FBB11DACDE5FAE5005A4CEDEB68317BB0A9633987F1F96BA549302D62BB3A132BB3B9FE2AF6B75E7D79CC67F829BFF4840A10EE9DADD61A7C9DB19C0F7831F2A1BDF58A4CAFC65A4182850858615A64BE85905FB5CAE8307EC0692DF01BBE5FE10D946D42CD38B629B3DD7808656AED52373572BF58F4191CEC15E82F8BA8B052BBE8B8B0429B64A397E8293A12AC55CF3B7410187814E81F738052A931648852A12D9D1D4FF40C1959D4B2AB1DBA068B8309F48E55C84CA94DA6A09942B3BA8D0AD147A658976167191493119A64C6D88DF28CA0A2378AE32EEEA0A81946055D14CA13DA30B86BB4F88040B7D03104A526A051046DC4A74B023A02439E433FE021EB800EB18C6F079C9602BF81BA48DCD9127D640E4C2794A9B56B709F81A1D3D0B55EC9675A92E5ECF80A6F46121956CDAAD387F50D31B34CD1BEB07610B3CBA157E2CC3024B014D02B3621A8906B3253EF1826814DA981F51010E508D240A66048B29E20C221891340387AA2B40E11C548284D90DFD7025ECFE1EE0C0C5DC1958CC62557CE4FACE11666321990C7AAB707761031B38C6162D0A61073CAA96BE2CC26201E09B277B0460C11B744D937983B848854120A285A780CAA3FCC10418368B8F7451C6468111B807EA0A33A48D2A3711D6C14225D52D87E008308103B48CBFD35196EC075EF18797F0D71DA23BB23351BBDAD5172637B2463BF509CF5E2FC13E51FDC2B10C73AD02B462A76EDC6DFA257BA8B1BA257280EF560BD02707E438A55CF4528442D33A85CF166984A0B6CC8D224D4904DDB83B65A3648ED88ABC52515B873A32C5E3BBE69A102B9AD833B13E63F06FAD08228596A194D956CD9208B12431F13435CBC86EE31CF408AB47768D744B27F356E58502B9104B28A1AC12864259DD4DC1893FA08238D054F82FD6DAD395529BAAB86C94C812DB04667AA19EDCC6627ADD1906A6752BE0CDE96DD04B17541F213CD3855E94F140BD76CDDAA842716BDE6BE23269A4CB13F42FB56A2E1C22DBF79FF1BA7FD3AE72062BB12C4849AB50953132A76ABD968851905F52305B03467EBAC26C243CD3280270FB0A064A63CCD10B331C2646E3C53E7B937B7F6AF419BABBF68806495DE33B835577AB9A058F31E67BA441F864F779C650C9AAB20CF9825508DE5A1C0071489E3510FA1FE50BA2BED5886507C8D478FE15C2792C617999670170A808909F27390B998F453062B6709997DC9D46F2E63AC700041E34CD104C9438510058972571E54D47023FC3EC1AC3A999B06683F415E23490ED3D708728B2E60440FC08435863E1CD4704CD153BC2A88C898BAEFDDF6D04A5F62F340500FB37D6870D5F83EFAE25DA3E9' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('B0D016CE2E0A32D104EA9C40F051002E04302385B60FE16E87469F04988322C8C606623E30750B449080B742A14818DE2D0A29827628E2CF01A17E8A8F7A1E002FF5012701F9ADBE595AB48870CA507F234EFA1598E705FE941CF426B0F524883223D467CB745718D606EC6DF3B06E08BD3C48AF69516D00BDB60566ADF2DED63C667819019B2CBDF2446E64E057A0DAF589F60ED4242E5E0278F3021E0F124D2E5F8B963FE76F0F79DAEDEA7EF3C8F649F3E1765564D9B0A7FC9CEC0AC5C376A736E15DF2F494660FA7EE97CD97C5FD53B22987E9F7F7CBC5D7FD2E3BBD5C3EE6F9D30FABD5A92AFA74B34F37C7C3E9F025BFD91CF6AB647B58BD78F6EC4FABE7CF57FBBA8CD546EA51F5A524AF293F1C9307A6A49608D9B2B7E9F194DF2579F2392995D7EBED5ECBD6E7A5655B25FCE0521FBBD6F5BFFD5DF9FF0DACB2F4B762C48BF4774956485F9672FFED94B3FD4D29EE4D23C8497DB3A9D4D175F8DBA20FCA5C557730705F0017501471BF4976C9B17D05ABBE3B28DFC1BE3EECCEFB0C4850018B97270474134B23E2BCE1651593BF3C7417CB693EE965DCAE941E528769A58D933281D4E1B70287700F130417E83594052488DF623DAE0E5BDFF12ADFAACBC3A5BF5EA74AF894E63BA588E6D36446DCE0C3E161CCC5A7D2FD479DFC752C2DD03CEA504B133E5F350A822FFE682608B6DAF7F3FD7185FE328C2E29FF2BFFBEFE329971E217CD41C609B95FB71827F49761C6A9AC4E9F98131A27EA2D928781E24C10FD470AFF29D6D9DD1B2775D0E494AB72C5166FE1315998B5BB63F47058BA891F7FA75AD6FC44CCC3A029CC29FD07CE54003163EA4753EA284A09D7D98C80437873160417E87B3B0B4810BFFD4EA7B2F8B62EE05ED9710A533FBE4EDF2080A01EDF798003278DEA0F06FCA76877B7CF8C342888095728609ABC7BA5154693636FD36C3439FEDBEF54934B6F16439AD1AE4760D4AFAF3338D8B155404070AA3CB783AB2B1462428151AFD67C808157E00207E2C758A737AFE2D401143EDB0F60F3EE502D4BF87C0516719417CE46680930DD0EF226691F6025BC3AE78F07E5D8B6FD3699D1E6EF55838C76CB55DA7FB4D15F8619EDCAB7411F72E1B37D593F275051DDD7C98CBDE1EDAA87F1174966FB6380FC35D6FBBE2F59B587B59AB90265B8AE2ED81E547FD61C662FAAB1113BEC49CD6584D14672C514DC2634B2F4030EAFDE5B833CB7620D621F2F1BAC8C3B962769F9844D2C857FEC534EB2DDA519530B6ABFF6F039A9C3584AFE267064CB1177469803A9975D514528EEB223827F18067CE55D9932DACDA71E361163DBCFC9E657C524E25FED4B6A2380A8DBBA7E6DEAA6B05A969C32192062AEDB9E0C6B47AB3A1604CBBA7433B8FB6A5FD28762C5FBD7E1B8FD5B727A944B9353E662EED3375DF035D7A4808DB34F78BB' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('0F76BE0C9ECFF9407DCE099F7E4E6BB8DB07D0016F8D9CAF8CA637DE235EF406BCE475BCE09DDEF0CC7E3A76040C216F05DD6F04AF431EEA2E18E3BFF137EA10C18CFDC8C3BF460DA7FA4788936DFFFB1EE8B26752A31870F81CC7ADDF808D3D5D6771A1D2B20E053A7DA88258B99C3EC03F0C747EF9C836BF1ECEE56351F5A99A94D2E3D889E5E763A697277E8F7D1E310B9D53B3F88401234052640345F06753D539F331117026191FE64113BECEC134C07E1966C44B55F0295547BDFBDAA3A4F311B87EE9BE86393347CB28660DF4D073521844A85A7CE81A9D17CB46D540BF0A833BFB177A5809F745EB8B962BA5745FED4BAA6FBAE1FBEF49E145A0EC0A829A2EE8657FEC10BF9D2A82FC983533B8E16B499D82800626DEB2400CF6C34036F6F7400321939705BC6E701E74FAE7FE6E7A66AFEB4506AE200329C402EE3F8CD48F2F5BDD4FECD251E3D152B3F0DA9B2FFC6FCEA3D5705849E45A55EB4BAAACAAD5A7864F4B25B5AAB32C174517FD966E4B42ABF7C764B3633735F4B665BE579B0D3B95FE6569691BF0AC458EF44B61A97D3AFCCAB297CBE7CF6F5E2C17AF766972AAB9CDFA1377B1ED7E753A6DA5431B61A6684E11BA9BE4EDDFD937756CDAD1FFC8BE400E931A679A9E1FF54CBC5DA9F5DD82CAAAF9711DC63B3BEF3F97D6ED8723DBA4A78A0AEEF9B3E5A2846A915AFCDF2FE7DD2EF95CFEF125D99DF480E1B83B65980A1A874A1F858B13851C648463CA6E7C5D06AA47F7559AF44756CCD4628FBDFD90E4C566252B4B60552B1CFAB7B4629ACA7F4B8E9BC7E4584CA577C9D79F59F6903FBE5C161344EAD9FC783696DA1836C38AB51E2F941D2ACC8C24089F66377F85B65C158435E040DAA88B540FF5F96DA4790CB23C5D64B7D6B66754CCC2C44C76BD4B1331F9557A725D57A564BF0A22444B173981A2EA258A09C9AE7749EE14BFF347AAEA3A7DAC0719E136BACE9EA1B3072321BACE9C0B993930B190E5F052E4139E8757ACEA3ABCF68A11A60ABA2AC6C1C71618A3CF75EA5CC8D481597AAEC37B29C3CB60D61DBB0126887680DC04958E5F300862851929A12557ACF53ABEB9AEC1EE3712ADE37AA4B51DE4D3B9C8E1121EF1FA1EB3EE516FA451431970C25C245951D9CCEE4A096CD555D3DBEFB7681A9C8B54222ACB4EA4F98EB1D45C641F7BB993D78BE5F438FE0B6EE972EA92B7D5ABA3BEF7DBB52B6DE46D814E3D7391886A286EC2A8DE8EF8C637B05AA7BD3072CBE4385181A7D3CD5C24EC3A4E1BDFC890F96D7C973E034B19BB14890E65885CE622C11C68D4F883C911AE0AAEA3E6D74AD5795DAE7D3AF5990072B35C876D26C3A6F374F4F293EB71A43FC0432EEC097DF4AE77EDF3EB7461D14FB7217A938B1C2D993F65C83984409C32A098B05BD751E6BDCE4F729148BAAC65122219B9C861EB984C06CCDA8E' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('C424CCBCF578C80914DEB09EC4550A2A93C84582CBDF2B10BDEC8EC8C4B7CEE91EBB47850442107205C6A44C8831EE5B2036888B84C525BCD5C5093CFABC07B0DC6163BC1CB66F01C2CD93919428C6BB7191D365BE5A34CEA5CBABD3E9B0492B34A8DE416B99E7423DD27F936D171F0F3BF117ADA825F9C68DF0F5DD7997A74FBB7453085048AD71D1BCCFEED88EE56CF16A93570D7B9D9C3640E494B2115B4C0A85954314454D92E5F99D564D8176762C0197EC5E1FB2537E4C529D71E5C331CD36E953B2D37A41C969398DCAE6F132D5943BF6C4B2720EC08DB5A991764C5BF11A941E37F5C5ED4A80108D2C81A2618DD16B4C0D5522AD842887F47DFE7842D933260BA6867E612D488E6BA896AB411C41FEEDC27104F2544C034514894A0C0C35AEA3D60B5DCB4D210E20FFF65D2C72203B471830392C714400CF380B1C675F58B74C1B389804AA064921089FA3408A73828852741F83C008A3A908832498F504A9CB4073120346ADBC6B980B674AFA680CF044D441BD9033B6F6E1D4056B99AB0457411DDD85387CC2D728185298554451D4A4207842483FC2208AA291416AA4D92F6220AB63EF58630C295303954038A26F1F2F054C18ABCA1C8034FDB56D2C08455CDF7A0268EC154E569E3380D0D84B5B4428392C6C63C389535EAC5BF622C254E20438D2AAD67D8D8227CEB2240AD17D0CB3A2C1D43F615004D3482175D1EC281137FCB5658450244D0D4322E31070F07029484289956601A6E92F6DE3C128E2A2D6174463AF682DD7D46C941127C7526F662E450DC1EC5F485DE3EB200EA0E92BA031A01351F5F402CED87AA735DB66009B314CE888B0E965408F0D9BF6FED5EA0E7F7CE88C77871FD3E4E979873F36861A4EBC75C7C38843A8E5CF532FAB222E5A5C4A79D9123E070110C81C180640182126521BC56919033F0D499F157E5A423F71E8F8B78BC60F48653809FC500CAA512C662EEE0C8C9FB1E013D36EEE079FB1972F8DE86F2DF04F12C7D11A3FA0B48BD753A3C04BA4CE14E591BE87D9D3D37C8961A086328522D5D9517DC6409D20F96C3CB1C70357544FECBEA01ADF135B04D3F497C0F160147111EC0BA2B157C19A2D53F0C346012464819D9FA3595215BFA76C45D59F828007EB9A30F881D84B919A64AACB11EFF11BD734D3153E70DD1109320D9DA1EE1517F49E23065C20A246A4A68EAC64B483EA35C850381D9C54547FEAE9F4EC31A213184E1321CD95EFD441D2720B0257EFB3870AC89B384DB494A7976B8130903E7BD60E9EE382451341FA1EECDC392264ACAB836917A31E19AE01B2C369C0A561F6D34F08670E1288B170C2F80098DCE5AB08ED1EE242F1A177C4E8F868A93FC63451C4B5C7F4CAD4C64EB8B8C5A78F1D1179FDA1488263F9794DDDC4AD484155E7AED91BB73AD52952CFD8FBA0DA0F640D50B3' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('F61CA2B0DE3890274E40268D882E38D6141AE3699173269CD912F42BE74C4649F97764BE0CCBE3625F5051B94BC320A5E7A97043CC380A563875E75AE7759D02523A6A51B17EE1EB9C7182F0A64E1A2693DDFE8C8394589BA07E5019751F542E3FCD5A39C5B5670403258E36E9659F8CA84B449AD935184CCCE1722EE8E5604389AB4BD12604E4AC8877510811FF22F5114CBFD11104F215AB5E52808BD47780A01E231A1B4118FD73240435D829D4A0893F773CE4582C91B3C389ED5238323C3AD68CA92F50026B384C6332FBC509E345476A1B7969129033D99DD2589889B557EA899851374B355C2BAC980801C7533256609D9D62B186E3C82AA594735DBB7ED26FE0C6BB788EEB741BEFE2D9DADD36A20E7953058C287E9317BF60478ED12DAB8298DF2579F239012C96F257F72CD7FC836BD7FA373C0C05C25B7DBF7964FBA4487CFEC7672FFEEB8F2F8AE1AEA35AA82CDDEA10AB350B0F54B44A8534B43E9EC75C95F4025CAB4C4A45AB931EC19B2AE4E4F55A653C05ADA8C961AE843FCCD02AE12968254D0E73251D59B0564B978456D3D16C1B8748E0D5D6474848C407886732D7A6B2FB6935AA19D05A552E5F53CD02D1AA56A99086D6C7F3D84E30A48162A2618AD935ACE3E8D0EAEA92D09A3A863F63077614487A0776697807B679AC3189A90D31D5844A7BB581D4D625918AC3B21ED63D28D66B1212F1BA58F71CDF4685C0E3C5534805623556FC9DBF56094F412B6972982B911EA1691549A96865D2FB6123D8F597C23AE8F53C38F8D5BC6611C4BB78C238B0320C6C9059DB8B002AEB040291B5616C031404250688D82A7754B31BD5BAADF643559F51EF59A97144851BD4B7B53EC575A9518FA6165D24392E6235D5A926AD5D3F19B0D16F88723368365B4D8D6A69A386B65B7390F5C6B0D658DBDDB8CD6DB6B72D1A501E87EBF2975F71F1CBF37E53C182CB8056BC908656C2F3D89A6AA8996634D16C55135A8F9C6C5053B6758A078984856D655DEBB509DB626053A9058D5A08F9D55D261D610AB80C1256E2A26EE9ABB6F387BCDD440BA22A404D524F5DE4C65A74041CCC0FE8048BA87FDE3A00D88757BF96BE0F6E3A187A0E68B939449D7CBA25EFE92BC1F9B7D11B8DC54A03DA6D15564D6A8272D25089CFBF4D05F050702F08EFC62060F2E869E712F5E0099F890E504F4FAADF761F07375A0B450534980E57E5659C4337130F9D04B4D732CE1270B1A2365DF84A341E3E4BAA0A509306770418E9075DD9A88840DE9AAF9F32090B82FF6613403745AFF102F518CD45E2A8004DB689B8E2A5D931410EC5FD80E6B9293C880C71F5D8B08678F79568BC7AB459FDB4FBE86BE95298E1F1B58BA290F7D668E0F0535CF902349DC0B931F6821790C76932100400314EA38CB37AE6CCED5ADFCD258697A6B5F732B6A19BA951AC03CD' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('A469D8BD3433B4AA0229C1893D86E5DECA79C646D95B411CD688A14D52156B36B3DA64FE8D02B27677534359F83CB8C110E932D0602337B3E699A236987F1BB9C1004B30A4A6F45C01145584E61A586D2163AB070FAEBC34613758F512A5A7125D035CBF55A548DF07770E4CBE0AF489054BABB793B3F84D27E6819151D4CB4488D3649DDA129CF824FF2572E6859C771966BF78FFD9CCFCFA93A77D15E76144B754305323607002D626D938F97A543863F0647FB58C1988E905126A7868967865CAED2D7F7B23A25514199E878629F7B5E25EC893552573B321361541E0A659549A3965D340ED87D2774FC645CD27865A1500DDD8C0C6C957C78211E1AF49B5D304DA24C83F57735556ACC1D19A04B136E1530E2777729D4163005360194276E5A1548BE875C0B7E2FEAE3D6B5A1CFCB613A0CDE92F1EB4138576A13E464A617281468B227B911BD7394CD46D2BFFB6BAC5B3B4681C1A28D38F00CD23F84906354E73F2A87E257CF5D8344C5D52A41A033566F8E6492C0F082E61168841E31676BE41D404E85523C160E066FE02BF921D7784DFB6097E9BDC966A6832FC5E18783AADED7727D164F1F1377A9F08BC0DF7D0440BB80FBA3824406B78D3EC01B2BADF977251E8B7A9985A259FE00ED4AB319A283D0945A722F464D4C3185A7589E3D1327FC4889C29C38F1C07EF1D869FAC94AF1FCB5FF347773CED7655FB30361F8A3FF3C33179287515DB9DAAAFB7AB6292E7E99ED57FDDB1D27CE245DC166566AC7A7CD915DAE6F929FB7268DF1A2A12B559DAE456B5B13CD92679F2EA98A75F924D5E246F5861B0650FCBC53F93DDB9340DF69FD9F6A7ECFD397F3AE74593D9FEF34EDA95946F16A9FA6F579ACCB7EF9FCABF4E3E9A508899164D60EFB3BF9ED3DD96CBFD36D9A9D8C58A281F43FEC88AEFF558E6C5BFECE11B2FE99743665950D37DFC0DE727B67FDA15859DDE67F7C96F0C97CDDC87728FDDDEA5C9C331D99F9A32BADF177F16F0DBEEBFFEF9FF01F0E7704DBD460200' as long raw)));
  insert into "S1502752"."__MigrationHistory"("MigrationId", "ContextKey", "Model", "ProductVersion")
  values ('201902151341134_InitialCommit', 'UniversityManagementSystem.Data.Migrations.Configuration', model_blob, '6.0.0-20911');
end;
