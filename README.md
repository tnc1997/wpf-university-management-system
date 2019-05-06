# University Management System

## Usage

### Step 1

Download and install [Visual Studio][visual-studio].

#### Workloads

* .NET Desktop Development

### Step 2

[Clone][clone] this repository to your computer.

### Step 3

Open a connection to your Oracle database.

### Step 4

Run the SQL script: UniversityManagementSystem.Data\build.sql.

### Step 5

Run the SQL script: UniversityManagementSystem.Data\etl.sql.

### Step 6

Open the Solution in Visual Studio.

### Step 7

Create a connection strings file: UniversityManagementSystem.Apps.Wpf\ConnectionStrings.config.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<connectionStrings>
    <add name="Default" providerName="Oracle.ManagedDataAccess.Client" connectionString="Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=[INSERT HOST HERE])(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));Persist Security Info=True;User ID=[INSERT USERNAME HERE];Password=[INSERT PASSWORD HERE]" />
</connectionStrings> 
```

### Step 8:

Build the Solution in Visual Studio.

[clone]: https://github.com/tnc1997/uwp-student-records
[visual-studio]: https://visualstudio.microsoft.com
