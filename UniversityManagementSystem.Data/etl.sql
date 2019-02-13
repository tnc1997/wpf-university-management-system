-- FUNCTIONS

-- Gets the id of the year dimension which corresponds to a year.
CREATE OR REPLACE FUNCTION S1502752.UFN_DimYearsGetId(year IN NUMBER) RETURN NUMBER IS id NUMBER;
BEGIN
  SELECT "Id"
         INTO id
  FROM "DimYears"
  WHERE "Year" = year;

  RETURN id;
END;

-- Gets the academic year of a date. For example, calling this function with a date of 01/08/2018 would return
  -- 2018; likewise, calling this function with a date of 31/07/2019 would also return 2018.
CREATE OR REPLACE FUNCTION S1502752.UFN_GetAcademicYearFromDate(dateValue IN DATE) RETURN NUMBER AS
  month NUMBER := EXTRACT(MONTH FROM dateValue);
  year NUMBER := EXTRACT(YEAR FROM dateValue);
BEGIN
  IF month >= 8 THEN
    RETURN year;
  ELSE
    RETURN year - 1;
  END IF;
END;

-- Gets the academic year.
CREATE OR REPLACE FUNCTION S1502752.UFN_GetAcademicYear RETURN NUMBER AS
BEGIN
  RETURN UFN_GetAcademicYearFromDate(SYSDATE);
END;

-- Maps a grade to its corresponding classification from the classifications dimension. For example, calling this
  -- function with a grade of 70 would return '1'.
CREATE OR REPLACE FUNCTION S1502752.UFN_MapGradeToClassification(grade IN NUMBER) RETURN NVARCHAR2 AS
BEGIN
  IF grade < 40 THEN
    RETURN 'U';
  ELSIF grade >= 40 AND grade < 50 THEN
    RETURN '3';
  ELSIF grade >= 50 AND grade < 60 THEN
    RETURN '2.2';
  ELSIF grade >= 60 AND grade < 70 THEN
    RETURN '2.1';
  ELSIF grade >= 70 THEN
    RETURN '1';
  END IF;
END;

-- Gets the classification of the average grade of all the results which correspond to a user and a module.
CREATE OR REPLACE FUNCTION S1502752.UFN_ResultsGetClassification(userId NUMBER, moduleId NUMBER) RETURN NVARCHAR2 AS
  averageGrade NUMBER := UFN_ResultsGetAverageGrade(userId, moduleId);
BEGIN
  RETURN UFN_MapGradeToClassification(averageGrade);
END;

-- Gets the average grade of all the results which correspond to a user and a module.
CREATE OR REPLACE FUNCTION S1502752.UFN_ResultsGetAverageGrade(userId NUMBER, moduleId NUMBER) RETURN NUMBER IS averageGrade NUMBER;
BEGIN
  SELECT AVG("Grade")
         INTO averageGrade
  FROM "Results"
         INNER JOIN "Assignments" A
                    ON "Results"."AssignmentId" = A."Id"
         INNER JOIN "Runs" R
                    ON A."RunId" = R."Id"
  WHERE "UserId" = userId
    AND "ModuleId" = moduleId;

  RETURN averageGrade;
END;

-- PROCEDURES

-- Extracts all the books from the operational database and loads them into the books dimension table if
  -- they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimBooksEtl AS
BEGIN
  INSERT INTO "DimBooks"
  SELECT "Id",
         "Name",
         "Author"
  FROM "Books"
  WHERE NOT EXISTS(
      SELECT *
      FROM "DimBooks"
      WHERE "DimBooks"."Id" = "Books"."Id"
    );
END;

-- Extracts all the campuses from the operational database and loads them into the campuses dimension table if
  -- they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimCampusEtl AS
BEGIN
  INSERT INTO "DimCampus"
  SELECT "Id",
         "Name"
  FROM "Campus"
  WHERE NOT EXISTS(
      SELECT *
      FROM "DimCampus"
      WHERE "DimCampus"."Id" = "Campus"."Id"
    );
