create database EmployeeManagment
use EmployeeManagment




create table Code_Employee(
empno int primary key,
empname varchar(50) not null,
empsal numeric(10,2) check (empsal>=25000),
emptype varchar(1) check(emptype in('C','P')))



insert into Code_Employee values
(1,'Rio',30000,'P'),
(2,'Ruby', 40000,'C')



select * from Code_Employee



create or alter procedure AddNewRecord @ename varchar(50), @esal numeric(10,2), @etype varchar(1)
as
begin
declare @eid int = (select max(empno) from Code_Employee)
begin
declare @empid int = @eid + 1;
insert into Code_Employee values(@empid, @ename, @esal, @etype)
end
end