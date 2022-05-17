--Ans2 
select DATEDIFF(dd,'1998/10/28','2022/05/30') AS DOB_NO_OF_DAYS


--Ans 3
create table EMP8

(Empid int primary key,EName varchar(45) not null,Salary int ,Deptno int)

INSERT INTO EMP8
values(101,'Vajra',1000,10),
(102,'Ugra',30000,20),
(103,'Rio',10000,30)