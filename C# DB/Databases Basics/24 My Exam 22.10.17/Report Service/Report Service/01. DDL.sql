CREATE TABLE Departments(
Id INT IDENTITY(1, 1),
[Name] NVARCHAR(50) NOT NULL,
CONSTRAINT PK_Departments PRIMARY KEY(Id)
)

CREATE TABLE Users(
Id INT IDENTITY(1, 1),
Username NVARCHAR(30) UNIQUE NOT NULL,
[Password] NVARCHAR(50) NOT NULL,
[Name] NVARCHAR(50),
Gender CHAR(1) CHECK(Gender IN('M', 'F')),
BirthDate DATETIME,
Age INT,
Email NVARCHAR(50) NOT NULL
CONSTRAINT PK_Users PRIMARY KEY(Id)
)

CREATE TABLE Status(
Id INT IDENTITY(1, 1),
Label VARCHAR(30) NOT NULL,
CONSTRAINT PK_Status PRIMARY KEY(Id)
)

CREATE TABLE Categories(
Id INT IDENTITY(1, 1),
[Name] VARCHAR(50) NOT NULL,
DepartmentId INT,
CONSTRAINT PK_Categories PRIMARY KEY(Id),
CONSTRAINT FK_Categories FOREIGN KEY(DepartmentId) REFERENCES Departments(Id)
)

CREATE TABLE Employees(
Id INT IDENTITY(1, 1),
FirstName NVARCHAR(25),
LastName NVARCHAR(25),
Gender CHAR(1) CHECK(Gender IN('M', 'F')),
BirthDate DATETIME,
Age INT,
DepartmentId INT NOT NULL,
CONSTRAINT PK_Employees PRIMARY KEY(Id),
CONSTRAINT FK_Employees FOREIGN KEY(DepartmentId) REFERENCES Departments(Id)
)

CREATE TABLE Reports(
Id INT IDENTITY(1, 1),
CategoryId INT NOT NULL,
StatusId INT NOT NULL,
OpenDate DATETIME NOT NULL,
CloseDate DATETIME,
Description VARCHAR(200),
UserId INT NOT NULL,
EmployeeId INT,
CONSTRAINT PK_Reports PRIMARY KEY(Id),
CONSTRAINT FK_RepCategory FOREIGN KEY(CategoryId) REFERENCES Categories(Id),
CONSTRAINT FK_RepStatus FOREIGN KEY(StatusId) REFERENCES Status(Id),
CONSTRAINT FK_RepUsers FOREIGN KEY(UserId) REFERENCES Users(Id),
CONSTRAINT FK_RepEmpl FOREIGN KEY(EmployeeId) REFERENCES Employees(Id)
)