END;

-- Loads the classifications into the classifications dimension table if they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimClassificationsEtl AS
  noOfClassifications NUMBER;
BEGIN
  SELECT COUNT("Id")
         INTO noOfClassifications
  FROM "DimClassifications";

  IF noOfClassifications = 0 THEN
    INSERT INTO "DimClassifications"
    ("Classification")
    VALUES
    ('U');

    INSERT INTO "DimClassifications"
    ("Classification")
    VALUES
    ('3');

    INSERT INTO "DimClassifications"
    ("Classification")
    VALUES
    ('2.2');

    INSERT INTO "DimClassifications"
    ("Classification")
    VALUES
    ('2.1');

    INSERT INTO "DimClassifications"
    ("Classification")
    VALUES
    ('1');
  END IF;
END;

-- Extracts all the courses from the operational database and loads them into the courses dimension table if
  -- they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimCoursesEtl AS
BEGIN
  INSERT INTO "DimCourses"
  SELECT "Id",
         "Name"
  FROM "Courses"
  WHERE NOT EXISTS(
      SELECT *
      FROM "DimCourses"
      WHERE "DimCourses"."Id" = "Courses"."Id"
    );
END;

-- Extracts all the libraries from the operational database and loads them into the libraries dimension table if
  -- they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimLibrariesEtl AS
BEGIN
  INSERT INTO "DimLibraries"
  SELECT "Id",
         "Name"
  FROM "Libraries"
  WHERE NOT EXISTS(
      SELECT *
      FROM "DimLibraries"
      WHERE "DimLibraries"."Id" = "Libraries"."Id"
    );
END;

-- Extracts all the modules from the operational database and loads them into the modules dimension table if
  -- they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimModulesEtl AS
BEGIN
  INSERT INTO "DimModules"
  SELECT "Id",
         "Code",
         "Title"
  FROM "Modules"
  WHERE NOT EXISTS(
      SELECT *
      FROM "DimModules"
      WHERE "DimModules"."Id" = "Modules"."Id"
    );
END;

-- Extracts all the rooms from the operational database and loads them into the rooms dimension table if
  -- they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimRoomsEtl AS
BEGIN
  INSERT INTO "DimRooms"
  SELECT "Id",
         "Name"
  FROM "Rooms"
  WHERE NOT EXISTS(
      SELECT *
      FROM "DimRooms"
      WHERE "DimRooms"."Id" = "Rooms"."Id"
    );
END;

-- Extracts all the users from the operational database and loads them into the users dimension table if
  -- they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimUsersEtl AS
BEGIN
  INSERT INTO "DimUsers"
  SELECT "Id",
         "FirstName",
         "LastName"
  FROM "Users"
  WHERE NOT EXISTS(
      SELECT *
      FROM "DimUsers"
      WHERE "DimUsers"."Id" = "Users"."Id"
    );
END;

-- Loads the years into the years dimension table if they are not already present in said dimension table.
CREATE OR REPLACE PROCEDURE S1502752.USP_DimYearsEtl AS
  noOfYears NUMBER;
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  SELECT COUNT("Id")
         INTO noOfYears
  FROM "DimYears";

  IF noOfYears = 0 THEN
    INSERT INTO "DimYears"
    ("Year")
    VALUES
    (2015);

    INSERT INTO "DimYears"
    ("Year")
    VALUES
    (2016);

    INSERT INTO "DimYears"
    ("Year")
    VALUES
    (2017);
  END IF;

  SELECT COUNT("Id")
         INTO noOfYears
  FROM "DimYears"
  WHERE "Year" = year;

  IF noOfYears = 0 THEN
    INSERT INTO "DimYears"
    ("Year")
    VALUES
    (year);
  END IF;
END;

