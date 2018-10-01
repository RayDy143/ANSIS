create database ans
use ans
create table UserAccount
(
	UserAccountID int identity(1,1) primary key,
	Firstname varchar(50) not null,
	Middlename varchar(50),
	Lastname varchar(50) not null,
	Username varchar(50) not null,
	Password varchar(50) not null,
	ContactNumber varchar(50) not null,
	AccessCode varchar(50) not null,
	UserTypeID int foreign key references UserType(UserTypeID)
)
create table Teacher
(
	TeacherID int identity(1,1) primary key,
	Firstname varchar(50) not null,
	Middlename varchar(50),
	Lastname varchar(50) not null,
	ContactNumber varchar(50) not null,
	Status varchar(50) not null,
	SubjectID int foreign key references Subject(SubjectID)
)
create table TimeSchedule
(
	TimeScheduleID int primary key identity(1,1),
	TimeStart varchar(50) not null,
	TimeEnd varchar(50) not null
)
create table UserType
(
	UserTypeID int identity(1,1) primary key,
	Type varchar(50) not null
)
create table Student
(
	StudentID int primary key identity(1,1),
	Firstname varchar(50) not null,
	Middlname varchar(50),
	Lastname varchar(50) not null,
	Birthdate date not null,
	Age int not null,
	Address varchar(max) not null,
	Gender varchar(50) not null,
	ParentName varchar(150) not null,
	ParentNo varchar(50),
	Occupation varchar(50) not null,
	Height decimal(5,2) not null,
	Weight decimal(5,2) not null,
	Systolic int not null,
	Diastolic int not null,
	Form137 varchar(50),
	Form138 varchar(50),
	GoodMoral varchar(50),
	NSO varchar(50),
	YearLevel varchar(50),
	SectionID int foreign key references Section(SectionID),
	SchoolyearID int foreign key references Schoolyear(SchoolyearID)
)
create table Section
(
	SectionID int primary key identity(1,1),
	Section varchar(50) not null,
	Capacity int not null,
	YearLevel varchar(50),
	TeacherID int foreign key references Teacher(TeacherID)
)
create table Schoolyear
(
	SchoolyearID int primary key identity(1,1),
	Year varchar(50) not null
)

create table Subject
(
	SubjectID int primary key identity(1,1),
	Subject varchar(50) not null
)

select * from UserAccount
select * from UserType
select * from Student
delete from UserType
INSERT INTO UserType values('Admin')
INSERT INTO UserType values('Staff')