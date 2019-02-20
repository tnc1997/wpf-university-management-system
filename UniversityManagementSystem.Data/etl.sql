-- FUNCTIONS

-- Gets the id of the classification dimension which corresponds to a classification.
CREATE OR REPLACE FUNCTION S1502752.UFN_ClassificationDimsGetId(classification IN NVARCHAR2) RETURN NUMBER AS
  id NUMBER;
BEGIN
  SELECT "Id"
         INTO id
  FROM "ClassificationDims"
  WHERE "Classification" = classification;

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
CREATE OR REPLACE FUNCTION S1502752.UFN_ResultsGetAverageGrade(userId NUMBER, moduleId NUMBER) RETURN NUMBER AS
  averageGrade NUMBER;
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

-- Gets the id of the year dimension which corresponds to a year.
CREATE OR REPLACE FUNCTION S1502752.UFN_YearDimsGetId(year IN NUMBER) RETURN NUMBER AS
  id NUMBER;
BEGIN
  SELECT "Id"
         INTO id
  FROM "YearDims"
  WHERE "Year" = year;

  RETURN id;
END;

-- PROCEDURES

-- Extracts all the books from the operational database and loads them into the book dimensions table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_BookDimsEtl AS
BEGIN
  INSERT INTO "BookDims"
  SELECT "Id",
         "Name",
         "Author"
  FROM "Books"
  WHERE NOT EXISTS(
      SELECT *
      FROM "BookDims"
      WHERE "BookDims"."Id" = "Books"."Id"
    );
END;

-- Extracts all the campuses from the operational database and loads them into the campus dimensions table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_CampusDimsEtl AS
BEGIN
  INSERT INTO "CampusDims"
  SELECT "Id",
         "Name"
  FROM "Campus"
  WHERE NOT EXISTS(
      SELECT *
      FROM "CampusDims"
      WHERE "CampusDims"."Id" = "Campus"."Id"
    );
END;

-- Loads the classifications into the classification dimensions table if they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_ClassificationDimsEtl AS
  noOfClassifications NUMBER;
BEGIN
  SELECT COUNT("Id")
         INTO noOfClassifications
  FROM "ClassificationDims";

  IF noOfClassifications = 0 THEN
    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('U');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('3');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('2.2');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('2.1');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('1');
  END IF;
END;

-- Extracts all the courses from the operational database and loads them into the course dimensions table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_CourseDimsEtl AS
BEGIN
  INSERT INTO "CourseDims"
  SELECT "Id",
         "Name"
  FROM "Courses"
  WHERE NOT EXISTS(
      SELECT *
      FROM "CourseDims"
      WHERE "CourseDims"."Id" = "Courses"."Id"
    );
END;

-- Extracts all the libraries from the operational database and loads them into the library dimensions table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_LibraryDimsEtl AS
BEGIN
  INSERT INTO "LibraryDims"
  SELECT "Id",
         "Name"
  FROM "Libraries"
  WHERE NOT EXISTS(
      SELECT *
      FROM "LibraryDims"
      WHERE "LibraryDims"."Id" = "Libraries"."Id"
    );
END;

-- Extracts all the modules from the operational database and loads them into the module dimensions table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_ModuleDimsEtl AS
BEGIN
  INSERT INTO "ModuleDims"
  SELECT "Id",
         "Code",
         "Title"
  FROM "Modules"
  WHERE NOT EXISTS(
      SELECT *
      FROM "ModuleDims"
      WHERE "ModuleDims"."Id" = "Modules"."Id"
    );
END;

-- Extracts all the rooms from the operational database and loads them into the room dimensions table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_RoomDimsEtl AS
BEGIN
  INSERT INTO "RoomDims"
  SELECT "Id",
         "Name"
  FROM "Rooms"
  WHERE NOT EXISTS(
      SELECT *
      FROM "RoomDims"
      WHERE "RoomDims"."Id" = "Rooms"."Id"
    );
END;

-- Extracts all the users from the operational database and loads them into the user dimensions table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_UserDimsEtl AS
BEGIN
  INSERT INTO "UserDims"
  SELECT "Id",
         "FirstName",
         "LastName"
  FROM "Users"
  WHERE NOT EXISTS(
      SELECT *
      FROM "UserDims"
      WHERE "UserDims"."Id" = "Users"."Id"
    );
END;

-- Loads the years into the year dimensions table if they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_YearDimsEtl AS
  noOfYears NUMBER;
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  SELECT COUNT("Id")
         INTO noOfYears
  FROM "YearDims";

  IF noOfYears = 0 THEN
    INSERT INTO "YearDims"
    ("Year")
    VALUES
    (2015);

    INSERT INTO "YearDims"
    ("Year")
    VALUES
    (2016);

    INSERT INTO "YearDims"
    ("Year")
    VALUES
    (2017);
  END IF;

  SELECT COUNT("Id")
         INTO noOfYears
  FROM "YearDims"
  WHERE "Year" = year;

  IF noOfYears = 0 THEN
    INSERT INTO "YearDims"
    ("Year")
    VALUES
    (year);
  END IF;
