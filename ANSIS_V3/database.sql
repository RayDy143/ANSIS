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
	UserTypeID int foreign key references UserType(UserTypeID)
)
create table UserType
(
	UserTypeID int identity(1,1) primary key,
	Type varchar(50) not null
)
select * from UserType
delete from UserType
INSERT INTO UserType values('Admin')
INSERT INTO UserType values('Staff')