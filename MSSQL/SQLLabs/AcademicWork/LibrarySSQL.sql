Use AcademyDB
create database AcademyDB


Create Table Students
(
Id int IDENTITY primary key,
FirstName NVARCHAR(33),
LastName NVARCHAR(33),
DateOfBirth DATE,
Username NVARCHAR(33),
Password NVARCHAR(33),
EnrollmentDate DATE
)

create table Departments
(
Id int identity primary key,
DepartmentName nvarchar(33)
)

create table Instructors 
(
Id int identity primary key,
FirstName nvarchar(33),
LastName nvarchar(33),
HireDate date,
DepartmentId int,
Username nvarchar(33),
[Password] nvarchar(33),
PIN nvarchar(33),
foreign key (DepartmentId) references Departments(Id)
)

create table [Group]
(
Id int identity primary key,
GroupName nvarchar(33),
DepartmentId int,
StartDate date,
EndDate date
foreign key (DepartmentId) references Departments(Id)
)

create table Encrollments
(
Id int identity primary key,
GroupId int,
StudentId int,
foreign key (StudentId) references Students(Id),
foreign key (GroupId) references [Group](Id)
)

create table Classes
(
Id int identity primary key,
GroupId int,
InstructorId int,
Schedule nvarchar(33),
RoomName nvarchar(33)
Foreign key (GroupId) references [Group](Id),
Foreign key (InstructorId) references Instructors(Id)
)


create procedure InsertStudents
@FirstName nvarchar(33),
@LastName nvarchar(33),
@DateOfBird date,
@UserName nvarchar(33),
@Password nvarchar(33),
@EncrollmentDate date
as
begin
insert into Students (FirstName,LastName,DateOfBirth,Username,[Password],EnrollmentDate)
Values (@FirstName,@LastName,@DateOfBird,@UserName,@Password,@EncrollmentDate)
end

exec InsertStudents
@FirstName = 'Tyson',
@LastName = 'Mike',
@DateOfBird = '01.01.2001',
@UserName = 'nbaty',
@Password ='ab205',
@EncrollmentDate='01.01.2024'

select Students.Id,Students.FirstName,Students.LastName,[Group].GroupName,Classes.Schedule,Classes.RoomName
from Students
inner join Encrollments on StudentId = Encrollments.StudentId
inner join [Group] on Encrollments.GroupId = [Group].Id

create function GetScheduleByStudentID (@id int)
returns table
as
return 
(
    select s.Id as [Student Id],
	s.FirstName + ' ' + s.LastName as [Student Fullname]  ,
	g.GroupName as [Group Name],
	ct.Schedule as Schedule,
	ct.RoomName as [Room Name]
	
	from 
        students as s
    inner join 
        Encrollments as e on s.id = e.Studentid
    inner join 
        [Group] as g on e.GroupId = g.Id
    inner join 
        Classes as ct on ct.GroupId = g.Id
    where 
        s.id = @id
)
/*students.id as StudentID,
        students.firstname as StudentFirstName,
        students.lastname as StudentLastName,
        [group].groupname,
        Classestable.Schedule,
        Classestable.Roomname*/
		select * from GetScheduleByStudentID(1)
		select * from Students;