END;

-- Extracts all the assignments from the operational database and transforms them into the assignment facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_AssignmentFactsEtl AS
BEGIN
  INSERT INTO "AssignmentFacts"
  SELECT "ModuleId",
         UFN_YearDimsGetId("Year"),
         COUNT("Assignments"."Id")
  FROM "Assignments"
         INNER JOIN "Runs" R
                    ON "Assignments"."RunId" = R."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "AssignmentFacts"
      WHERE "ModuleDimId" = "ModuleId"
        AND "YearDimId" = UFN_YearDimsGetId("Year")
    )
  GROUP BY UFN_YearDimsGetId("Year"),
           "ModuleId"
  ORDER BY UFN_YearDimsGetId("Year"),
           "ModuleId";
END;

-- Extracts all the books from the operational database and transforms them into the book facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_BookFactsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "BookFacts"
  SELECT "LibraryId",
         UFN_YearDimsGetId(year),
         COUNT("Books"."Id")
  FROM "Books"
         INNER JOIN "LibraryBooks" LB
                    ON "Books"."Id" = LB."BookId"
  WHERE NOT EXISTS(
      SELECT *
      FROM "BookFacts"
      WHERE "LibraryDimId" = "LibraryId"
        AND "YearDimId" = UFN_YearDimsGetId(year)
    )
  GROUP BY UFN_YearDimsGetId(year),
           "LibraryId"
  ORDER BY UFN_YearDimsGetId(year),
           "LibraryId";
END;

-- Extracts all the graduations from the operational database and transforms them into the graduation facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_GraduationFactsEtl AS
BEGIN
  INSERT INTO "GraduationFacts"
  SELECT "CourseId",
         UFN_YearDimsGetId("Year"),
         COUNT("Id")
  FROM "Graduations"
  WHERE NOT EXISTS(
      SELECT * FROM "GraduationFacts"
      WHERE "CourseDimId" = "CourseId"
        AND "YearDimId" = UFN_YearDimsGetId("Year")
    )
  GROUP BY UFN_YearDimsGetId("Year"),
           "CourseId"
  ORDER BY UFN_YearDimsGetId("Year"),
           "CourseId";
END;

-- Extracts all the halls from the operational database and transforms them into the hall facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_HallFactsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "HallFacts"
  SELECT "CampusId",
         UFN_YearDimsGetId(year),
         COUNT("Id")
  FROM "Halls"
  WHERE NOT EXISTS(
      SELECT *
      FROM "HallFacts"
      WHERE "CampusDimId" = "CampusId"
        AND "YearDimId" = UFN_YearDimsGetId(year)
    )
  GROUP BY UFN_YearDimsGetId(year),
           "CampusId"
  ORDER BY UFN_YearDimsGetId(year),
           "CampusId";
END;

-- Extracts all the lectures from the operational database and transforms them into the lecture facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_LectureFactsEtl AS
BEGIN
  INSERT INTO "LectureFacts"
  SELECT "ModuleId",
         "RoomId",
         UFN_YearDimsGetId("Year"),
         COUNT("Lectures"."Id")
  FROM "Lectures"
         INNER JOIN "Runs" R
                    ON "Lectures"."RunId" = R."Id"
         INNER JOIN "Modules" M
                    ON R."ModuleId" = M."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "LectureFacts"
      WHERE "ModuleDimId" = "ModuleId"
        AND "RoomDimId" = "RoomId"
        AND "YearDimId" = UFN_YearDimsGetId("Year")
    )
  GROUP BY UFN_YearDimsGetId("Year"),
           "RoomId",
           "ModuleId"
  ORDER BY UFN_YearDimsGetId("Year"),
           "RoomId",
           "ModuleId";
END;

-- Extracts all the libraries from the operational database and transforms them into the library facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_LibraryFactsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "LibraryFacts"
  SELECT "CampusId",
         UFN_YearDimsGetId(year),
         COUNT("Id")
  FROM "Libraries"
  WHERE NOT EXISTS(
      SELECT *
      FROM "LibraryFacts"
      WHERE "CampusDimId" = "CampusId"
        AND "YearDimId" = UFN_YearDimsGetId(year)
    )
  GROUP BY UFN_YearDimsGetId(year),
           "CampusId"
  ORDER BY UFN_YearDimsGetId(year),
           "CampusId";
END;

