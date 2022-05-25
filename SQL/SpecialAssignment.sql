create database SpecialAssignmentDB
use SpecialAssignmentDB

--Creating Client Table
create table Clients
(Client_ID int primary Key,Cname nvarchar(40) not null,
Addres nvarchar(30),Email nvarchar(30) unique,phoneNo bigint,
Business nvarchar(20) not null)

--inserting values to clients table
insert into Clients
values(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),
(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional')

select*from Clients

--create Employees table
create table Employees
(EmpNo int primary key,Ename varchar(20) not null,job varchar(15),
salary float check(salary>0),
DeptNo int foreign key references Departments(DeptNo))

--inserting values into Employees table
insert into Employees
values
(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech.Writer',30000,40),
(7008,'Priya','Tester',35000,30),
(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),
(7011,'Anand','Project Mgr',65000,10)

select *from Employees

-- Creating Department table
create table Departments
(DeptNo int primary key, Dname varchar(20) not null,Loc varchar(20))

--inserting values into departments table
insert into Departments
values(10,'Design','Pune'),
(20,'Development','pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai')

select* from Departments

-- Creating project tables
create table Project
(Project_ID int primary key,
Descr varchar(30) not null,
Start__Date date,
Planned_End_Date date,
Actual_End_Date date, Check(Actual_End_Date>Planned_End_Date),
Budget bigint, Check(Budget>0),
Client_Id int foreign key references Clients(Client_ID))

-- inserting values into project table
insert into Project
values
(401,'Inventory','01-Apr-11','01-Oct-11','31-Oct-11',150000,1001),
(402,'Accounting','01-Aug-11','01-Jan-12',null, 500000,1002),
(403,'Payroll','01-Oct-11','31-Dec-11',null, 75000,1003),
(404,'Contact Mgmt','01-Nov-11','31-Dec-11',null,50000,1004)

select* from Project

-- create Table to ProjectTasks
create table ProjectTasks
(Project_Id int foreign key references project(project_ID),
Empno int foreign key references Employees(EmpNo),
Start__Date date, End_Date date, Task varchar(25) not null,
Pro_status varchar(15) not null, primary key(Project_ID,Empno))

--inserting values into ProjectTasks
insert into ProjectTasks
values
(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
(401,7002,'21-Apr-11','30-May-11','System Design','Completed'),
(401,7003,'01-Jun-11','15-Jul-11','Coding','Completed'),
(401,7004,'18-Jul-11','01-Sep-11','Coding', 'Completed'),
(401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
(401,7009,'18-Sep-11','05-Oct-11','Code Change','Completed'),
(401,7008,'06-Oct-11','16-Oct-11','Testing','Completed'),
(401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
(401,7011,'22-Oct-11','31-Oct-11','Sign off','Completed'),
(402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
(402,7002,'22-Aug-11','30-Sep-11','System Design','Completed'),
(402,7004,'01-Oct-11',null, 'Coding','In Progress')

select* from ProjectTasks