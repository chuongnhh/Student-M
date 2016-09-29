create database Student
go
use Student
go

--===========================

create table Student(
	StudentID nvarchar(10) primary key,
	StudentName nvarchar(100),
	Gender nvarchar(5),
	BirthDay date,
	PhoneNumber nvarchar(20),
	Email nvarchar(100),
	Address nvarchar(250),
	Staying nvarchar(250),
	Education nvarchar(250),
	University nvarchar(250),
	Avatar image,
	Status bit
)
go

create table Major(
	MajorID nvarchar(10) primary key,
	MajorName nvarchar(100)
)
go

create table Employee(
	EmployeeID nvarchar(10) primary key,
	EmployeeName nvarchar(100),
	Gender nvarchar(5),
	BirthDay date,
	PhoneNumber nvarchar(20),
	Email nvarchar(100),
	Address nvarchar(250),
	Staying nvarchar(250),
	Education nvarchar(250),
	University nvarchar(250),
	Avatar image,
	Status bit,

	MajorID nvarchar(10),

	foreign key(MajorID) references Major(MajorID)
)
go


create table Level(
	LevelID nvarchar(10) primary key,
	LevelName nvarchar(100)
)
go


create table Course(
	CourseID nvarchar(10) primary key,
	CourseName nvarchar(100),
	Time time, 
	Opening date,
	Closing date,
	
	Schedule nvarchar(100),
	Tuition money,
	Status bit,

	LevelID nvarchar(10),
	EmployeeID nvarchar(10),

	Number int,
	Room nvarchar(100),

	foreign key(LevelID) references Level(LevelID),
	foreign key(EmployeeID) references Employee(EmployeeID)
)
go

create table Register(
	StudentID nvarchar(10),
	CourseID nvarchar(10),
	Date date,
	Exemption money,
	Total money,
	Payment money,
	Debt money,
	Note nvarchar(MAX),

	primary key (CourseID,StudentID),
	foreign key(CourseID) references Course(CourseID),
	foreign key(StudentID) references Student(StudentID)
)
go

create table Receipt(
	ReceiptID nvarchar(10) primary key,
	StudentID nvarchar(10),
	CourseID nvarchar(10),
	EmployeeID nvarchar(10),
	Payment money,
	Date date,
	foreign key(CourseID,StudentID) references Register(CourseID,StudentID),
	foreign key(EmployeeID) references Employee(EmployeeID)
)
go

create table Transcript(
	TranscriptID int identity,
	StudentID nvarchar(10),
	CourseID nvarchar(10),
	TestDate datetime,
	Score float,
	Note nvarchar(MAX),
	primary key (CourseID,StudentID,TranscriptID),
	foreign key(CourseID) references Course(CourseID),
	foreign key(StudentID) references Student(StudentID),
	foreign key(CourseID,StudentID) references Register(CourseID,StudentID)
)
go

create table Attendance(
	AttendanceID int identity,
	StudentID nvarchar(10),
	CourseID nvarchar(10),
	Date date,
	Absent bit,

	Note nvarchar(MAX),
	primary key (CourseID,StudentID,AttendanceID),

	foreign key(CourseID) references Course(CourseID),
	foreign key(StudentID) references Student(StudentID),

	foreign key(CourseID,StudentID) references Register(CourseID,StudentID)
)
go

create table Account(
	Username nvarchar(10) primary key,
	Password nvarchar(100),
	Role int,
	foreign key(Username) references Employee(EmployeeID),
)
go

create table Diary(
	DiaryID int primary key identity,
	EmployeeID nvarchar(10),
	Action nvarchar(100),
	Start datetime,
	Stop datetime,

	foreign key(EmployeeID) references Employee(EmployeeID)
)
go
--insert into Employee values('14110013',N'Nguyễn Hoàng Chương',N'Nam',
--1994/08/29,'01647931390',N'chuongnh@gmail.com',N'Tx Gò Công, Tiền Giang',
--N'14/5 Hữu Nghị, Bình Thọ,Thủ Đức',N'Đại học',N'Đại học Sư Phạm Kỹ ThuậtTP HCM',null)
--go

--insert into Account values('14110013','1411',0)
--go