-- Extracts all the assignments from the operational database and transforms them into the assignments fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactAssignmentsEtl AS
BEGIN
  INSERT INTO "FactAssignments"
  SELECT "ModuleId",
         UFN_DimYearsGetId("Year"),
         COUNT(DISTINCT "Assignments"."Id")
  FROM "Assignments"
         INNER JOIN "Runs" R
                    ON "Assignments"."RunId" = R."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactAssignments"
      WHERE "FactAssignments"."ModuleId" = R."ModuleId"
        AND "YearId" = UFN_DimYearsGetId("Year")
    )
  GROUP BY UFN_DimYearsGetId("Year"),
           "ModuleId"
  ORDER BY UFN_DimYearsGetId("Year"),
           "ModuleId";
END;

-- Extracts all the books from the operational database and transforms them into the books fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactBooksEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "FactBooks"
  SELECT "LibraryId",
         UFN_DimYearsGetId(year),
         COUNT(DISTINCT "Books"."Id")
  FROM "Books"
         INNER JOIN "LibraryBooks" LB
                    ON "Books"."Id" = LB."BookId"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactBooks"
      WHERE "FactBooks"."LibraryId" = LB."LibraryId"
        AND "YearId" = UFN_DimYearsGetId(year)
    )
  GROUP BY UFN_DimYearsGetId(year),
           "LibraryId"
  ORDER BY UFN_DimYearsGetId(year),
           "LibraryId";
END;

-- Extracts all the graduates from the operational database and transforms them into the graduates fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactGraduatesEtl AS
BEGIN
  INSERT INTO "FactGraduates"
  SELECT "CourseId",
         UFN_DimYearsGetId("Year"),
         COUNT(DISTINCT "Id")
  FROM "Graduations"
  WHERE NOT EXISTS(
      SELECT * FROM "FactGraduates"
      WHERE "FactGraduates"."CourseId" = "Graduations"."CourseId"
        AND "YearId" = UFN_DimYearsGetId("Year")
    )
  GROUP BY UFN_DimYearsGetId("Year"),
           "CourseId"
  ORDER BY UFN_DimYearsGetId("Year"),
           "CourseId";
END;

-- Extracts all the halls from the operational database and transforms them into the halls fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactHallsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "FactHalls"
  SELECT "CampusId",
         UFN_DimYearsGetId(year),
         COUNT(DISTINCT "Id")
  FROM "Halls"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactHalls"
      WHERE "FactHalls"."CampusId" = "Halls"."CampusId"
        AND "YearId" = UFN_DimYearsGetId(year)
    )
  GROUP BY UFN_DimYearsGetId(year),
           "CampusId"
  ORDER BY UFN_DimYearsGetId(year),
           "CampusId";
END;

-- Extracts all the lectures from the operational database and transforms them into the lectures fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactLecturesEtl AS
BEGIN
  INSERT INTO "FactLectures"
  SELECT "ModuleId",
         "RoomId",
         UFN_DimYearsGetId("Year"),
         COUNT(DISTINCT "Lectures"."Id")
  FROM "Lectures"
         INNER JOIN "Runs" R
                    ON "Lectures"."RunId" = R."Id"
         INNER JOIN "Modules" M
                    ON R."ModuleId" = M."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactLectures"
      WHERE "FactLectures"."ModuleId" = R."ModuleId"
        AND "FactLectures"."RoomId" = "Lectures"."RoomId"
        AND "YearId" = UFN_DimYearsGetId("Year")
    )
  GROUP BY UFN_DimYearsGetId("Year"),
           "RoomId",
           "ModuleId"
  ORDER BY UFN_DimYearsGetId("Year"),
           "RoomId",
           "ModuleId";
END;

-- Extracts all the libraries from the operational database and transforms them into the libraries fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactLibrariesEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "FactLibraries"
  SELECT "CampusId",
         UFN_DimYearsGetId(year),
         COUNT(DISTINCT "Id")
  FROM "Halls"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactLibraries"
      WHERE "FactLibraries"."CampusId" = "Halls"."CampusId"
        AND "YearId" = UFN_DimYearsGetId(year)
    )
  GROUP BY UFN_DimYearsGetId(year),
           "CampusId"
  ORDER BY UFN_DimYearsGetId(year),
           "CampusId";