-- Extracts all the modules from the operational database and transforms them into the module facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_ModuleFactsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "ModuleFacts"
  SELECT "CourseId",
         UFN_YearDimsGetId(year),
         COUNT("Id")
  FROM "Modules"
         INNER JOIN "CourseModules" CM
                    ON "Modules"."Id" = CM."ModuleId"
  WHERE NOT EXISTS(
      SELECT *
      FROM "ModuleFacts"
      WHERE "CourseDimId" = "CourseId"
        AND "YearDimId" = UFN_YearDimsGetId(year)
    )
  GROUP BY UFN_YearDimsGetId(year),
           "CourseId"
  ORDER BY UFN_YearDimsGetId(year),
           "CourseId";
END;

-- Extracts all the rentals from the operational database and transforms them into the rental facts table if
  -- they are not already present in said table.
CREATE OR REPLACE PROCEDURE S1502752.USP_RentalFactsEtl AS
BEGIN
  INSERT INTO "RentalFacts"
  SELECT "UserId",
         "BookId",
         UFN_YearDimsGetId(UFN_GetAcademicYearFromDate("CheckoutDate")),
         COUNT("Id")
  FROM "Rentals"
  WHERE NOT EXISTS(
      SELECT *
      FROM "RentalFacts"
      WHERE "UserDimId" = "UserId"
        AND "BookDimId" = "BookId"
        AND "YearDimId" = UFN_YearDimsGetId(UFN_GetAcademicYearFromDate("CheckoutDate"))
    )
  GROUP BY UFN_YearDimsGetId(UFN_GetAcademicYearFromDate("CheckoutDate")),
           "BookId",
           "UserId"
  ORDER BY UFN_YearDimsGetId(UFN_GetAcademicYearFromDate("CheckoutDate")),
           "BookId",
           "UserId";
END;

-- Extracts all the rooms from the operational database and transforms them into the room facts table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_RoomFactsEtl AS
  year NUMBER := UFN_GetAcademicYear();
BEGIN
  INSERT INTO "RoomFacts"
  SELECT "CampusId",
         UFN_YearDimsGetId(year),
         COUNT("Id")
  FROM "Rooms"
  WHERE NOT EXISTS(
      SELECT *
      FROM "RoomFacts"
      WHERE "CampusDimId" = "CampusId"
        AND "YearDimId" = UFN_YearDimsGetId(year)
    )
  GROUP BY UFN_YearDimsGetId(year),
           "CampusId"
  ORDER BY UFN_YearDimsGetId(year),
           "CampusId";
END;

-- Extracts all the students from the operational database and transforms them into the student facts table if
  -- they are not already present in said fact table.
CREATE OR REPLACE PROCEDURE S1502752.USP_StudentFactsEtl AS
BEGIN
  INSERT INTO "StudentFacts"
  SELECT "ModuleId",
         UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(Grade)),
         UFN_YearDimsGetId("Year"),
         COUNT("UserId")
  FROM (
         SELECT "ModuleId",
                "UserId",
                "Year",
                AVG("Grade") Grade
         FROM "Results"
                INNER JOIN "Assignments" A
                           ON "Results"."AssignmentId" = A."Id"
                INNER JOIN "Runs" R
                           ON A."RunId" = R."Id"
         GROUP BY "Year",
                  "UserId",
                  "ModuleId"
         ORDER BY "Year",
                  "UserId",
                  "ModuleId"
       )
  WHERE NOT EXISTS(
      SELECT *
      FROM "StudentFacts"
      WHERE "ModuleDimId" = "ModuleId"
        AND "ClassificationDimId" = UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(Grade))
        AND "YearDimId" = UFN_YearDimsGetId("Year")
    )
  GROUP BY UFN_YearDimsGetId("Year"),
           UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(Grade)),
           "ModuleId"
  ORDER BY UFN_YearDimsGetId("Year"),
           UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(Grade)),
           "ModuleId";
END;

CREATE OR REPLACE PROCEDURE S1502752.USP_Etl AS
BEGIN
  USP_BookDimsEtl();
  USP_CampusDimsEtl();
  USP_ClassificationDimsEtl();
  USP_CourseDimsEtl();
  USP_LibraryDimsEtl();
  USP_ModuleDimsEtl();
  USP_RoomDimsEtl();
  USP_UserDimsEtl();
  USP_YearDimsEtl();

  USP_AssignmentFactsEtl();
  USP_BookFactsEtl();
  USP_GraduationFactsEtl();
  USP_HallFactsEtl();
  USP_LectureFactsEtl();
  USP_LibraryFactsEtl();
  USP_ModuleFactsEtl();
  USP_RentalFactsEtl();
  USP_RoomFactsEtl();
  USP_StudentFactsEtl();
END;
