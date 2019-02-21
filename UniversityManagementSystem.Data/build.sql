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

create table "S1502752"."EnrolmentFacts"
(
  "ModuleDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_EnrolmentFacts" primary key ("ModuleDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_EnrolmentFacts_ModuleDimId" on "S1502752"."EnrolmentFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_EnrolmentFacts_YearDimId" on "S1502752"."EnrolmentFacts" ("YearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
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

create table "S1502752"."ResultFacts"
(
  "ModuleDimId" number(10, 0) not null,
  "ClassificationDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_ResultFacts" primary key ("ModuleDimId", "ClassificationDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_ResultFacts_Clas_1227287608" on "S1502752"."ResultFacts" ("ClassificationDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_ResultFacts_ModuleDimId" on "S1502752"."ResultFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_ResultFacts_YearDimId" on "S1502752"."ResultFacts" ("YearDimId")';
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

create table "S1502752"."StudentFacts"
(
  "CountryDimId" number(10, 0) not null,
  "YearDimId" number(10, 0) not null,
  "Count" number(10, 0) not null,
  constraint "PK_StudentFacts" primary key ("CountryDimId", "YearDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_StudentFacts_CountryDimId" on "S1502752"."StudentFacts" ("CountryDimId")';
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

create table "S1502752"."CountryDims"
(
  "Id" number(10, 0) not null,
  "Country" nvarchar2(2000) null,
  constraint "PK_CountryDims" primary key ("Id")
) segment creation immediate
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
  "CountryId" number(10, 0) not null,
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
    'create index "S1502752"."IX_Users_CountryId" on "S1502752"."Users" ("CountryId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
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

create table "S1502752"."Countries"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_Countries" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Countries"
/

create or replace trigger "S1502752"."TR_Countries"
  before insert on "S1502752"."Countries"
  for each row
begin
  select "S1502752"."SQ_Countries".nextval into :new."Id" from dual;
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

create table "S1502752"."UserRoles"
(
  "UserId" number(10, 0) not null,
  "RoleId" number(10, 0) not null,
  constraint "PK_UserRoles" primary key ("UserId", "RoleId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1502752"."IX_UserRoles_RoleId" on "S1502752"."UserRoles" ("RoleId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1502752"."IX_UserRoles_UserId" on "S1502752"."UserRoles" ("UserId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1502752"."Roles"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_Roles" primary key ("Id")
) segment creation immediate
/

create sequence "S1502752"."SQ_Roles"
/

create or replace trigger "S1502752"."TR_Roles"
  before insert on "S1502752"."Roles"
  for each row
begin
  select "S1502752"."SQ_Roles".nextval into :new."Id" from dual;
end;
/

alter table "S1502752"."AssignmentFacts" add constraint "FK_AssignmentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1502752"."ModuleDims" ("Id") on delete cascade
/

alter table "S1502752"."AssignmentFacts" add constraint "FK_AssignmentFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."EnrolmentFacts" add constraint "FK_EnrolmentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1502752"."ModuleDims" ("Id") on delete cascade
/

alter table "S1502752"."EnrolmentFacts" add constraint "FK_EnrolmentFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
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

alter table "S1502752"."LectureFacts" add constraint "FK_LectureFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1502752"."ModuleDims" ("Id") on delete cascade
/

alter table "S1502752"."LectureFacts" add constraint "FK_LectureFacts_RoomDimId" foreign key ("RoomDimId") references "S1502752"."RoomDims" ("Id") on delete cascade
/

alter table "S1502752"."LectureFacts" add constraint "FK_LectureFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."RentalFacts" add constraint "FK_RentalFacts_BookDimId" foreign key ("BookDimId") references "S1502752"."BookDims" ("Id") on delete cascade
/

alter table "S1502752"."RentalFacts" add constraint "FK_RentalFacts_UserDimId" foreign key ("UserDimId") references "S1502752"."UserDims" ("Id") on delete cascade
/

alter table "S1502752"."RentalFacts" add constraint "FK_RentalFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."ResultFacts" add constraint "FK_ResultFacts_Clas_2054432834" foreign key ("ClassificationDimId") references "S1502752"."ClassificationDims" ("Id") on delete cascade
/

alter table "S1502752"."ResultFacts" add constraint "FK_ResultFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1502752"."ModuleDims" ("Id") on delete cascade
/

alter table "S1502752"."ResultFacts" add constraint "FK_ResultFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."StudentFacts" add constraint "FK_StudentFacts_CountryDimId" foreign key ("CountryDimId") references "S1502752"."CountryDims" ("Id") on delete cascade
/

alter table "S1502752"."StudentFacts" add constraint "FK_StudentFacts_YearDimId" foreign key ("YearDimId") references "S1502752"."YearDims" ("Id") on delete cascade
/

alter table "S1502752"."Assignments" add constraint "FK_Assignments_RunId" foreign key ("RunId") references "S1502752"."Runs" ("Id") on delete cascade
/

alter table "S1502752"."Results" add constraint "FK_Results_AssignmentId" foreign key ("AssignmentId") references "S1502752"."Assignments" ("Id") on delete cascade
/

alter table "S1502752"."Results" add constraint "FK_Results_UserId" foreign key ("UserId") references "S1502752"."Users" ("Id") on delete cascade
/

alter table "S1502752"."Users" add constraint "FK_Users_CountryId" foreign key ("CountryId") references "S1502752"."Countries" ("Id") on delete cascade
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

alter table "S1502752"."UserRoles" add constraint "FK_UserRoles_RoleId" foreign key ("RoleId") references "S1502752"."Roles" ("Id") on delete cascade
/

alter table "S1502752"."UserRoles" add constraint "FK_UserRoles_UserId" foreign key ("UserId") references "S1502752"."Users" ("Id") on delete cascade
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
  dbms_lob.append(model_blob, to_blob(cast('1F8B0800000000000400ED5DDDAE1BB991BE5F60DFE140970162D90E82DD0C8E13383EF66490F1D8F07102EC95D096681F61A4D681D49AD8CF968B7DA47D85ED5FFE5615D96C92DD2DEBC633A7499145F263B14816BFFABF7FFFEFED5FBEEE7737BFB1E3697BC85F2C9E3D79BAB861F9FAB0D9E65F5E2CCEC5E7DFFFF7E22F7FFECFFFB87DBDD97FBDF96797EF0F55BEF297F9E9C5E2A1281E7F582E4FEB07B6CF4E4FF6DBF5F1703A7C2E9EAC0FFB65B6392C9F3F7DFAA7E5B3674B5616B128CBBAB9B9FD70CE8BED9ED57F947FBE3AE46BF6589CB3DDDBC386ED4EEDF732E5BE2EF5E6976CCF4E8FD99ABD58FC23DFD6E216DFDE6679F685ED595EDC7F3B156CFFE42E2BB227655905FB5A9C16372F77DBAC94EF9EED3E2F6EB23C3F1459514AFFC33F4EECBE381EF22FF78FE5876CF7F1DB232BF37DCE7627D6B6EA0791DDB5814F9F570D5C8A1F7A75D08237BD6CFCEBB2938A6F95787507BC58BC3C9DB65FF2AAC56FB27521E72D73FF9D7D533E949FDE1F0F8FEC587CFBC03EB72594FD7BDEB1BBEDFEA7CDE26669CFFF3F2C3B82B96F977A7DFCD7505555235E2C7ECA8B3F3C5FDCFC72DEEDB24F3BC6FB7C491624C930A498578712743D8BF825FB6DFBA51E4DAC718B9B0F6C57E7383D6C1F1BB43DE1A92B75C44A50BE391EF61F0E3BB9083DD3EA6376FCC22A510FB69CF787F371DD43ECB62B41A1DB344A64248B2130960F12F77629604E825F74B907EE7D006C079CA454EE8BC391FDC87276CC0AB6799F15053B96BAE39743EE00CC0DEB6A2A1553A97917376FB3AF3FB3FC4BF1F062516A8752D9BED97E659BEE535B7DA90A4B4D5DFEAA389EADB57CDC16BB18D5A0583370147EA27478B24F940EA1AEC2BFCE8F871D2DBB9265252904213992C5982F58BEBED3FB67B62ECE4786CB2C658025063318F2C2B9FA4AFB819DCE3BA283453A2C2B946E880A661AA48794C1BAAEC1535D83074C4F5DADD8A67188D557AD83E7C484ED56585AD42E1724A833DE3B5966B4EAFEB461752B5C501D0A8D2ECBDD00134B1F689B29E62AF65F0F875F7181BB5408907A9AA17A8D0C7D17881F8FD9E65C27E012AA792039E11C86B448B6BE32FF2DDBED7069BB54484E3DCD90D0C810D53C0024049249D3C05BCEEDA76376FC46C8293280729AC9A69C409EBE72362B81CDBAC5A43453918DDF20193F949A21231029D22119CD54C0C032B24434044119F554CA08F496F170D81312B6A9A07C5A9A299D9EA1AF6CF7C57943AE3B5206484220D91012CA33C88CEE56071FBBA29DBC494C68B5AE4BB3A145EB28455B0DB66428189A5649C754AD9A29E4C9552F2B4537A45033C60BD5527FCEC85E7639A5AAFE4D797C441BA65EC0D4879E44AFD7F0AB46A40F04CAD97D3CA5391C50AABA34C5C61B07C287A7AE8C3D86C0109AC9D07078CE906ACE7BABA3' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('E3DEB223F242BEE8EFABDE1BA4F75C36BD03E1ABE3C10EF4083B226982827B222114B12B1299025C2D5D55F69455B61774E00B22045F217474EF2D3F216110BDDC1D1A79013BDB3F9E4F69802D577571C0EE1A072BF32E75259D1D4A6ADC4C36ED0F204F48CBA3D7B1A58E68F45CD3CFCEE07D79B53306D919F441B507280DAB82006E949360699AC167C14222EA3458E48A744608CA69A6E2E784B4847DCF2AAEABC39457074F8023471D08C242AC111E7732949041168B6EC65CE13D5578F7568A3A6608BD1902D5BD2E7650D9C21C2D8B9BD5145E4795F049D01FCC474992F8D22611EDEAE4E9D567A85FD2F7AF8F1144CDA6AA4CD511419D517A3A6806199942EE763CBC20A8AE0CB6925D373D83373D560F182F84427A1F85B1DFF073270B1F04FCE3C460E50CE6AEAEC292287E49AC218A5692F7D2D47EDB34F4D2BB0299E2E0A3DE7B6BC9A0839E9EA7AF226D071114B14DC34404920D11A13C21757D6FF72763AEE31E52DE6E315745EFF9C6E5E5B978381C532E2836F73A8F590A39A860D3C40B62DD94BD3088BDD91E4F451A9CFD9C45ABC91B691ECA56471AA5903DCD96CEEF32C58EF5D52E3B9DB69FB7EBBA6BE6B5770565BF3473C668247CF5A0E75A29FEC1D2250495D1BC232373FBB97EE35685C7CB35D3B2209EB785B17D7ABA55131286B9DB33F031A325CAF5CD91DAC8B42B08ED661F68E219F7804ED3D40B309253BAA7E34E5E24722357EBBA38CDCE5B87F9ABB5C92BF5AD82E2AD0665815C2DC17C2137851ECF2574D0534F2A7CFD2BBB1E9E915274A33FA85B9652135A1FCC0C002CE05C4902DB0B0DE2D5E79CD0E0BA44C6A2AAD0AAB96345B6DD9D5254946D76DB9C37E9AEEC958FDB6AFBD8F786EB9CF756FB1673807A71273D2E362D432911796F27E7E8ED4A73CE61C1CEB954AC7A34AF26994269E9837C679A165EE2E4AB5CC0D930D3E20D639B4FD9FAD7F833AB3AB1186A08094C849B5BF2C4193EBDE07D173401FB9CDAA3A7482BAE19D4E3A3EE3B7848CF13074DAB5AAE0B9C5455BBD21C4DBE2F375BFF3A1C377FCB4E0FF16BBB8C3357D8200DB0C13A9E58389DC2ED64DC5E5D553883ACD42601DB4CB5A97DD7E8A681C40325501CFE1D7945E7290C27BEB19075AD1AD507F0EAD42938355793EC4F6162A32F3104D39208C2123FD19A537E8A15C21049FA8CF040F88A829BA24E2B127493612C577D16C7AA185C9E2AD5E81C25015C2345EAA045B2530417B84EA6BE546B1594BF464576FB9A86F31DE64ABD5E47D97719AF1D8203AEBF7579C46B99F64921F050A64B411E6EF164BF15B8B91DA25E0A373956DD82ADAFC74A32B22CAB79222E83A6904622B5147A0A482A02BB2903BFA80EA2051AD45DB5C0605DCF67E790090C3F7233E6779F47783853DCAA5339EA6BCBF633C80FD7A5F951AE6D91EE691FE6' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('00F2A829D8BB3A5FA92A475ADC4F171047FA0CFA8D5382F47A527D9D903358961DE610F4585907D090C795579CCC0027CEEA0D79B04801C6AE74BF550E9EA4605586550728533A3919D3C04A9E10AF86AB020750F7F5788B3080B42FC4D3827008ACBB0C73125EA960505D849544D08D5FCDE149B81A0A83C8340171EAED247FD5ACF3F192B72ABA9E3300729187E748C0C3D066FA1A87A175DDC861689D36F09EB92AE812B1FEEA81AD7F3D9C8BCA1962B863042BCEC73C485121AE9413AD1B0EC0849F2BA9A01D7C69EC705B80C8A11C95FB4D9072577789D3E3E28C6C871D3BF48ED6DBB66EDEDE923CF7AB1A3CE6D3EEFA3BC66CDF240E33A19B922E11B642ED0E54C377E7A3E220EF4909E1E130079C410574BAAB11E70B49846640C56B08173B317B54FFBAEE3BE85CC71387593CA5581738313C42CDE84ECB6CCF4E058B61B8838F9B6278C3214B83BB53A7B144204E9FC1DD46EAD902798D5412E04E2355AA679816BCAFACB313EA2563EAF67BEA46B09D568D0402F6D59F11F2DE262D4C18B64BD416213621619DC591C5C27182A061CA94E9337823E2ECE585CB337C47D2CE970B44E585062AEDE945D1E943C48BA2FD0FE945D1FEC7E3510445AB4EEA6198675AD5D103DC94FC412FDC641DEE038465E2F1FED2C71B37B2656475A1EDE5B9037BA1C0DE3D01567F8F59414AA8CD1C2F340A4FA04B54C0C33711210C8B088EEDD824E8E91786073AF1853F6A6AF470DC26A41A6E6D747EC5BEBC70CE6CA07E6A3788217B08A972EBCE221DBB9B1C806377FD0FE46A2E52833EC472703347A50971B27E99566C8C9375AC535F9E4E87F5B6165B594FEF8020C0AAD0AFF3CD8D6CA901BF1083DFB44558823561C1DBF3AED83EEEB6EB52AE178B670B7DE4DEE5776CC70A76F3725DC9571DDE9FD6F5DB4F7DF44A59FA0BC70D60219C9A4597F07746C525A6D8B11AD46CF7AA9C1CC531DBE68509C06DBEDE3E663BD7EED20A70C470D50FBC2A3DE58E3DB2BC829F6BAFB8C840D35F2D799DDA60D93AED76298192C62A16421D0383359EBA808292D58E047B1D00DCD2CC052F905A5A9100A296B19A0740B178EA1878ACC1D5057838EF4B12356A8BE69E5A895A3A2A013E2D3DE22201CAD694089D608C520C0174C05231FC72C0DE24D0A443FC0AC1783CE73888A4FA27011CA95E70A9DE12B13A051C8D28C9D888E321937D469B281740510AB5EB853F4CF804D8C3C6630E3A108F548AA1C4216CA9808B14093289327408092C84D38241C7D18BD6EE4A00506BAFB8C84047514D815530C228BDF15533E31BF2BEAA928E839B1AFF03F6E17013926DC1E1F1991D1C6D2B361557362014E7B86EE3E2A705E10CD76E24DE3C06145BF079FF85D15AC79C004937210128E9719A0330A1E0B4A8C54645AA951652117E308D214945751662F1E8DD918C' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('47BC7352988D781F38ADD06480CE84073C5AFC4ACB410A16CFD238E2E9AB1B2D918E53637DC8290FDC8674C73CF018CD0F94B6259B0CCA1B1490735CA909F9134371866B3410D817C30915E557C084C772EE81402AA8FA2CF421DE800408C4C7651E9AD088DD6C8509A10307C16F8EDA0F133E25F066A8F73A53D60A3A3D23043A77F39F28774EA0C3844F003A6C3CE6003A3800386A97D1D1C025BB4F8A38DFC7EE23E388CFC341876C430AEB8F1A2397FAC777CE014369534BA59E195B86D39DD2D0F1E83D278AF76A8CF54FA21519EB0897EADBDF4F42415A37C566DE48CA718E2B34217F62B538C3751A8A068D01850C0DAD3AE2A45388645479494BF3E448EA90E89C0428247AC1A5F6F6E7A3A1108A148D0D3819365A0C7817523C0D0AA938D5295148744E021412BDE0527BFBF3F1CC432EB6FD7CC6C80A9A863D869B2C7B4ECB312E7E0AAB101D97392CC674B8630C2F8EB18FA5D36533E8799A1B66B7E8E8F2FCE99263DD36BB745D02D83AF58CD311B75ED088CA1408388FAB3C2AFABC1F202CA5CFEBF0876A4212B58A8FCF4C8E7E440BEC6BBB9E350A14E7B9B663E2A705E11CD776247E37BA58DA82792B2ED73CD47DAA37076400714936293DDE7303AAA352ACDE747738ADDBBC88D1002A896E5591405E0898BD069F2E7D4E5A92903F011A89B199839E545F81DB8008E68EF8BA7F8E70245B900090E418CD0192666C74DABC0303A5EB96637FAB118AAE0EBEC29F1E04D10624331B813171A95BFC6A6CC3B10DF76831C9F4E08F869198D642D4C36AABC7F3710D42B52BD299816A9B7B187F233F5EE1A126D13145E24EEA6EAB49DFAB98716CF5A7A8511FAAE8BD91026660BB9D70C6436B8CE687D885DBC006150C84A87A1FF6F53C34826F26C5ABB7CFA126760260017D3F035469911231246061138D27251ECF4966883058F2042083C761063833E3C161A82082C3A94E32093D6490708D06FA21B1023AC880DD9200756817B8D40D47FC4CB6F71401D5F0ED21105D4DF742E8EF81A0C5114C88DD017E078AD049769746DFCF0553F516CC020195D13700A6141260CB7E70329892854E8729B9EF5D6A45B9B3139A614A4C5E8BD90407E8F55C92E8D2F1056F7A9823E44F679F4163E3523B154B3BD50B0FDB56008CEFA8BEE7E8FBA472863B0040EC14AACDECFB19D8FE4A244454EF8061118DD7191E2F33B4E09F3454C7471624750ACD05F4BF4BB55D34CD71F495166710553258D041090C55B4B3346FD09008874E9751A15E9FC11D924285C1AD77825A13FF6EDC7BF59519CE14B8ED5663E401F7E85E77E86A68CA74D81D766F2E4B9D0060E018CC075EE4B6120B7A180C60F3DA5FC27227C5D8AC76994AA8596A7932E3CE8EB5509AF1A93D4C42EF2552EF8744EBA3DEE8A96B2F28B22136A8649843FDF2B98B41E8AECAA808' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('89D6BBEDF1351A217E02EC1163E3B4CDE46104C7472118BE1481891ECA32300AF5F8B1FA8B9989A350153F350AD5B171A91D8B289B088572E45E0C1E6018DFA4B0806571DB5A040DEBA67442027001CD9D01A8CCA8A9D87012215421BA6E3FAAEE192EACA8F00930878EC90C16553D2AAE0338B0ADE960D4CD6B738A089E166FB3DA9EB693C3EAA9CD33E1265BD2E84163B9691BFD90CC38F372D21E538DD5F3A079CA4053E37499304E9C8484385C1494DA21220B8EDE0F09A005B579F23A4B8D314E0D27CF8541AB2EA1C7CA08C72957EE37A7B8B904C54E042F630C9C4ED60E235AFE6AD4782B1430DB6B10BEE665778162A7C4D7846DAED7754CFBF23745F90B76EC5EE93D56C3D750DE7CAA12D957F38D66F5C37B56180FFB1A1A869B260311D5D880995A20A73881CA9298652CC5288F65A1A2B487CC96E2DAA7B35041FCBDB2A5081128D82C43C45CB5142282CD42C5C811842D05E9313BCDC2F4505E960279543DA82C2998A1D3F06332C971EE2C0589F8516631827CDDD6A82ED201D828115CC26DD4307194202C96A23A027DA81C11C8C0268FCCDB0CC823F3DF3AC883F40F2774B615C1045925500A13DC7F0E330C918573A95A8A68A913A1223811A6B539826A0E6A8EA03BB2814FE72003416872D0598A555873CC0215AE11FB9C6FD9569049CFE9742C05C9AE5BD40AE2D8F978C73B01001B7DC7FED832A2371CF528AE441D75165C42EB43EBA03A31B5E9A8EBE03EE0BEE26EFAB2791E8616D338B43BE8044C21386A265C2B3969474C35BA6A694243DBEBAF2E9F80EAABBB1C57038A349E1CD7737C2D779C0F7831EACDACB3D5435B3C4E6AA2B2F13155D16CB1ACE8800B007F2C19F280B1BC32EC7029BF6E3C1B99F5FD867E2908FC86EF2D79A354D3DDD8C3B894D96D2DA5328D76E97B45B55F1CFA4CA5D1917614668F6159F1B621BF807A4BDFA1103D86950AF4173E061E5DD5710C39800BCB8A370AF905D45562F7457412565E1250899DD74ADAE799DD04E6C3DB0465873A48D916127D0496077490D486C15DD395C539C8806E31F2E04DD0B342DD818A4F97047404863C8F7E10B1EA8DBDB7D9217866BC3DE86FA02E92B7EB441FE165029D65B46B709F4951D6A523046C69D3F2D95620353BBEA0D9910496077410DEE9C3FA869859402EA77610B3CBA357D2CC3024AA3DD02B484EBC2D7464F51E93C0A5D4C87A0808B10E69205B2476554F10B1D8E509209DA7515A8708A12E9526C91F6A016FE6B038D84357702DA375C955F3136BB81D35743470A7DE1ED841C4CCB2C6A8469B42CC29AFAE49339B8060C840AFD842262B8D2082264B6D900E82890E21C224C7028A119B97EA0F3B44D008BEFE7D91061946B858A01FE890B28AF46850591785489714B71FE008A690EAB0873A55273B19EC54561FCA7507A53EC8F0A6B1' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('76D960344D64D218F968B8EBD9B1C9635D91C970998E5D3D103BD4A2638B01898E32B5E8F8A026CD9482820D22BB6A3D1BBD1DD672637B6B2B5CA8608232F464F907F70A14FC0EE8156B8C3CA52554943CA925E2DE90E8152AB85DB45E0182B141BAC5CC4528032333A857F066D84A8BBC0122A383415B21F77062EA36C629A0986C870137BED436C9290E983224523B03200B884C0562CB16C14AC30311C3CAAD31F6F2A2AFE9669824BA675C661D1A4E6958AF243BFE04E3F6C0879FF6103FFA312519E4473D83133E0BF4C927199B472A526DCFE09E8202C800BD648D33A334878A34E3D8146B797101040734B1DEDAD9BB868E7D12E2C62ED15184115E035539680C0E40474051380C85E3A26CA0B81BE0A55C4075D3BE21C2950CF4C808D203DA3B2343A1D40E2F7675A2BD10D22CC870C7BB3C08017AB20B8729008E618D4005C6C191ADE9708001E35E24D4A14BC75B889CB780B486C601894E6CA89DB2D84F58742A43875EF33F95259A4CF1BA4367A744C325D72EFB196C9AF69B6CE2C83E98A01C3776AE30E9B8B607B66F8061AE70F3581B2CCD7BA7D7505CA35B3C80011BD88DA91CD8C6A6CE6543A7B25EDB3ACFBFB98D6326DA5CF3B50C24ABF25AC6AFB9CADB98087A1D2206C6A73BCE1F0CCD559041D811A8D6F250E0038AC4F3F494507F2891AD71BC4928BED68DD3723E9A48E3CB1CAAF85928C0B10A1D5AAA2CABE6E9A7D3C9A7CAAB6AEB379F31D6D83DA171A60840D5A142284065B96BB7596AB811E6CE68E6ACCA3A496D7A4C5A4A7863A21053429B1CC70D8E424569E9C3410DC7143DC59888888CA9FBDE6D8FADF4159E3E04F5308F9F015783C9AF2FDE0D023E076DE1ED26A752C8A10E7204D39CBEFB42B9E68C7D08F735B7FAC5C1EC7251363610A799AD5B20EA33BC151AF9D9F06ED1E8CE8CA3D6704E700DC916EAFD0670702952432C5C7669D122E2294393FD89F46DB3CF0B9C244A125E7934E1E4CD966446E88444745758D6068CB5685837C45E1E149E1C541BB81C71994C3AF631C3CB88D86485BF05B9DD85F95D8CAB5883E1C5262E5E027AD716AAC91F3ABE0AACCD22032D32CF87B5BA7D946469B9280634FBC3287795F2826AB86576C3AC18FE0D0F35AF2BA68BEAC79C8781A7DD2EEFD70F6C9FB51F6E976596357B2CCED9AE5C6AD8EED425BCCD1E1FB7F99793F865FBE5E6FE315B5713F3F7F78B9BAFFB5D7E7AB178288AC71F96CB535DF4E9C97EBB3E1E4E87CFC593F561BFCC3687E5F3A74FFFB47CF66CB96FCA58AE953974AB49CB6B2A0EC7EC0BD3522B9DB0616FB6C753719715D9A7AC5AAE5E6DF646B63EAC135D9530F9843974DDCBBAEE77D5FFB7E0CAB7BF95A355A6BFCDF252FAAA94FB6FA782ED9F54E23E690539E9FC155A1DA2C3DF947D50E5AABB83813B41B880B288FB75B6CB8E1D2388' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('FEB8AFE2047975D89DF73990A0E3152F4F0AFF2E97464485C7CBAAAF33D472DA4F6619B74BAD87F4615A1AE3A44D207DF89DC021DDE747C105EACBE00009E2B7588FEBC3D677BC2A9E1D75B84CE61DAA848FDB62A715D17E9ACC886BF7B351465DA58DE93FF296DF5F75411464F05BF62898405C0C1CD080FE328E16A8AA33077C42E344BD890D30509C66A9FF48E13FC53A5BBCB5D5074D4DB94E5A040CF2A3E6287090E8B2FA0382FA719CD95BFDABFEBEF9329901B33F550E30681A2D59FF81B31540CC98E6F1AE3E8A4AC2753623E090DE3E47C105FAEEDB0112C46FBFD3A92CBFF18EB87BF29CC2D48FAFD3370A20A847E001E0C01919FB8301FF29DADDDD7357030A72C2150A982617AF85E36872EC8DB48B26C77FFB9D6A72E5ED7C4C33DA73FA92BFBECEE0289810EFE5A30082F3D0F64703FED32B14E2A807FA317908F520B1097BA807EAD7A94E4BDBD7EF7A69D2E72BBE085513CF54E828A6FD14CDD54C90C68951AFE1430C15AFC067B4881F635DDEBEB6D7C74DFAEC3E7C2D9F815E96F4F9AA008823FD780AA0E375F73BD09FA402C04A78792E1E0EDAF54DF76D32A3CD7930A28C7647C1DF7FB4D15FC619EDDAEBC51C72E9B37B593F675051E2EB64C69E26C508B284F0D8093E4B08FEE35476A441D861EC59A00CD7A5053B8832E952E21C481931363C0EA6EC65C451456AC514DC2634B216DA8F00632A8739E93F9AE4AFC919053A04A829D7F98E5F2172EA965877885DC41AAF4B44F4C791A676175206C0D284868D7E9619D4437790776EAA61EBE349899571C78A6C5B3D4C974BE11FFB94936D76DB9CE905755F7B9C919D73E37CACF9341920E2CF428219A7DE86692AF055DE2FDA68B79F7AEC6E18DB7CCAD6BF6A9B1BFED5BDA42EE2A57E40D3AF4D620AEB65A929930122F6202BD016D9737F9C0A82555DE686567C752FE97D69BEFEEB70DCFC2D3B3DA8A5A92973D9B85B167AC46CEC6D34B4F1D74D2798494D12C1AB15D3D6F337F4A6777238AA675F54B73E6F9FBEE90D123A2FEBEB6AF8127B5AF3B2E3B28933DE20558FCB78233F1C7BBC47F4D78BE8ABE7E9A737BDE199FD74145C5A51061BE11073186FF497D7210F32E4289561B85187B802DD471EFE356A2D373F42DE4AF5BFAE87EEEA27358A1187CF73DCFA0DD8D8D37516F7E11D8164A423A73A08B5CF9113FCC348C7D40F6CFDEBE15CB140E86FD095941E678DAC381F73B33CF97BEA43A859E89C8690310E1801BE491728823F9BAACE998F898093028673E9F577E74D35E2952AF8B8D5475D7CED51D2F9085CA08BAF712E4AD032CA590379234F0A8308EB5E085D63529CBAA81AE8577170E74EB48095705FB6BE6CB9568AF8EA5E52E3AB047B304D0A2F12FB6A14D4F0F287D0B6A4BC24196E94CCE052B663D78C32E43003AAC378633F8C64217F0FEC4C2A' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('8B6CC4CB02EF41A77F1EEE426DF69A5AA6428D3290A28241041FF359EEC3A8FBD9DCED0ABECD28F0E98AF77484807F1A79A53E9833BFFB3699618B38649EC3D56FA82EE2CECF208DD5B3F0DADB2FFC6F4E1ADB12B62A4CB275AB2B5ED8BAB5A7963C5667706DB22C6ECAAEF96DBBA9D85BDF1DB3F58E3D69867753E57BB95EB353E535BFADEC659EB5CCB1FD5CEE5E3E1E7E65F98BC5B3674F9E2F6E5EEEB6D9A961F3EDCF52CB36FBE5E9B4510E3225341ADE61A6BBF6EDDFD9377D6CBA51FFC03E43CF40F4D106F2A3FED7B74BBDBE5BD004687F5C35E2C5223FEF3F553BBEF747B6DE9E6AF2E3674F17371544CBD4F2FF7E39EF76D9A7EA8FCFD9EE640052AF42922E4E05ADDB7888C2E589420E3242A8EA36BE3E0315B3FB2AD3BF2DFBB7ECB87EC88EE54C799B7DFD99E55F8A87178B12FF4AB1C5F16C2DB5DD0D0C2BD679380896D3EB94BB90290772974E62C2D546C28FAC5C1AB3826DDE6745C18E795502ABDBE0357C893B17A61B75EB5D9A5E34ECE451EBBACE1EE701C6E8432731817AF65F6306275A5A28FA4EB7CE2309FFC24E0FA5AAEBEC701E648490F33A399CCCE0EBC4B8D88901935D3A0E2F4588167878E5AAAEC3EBAEF760FACAABDE73B3A6AE33E36267064C0C791DDE0B195E94E631CE7111C1DC38BBC325A92D57C0F5D227D775B677AF319887D1ADE308EA45203741AE18768E4A62C51922A925D719DAEB08F43A43D152BBA72E89663E48A038C7D190A81C420F89A07648A68E614EC33846931339E1ECCC27B0555735ED7E6441131B4E424584BE10D47913134D779475D0F9789760190C7EBE2BD5759D4E7D6E3E4016C149CC239FFEABA80813CD0F8CCA6F127D175A070571E8318BE51C82E10BEE38059B9237F52BDDBE671DCDE395B42705003FDF4522AAE5018C64767376C0D0C0EA7CADE3C8AD320826059EC9C97791B013C47FA191A19200862E7D061B4974498EBAE6B78F4DC6309BBE83E992F4800122D1BBF6AAFB6CE3C4102378115C472DEC5C30F9EBAE7D3AF5990072D05D876D26C366F291F57280EF71CF38C0F53DEEB561F2AEF7EDF3EB7461C9EFE4201AB78B1C2D95276EC8F991441037A098B8470EA3CC7B9387ED22917459CB2444A67691C32618DB06CC5A41D616C9112FDCE1345078CBEE965629E88C691709AE70CF3BCDB205615B689D2368819242022142BB4860C45DE6C7B8CB82B8AD2E72E82E814401A723EBF39CCF71178CB18CB93EE58B374F465274188BD8454E97984B605C2D3AD27D134C13E6EE06EFFC4EC56F4E465EB90E23CC47DFDE9ED94C8C79A5F1F2743AACB7B54E5374EBDD76BF5259B2F4CBA3D7F9E6A61A009968A915B2A2EE7A227D7D7BDE15DBC7DD765D0A507696C116F72EBF633B56B09B97EBA2EECF57D9690D04A0AC1AB1C1A4D038BD6451F424559EDF19D5944861' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('C76AB0B2DDAB437E2A8ED9D6E46B7B7FDCE6EBED63B6337A41CBE908C1AA79BC4C3DE58E3DB2BCC20FDC58971A69D7EE25AF41EB715B5FDC2E2508D1C85218A056183DD7D470A5F256C9926829F3471541D1355950B51EBFCECAAAA3A89207927FFB2E141548D21507501E6A8A08549F044F828469D5116EE16092189BE461943F278114A70693A5101FA3C00863AB8A832498FC0CA9CBC2769602469DBC2B98126F4AFA680CF024D441BD9033B6F6E11C482B95D30C574182164B1E3EE96B120C690C6CB2287A52143C21E460711045D1CD2135D2345A29902568C0561893DAD440253197991B804B011346CF3607204D7F6D1B0B4209D7B79E001A7B855395E70C2034F6D296104A1E0BDBD870E2E45AAB8E0691309538939EB2AA89AF49F0C4E91A6521C4C7382B1ACC21180745301F255217CDC39670C3DF584608D7E2D43024731B02070F97822494C27116609AFED2361E8C122E6A7D4134F68AD6B15ACE4619711A4E5908F171FE6A08E61945EA1A5F0771004D5F018D019D84AAA71770C6D63B9DD93603D88C614227844D2F037A6CD8482CBDB3B9D297998515BB47FE3EFFEB7C944019A96EFCCBFC96817725498E6FE73BBA5E7DEDF81E700452154F0345148F766A8534FDA56C3C08A5DC82F584D0D86B5A4B33BC12D4D6B816EA2889F5CBF384463497525585D2E7280002C998E30008E318476AA368C253E0A7254676C24F47A22C0F1DFF76D1F801E9A327811F8A943E8919C4C59DC10A36167C52EEE3FBC167ECE5CBA05F5E095270E276CC206D560E15CDD444E8E274E62ABAC4E738078C3485752C9CC1DCED486D6EE4EB69145627F86CCE00C60256D213809E809AC0018000D21C56BE71209474E5EB05A0D1573ECE94BE9288F149E7D98E595D7374E49F93204966F1970551BEC7F27504B9E5E3C0098D56805467094F90025292C8335049E30129A152EA8BA2B1B592FAEE71FA201AF7C5634220F57FEF3836949AF5587AEC88C248CA02BF304C6A2401065224F8605D130741502008A426356AC098E6D1AA3ADFB21A459045940833759403FD4034AE0194022C66F006A41E89917F44A7EAF69D90CD9F1AF03D4B04939689DE7CA214D5E92C0552208E7D0C2B9C677234AFA115482E3F1D9CD42CEDBAABD0EC316272CF4F1321ADFFEDD441D2D1C2037ED0B3870A48793F4DB45457B72B89EB9DBE78376EDDD382C51041F91EEDD23D21649CAB8319F393ED8AAAFBB915C0533F0DB8B4A4ECE6F5E8CC410291CD4F181F40F0B49E7B8E0BC187F346241D3E5002C484268ABCF6D8287F5CEC848B5B7CFAD81189D71F2ABE4B2ACFE5A99BB8753C07DD5B7AF6C6AD19A502A967EC7D50E304BB02A26AF41CA2B8AEC8901B72442FF684FEC7CEEEEBE36991732E9DED134F1FCEB98A92EAEFC4E4858ED70AA1A0A2879D8883949EB707' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('2D5FFFB8B78A2B3324C7149022A242803788F3C60912F262D23099ECF6671CA4A4DA04F583CAA8FBA06AF969D7CA29AE3D23182869B4492FFB64445D22471F598171A03D2EE7A25E0EB691524C29BA84880482E92E0AA17830487D440098E40802C3D8E87EE28093F87780A01E239A1A415854A044086AB153AA415B408AF190E3B044CE0E27AE4BE1C8F0101486535FA0A4605230A7E4EC17272C5C1652DBC84B93849CC9EE94C6C24CAABD524FC48CBA596AE06AF7A51C55C924F6A44CA458FA38528EA9522A39DBB7B73401C07817CF699DB3D35D3C3BBB658FAA43BA9081ABEA1FE2524833669B0FC9148851BFF818E95A288D490B076C44EAAA328E8F93C95A2663E0249536E9859384FAE4751DD1B1FC4D51FE821DF99AB7616FB6C753719715D9A70CD80155BFBA6785F12EA579D4F59AC789448292DDAF1FD83E2B139FFDF1E9F3FFFAE3F372C89BA8937A08367D90F59AA527FF46A5521A5A1FCF63AF4A7BB86654A7A5A3552AF9ECD5F2777B46853C05ADAACD61AF44846A326A1149683522C899AD1E39AA9951939C88D62532D96BD3632B1835EA19D05AF5484AB69AA5303746A5521A5A1FCFE33A039006CA899639E0D630C1906AD42592D09A447C056B070A026AB303451ADE815D1E674C22AD52526DA8746B9B2027366A134968555D168786C9FC7F66C3E454BC61328BA64BC3E021E32964B39C864B268532EB9112F1AA98A05473518C7093780AA9169D9AC4B9DA8C4A780A5A499BC3A5DF04A508D06F2291E837C100659DBF26D793398FCD3CF87CD6F3DA4550F80A8CCA9554B45A8501C441E973CA0F48EBF3444AEDB799ECB5C9EE5284BDE5646BB9A207458E15356E9300990116F83B8F0C3E2CD631D932D7451F5DF1ADCBBDEBAA882E89D6F5D06979479676CBB2EEBCCEE26BAC757D751904C5831DABA949B5ADE6CDDB31971502591E2C6B83EB5A87AE73D635CE6DC946D66BCB62ED6C7FE0B687DDEE706840752F6ACA5F7DC5C5AF2E7E9DB77BD456CF659BE76AC2A3E6BBD57477554D683D6AB2454DB9D629DF28113B2FA75D97DBF2D19C13814B4893442E235516970903D661291F2E5B3A93014E348C70F437527EFD88838E5DAF1CB319472665DDCA57E3D80972DD96CDAABA003D493FF8531BEBD0112AE591249FD90D58D6389D001E04D5BFD7520677417B7EE382042C2BDE0CED60A96E00FF36110C88D39E9574C864B61ECC8737C13C86AAC5973F131DA01F96D5BF151F0737DA88FB0E34988E0D1F649C6337138F530EB4D731A8397071AE375DFA4A341E3E3AAC0BD09306770418561B55F65ABE38CD370F1525FD18BED904D06DA1A283403D457391A0C540935DC21B0769764A90434176A1796E8BC5AB425C3F256E202EBE128DD74FB2EB9F8A8FA196AE66BA0A89D0B54BCB18A7D1C059B7BCF245683A8173' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('6BA0D320204FD36420E226D0625B5CCE60E3AC5F31D43F151FC33597185E3A866490B18DDD4C239E21D04C3AE661906646575560FC3D68C6DA03F505DB6501B757CDBC95BF0701F29D1E2D0E01B3918F06A6DE6CFE6DF44643E1CD2CA31D513F276932148E0BD956E9D9E81D92DE64FE8D525BC615660310E9F3E00643F1A380065BC34C29826B1795B5D4FCDBC80D06021E41F3D8CC1561594AD05C3A400F6459BB47F451CD10EC26B73147CC54B263F43BE8B663C4E7003800E2C88048B0C59B09B694256E36097F3A364A20F8C76F2E16A5033E3AB207F4D04F4EB48BFCEEE8847F269A0FF81DD43F57BE0FEE0028A604D0786BE88920239EA6C9700C04EB7540BC66A7BB083039FBD1C98D12FB2387F8C801BEC30C076677B899DD3E8AC2E733F46A0A9AC5D014261B273BA2700B27D809186744470FBF60CE74E068003817201BA6FAA748A7C18176CA1D771DB24906A9ED02344BF659E13BE370A75844AB285AEA000DD31C66E453AB403B22952519D90F1154CAC66EC8D80AB934D0F8A1F23DD0C6A061F645770400F1EFC0C6A9BE3BD206205C931AC58436097ADBD257CF256B12C49F8A4F399C66D577068D014C89EF1339728AA55A64B72F7E3815EE64A921A8C48F940002CBFEE241A748D009528891D23815A1D1A26817D5C6098FB5A66DD5DF4EFE168EA6DA10D3BA2602A44C6A93297050E30C2F3BD57C0EDA344C5D52F476033566FCE6297C6B082E613EB641E31677BE412461A85308C125E667FE02BF523D27A5DF7609619BDC956A6932CCDC631C5A0127569368B24CC3847A7E002C4D019AE800F7412E1E04682DEC4201206B3ADEDEAB2E1D619B8AA955920C67A05E4DD144859C059D8A2EC7101E6318EB1042A11341EE8360BA91C17B877847462A0506D22A9181B23B3555D27CB08C93F12BF1315CD3B05946D03A0C1CB1504DAB381FAADF7392019E76BB6C1CE6DB0FE59FC5E1987DA95618B63BD55F6F97A56A2EB67BD6FC75C72AA39717715B9699B39A724214DAE5F929FF7CE8B8153489BA2C5D72B720B122DB6445F6F2586C3F67EBA24C5EB3D2CCCEBF2C6EFE99EDCE9541B7FFC4363FE5EFCEC5E3B9289BCCF69F76CA5EB2E268A0EABF5D1A32DFBE7BACFE3A85684229E6B66C027B97FFF5BCDD6DB8DC6FB29DAE71B0222AF2871F59F9BD19CBA2FC2FFBF28D97F4CB21772CA8ED3ECE59F191ED1F776561A777F97DF61BC365B3F7A1DA63B777DBECCB31DB9FDA32C4EFCB3F4BF86DF65FFFFCFF9BF48A7EBA9C0200' as long raw)));
  insert into "S1502752"."__MigrationHistory"("MigrationId", "ContextKey", "Model", "ProductVersion")
  values ('201902210805040_InitialCommit', 'UniversityManagementSystem.Data.Migrations.Configuration', model_blob, '6.0.0-20911');
end;