END;

-- Extracts all the modules from the operational database and transforms them into the modules fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactModulesEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "FactModules"
  SELECT "CourseId",
         UFN_DimYearsGetId(year),
         COUNT(DISTINCT "Id")
  FROM "Modules"
         INNER JOIN "CourseModules" CM
                    ON "Modules"."Id" = CM."ModuleId"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactModules"
      WHERE "FactModules"."CourseId" = CM."CourseId"
        AND "YearId" = UFN_DimYearsGetId(year)
    )
  GROUP BY UFN_DimYearsGetId(year),
           "CourseId"
  ORDER BY UFN_DimYearsGetId(year),
           "CourseId";
END;

-- Extracts all the rentals from the operational database and transforms them into the rentals fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactRentalsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "FactRentals"
  SELECT "UserId",
         "BookId",
         UFN_DimYearsGetId(year),
         COUNT(DISTINCT "Id")
  FROM "Rentals"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactRentals"
      WHERE "FactRentals"."UserId" = "Rentals"."UserId"
        AND "FactRentals"."BookId" = "Rentals"."BookId"
        AND "YearId" = UFN_DimYearsGetId(year)
    )
  GROUP BY UFN_DimYearsGetId(year),
           "BookId",
           "UserId"
  ORDER BY UFN_DimYearsGetId(year),
           "BookId",
           "UserId";
END;

-- Extracts all the rooms from the operational database and transforms them into the rooms fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactRoomsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "FactRooms"
  SELECT "CampusId",
         UFN_DimYearsGetId(year),
         COUNT(DISTINCT "Id")
  FROM "Rooms"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactRooms"
      WHERE "FactRooms"."CampusId" = "Rooms"."CampusId"
        AND "YearId" = UFN_DimYearsGetId(year)
    )
  GROUP BY UFN_DimYearsGetId(year),
           "CampusId"
  ORDER BY UFN_DimYearsGetId(year),
           "CampusId";
END;

-- Extracts all the students from the operational database and transforms them into the students fact table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_FactStudentsEtl AS
BEGIN
  INSERT INTO "FactStudents"
  SELECT "ModuleId",
         UFN_ResultsGetClassification("Users"."Id", R1."ModuleId"),
         UFN_DimYearsGetId(R1."Year"),
         COUNT("Users"."Id")
  FROM "Users"
         INNER JOIN "Enrolments" E
                    ON "Users"."Id" = E."UserId"
         INNER JOIN "Runs" R1
                    ON E."RunId" = R1."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "FactStudents"
      WHERE "FactStudents"."ModuleId" = R1."ModuleId"
        AND "ClassificationId" = UFN_ResultsGetClassification("Users"."Id", R1."ModuleId")
        AND "YearId" = UFN_DimYearsGetId(R1."Year")
    )
  GROUP BY UFN_DimYearsGetId(R1."Year"),
           UFN_ResultsGetClassification("Users"."Id", R1."ModuleId"),
           "ModuleId"
  ORDER BY UFN_DimYearsGetId(R1."Year"),
           UFN_ResultsGetClassification("Users"."Id", R1."ModuleId"),
           "ModuleId";
END;

CREATE OR REPLACE PROCEDURE S1502752.USP_Etl AS
BEGIN
  USP_DimBooksEtl();
  USP_DimCampusEtl();
  USP_DimClassificationsEtl();
  USP_DimCoursesEtl();
  USP_DimLibrariesEtl();
  USP_DimModulesEtl();
  USP_DimRoomsEtl();
  USP_DimUsersEtl();
  USP_DimYearsEtl();

  USP_FactAssignmentsEtl();
  USP_FactBooksEtl();
  USP_FactGraduatesEtl();
  USP_FactHallsEtl();
  USP_FactLecturesEtl();
  USP_FactLibrariesEtl();
  USP_FactModulesEtl();
  USP_FactRentalsEtl();
  USP_FactRoomsEtl();
  USP_FactStudentsEtl();
END;
