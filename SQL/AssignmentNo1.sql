create database AssignmentDB
create table DEPT
(
DEPTNO int primary key,
DNAME varchar(20)not null,
LOC varchar(15)
)
select * from DEPT
insert into DEPT values (10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'), (30 ,'SALES','CHICAGO' ),
(40,'OPERATIONS','BOSTON' )
create table EMP
(
EMPNO int primary key,
ENAME varchar(30) not null,
JOB varchar(15),
MGR int,
HIREDATE DATE,
SAL float,
COMM float,
DEPTNO int foreign key references DEPT(DEPTNO) -- relatating fk with pk
)
select * from EMP
insert into EMP values
(7369, 'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20),
(7499,'ALLEN' ,'SALESMAN',7698,'20-FEB-81',1600 ,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,NULL,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,NULL,30),
(7782,'CLARK' ,'MANAGER',7839,'09-JUN-81',2450,NULL,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,NULL,20),
(7839,'KING' ,'PRESIDENT',NULL ,'17-NOV-81' ,5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,NULL,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,NULL,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,NULL,20),
(7934,'MILLER','CLERK',7782 ,'23-JAN-82',1300,NULL,10)

--1. List all employees whose name begins with 'A'.
SELECT * FROM EMP
WHERE ENAME LIKE 'A%'

--2. Select all those employees who don't have a manager.
SELECT *
FROM EMP
WHERE MGR IS NULL

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400.
SELECT ENAME,EMPNO,SAL
FROM EMP
WHERE SAL BETWEEN 1201 AND 1399

--4.Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
SELECT SAL, SAL+SAL*10/100 AS "10% PAYRISE"
FROM EMP
WHERE DEPTNO IN (SELECT DEPTNO
FROM DEPT
WHERE DNAME='RESEARCH')

--5. Find the number of CLERKS employed. Give it a descriptive heading.
SELECT COUNT(*) AS " NUMBER OF CLERKS"
FROM EMP
WHERE JOB='CLERK'

--6. Find the average salary for each job type and the number of people employed in each job.
SELECT AVG(SAL) AS "AVG SAL",COUNT(*) AS "Number Of People Employed In Each Job"
FROM EMP
GROUP BY JOB

--7. List the employees with the lowest and highest salary.
SELECT MAX(SAL) AS "MAX SAL" ,MIN(SAL) AS "MIN SAL"
FROM EMP

--8. List full details of departments that don't have any employees.
SELECT * FROM DEPT
WHERE DEPTNO
NOT IN (SELECT DEPTNO FROM EMP);

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name.

SELECT ENAME,SAL
FROM EMP
WHERE JOB ='ANALYST' AND DEPTNO=20
ORDER BY ENAME ASC

--10. For each department, list its name and number together with the total salary paid to employees in that department.
SELECT JOB ,DEPTNO, SUM(SAL) AS "TOTAL SAL"
FROM EMP
GROUP BY JOB,DEPTNO

--11. Find out salary of both MILLER and SMITH.
SELECT SAL
FROM EMP
WHERE ENAME IN('MILLER','SMITH')

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
SELECT ENAME
FROM EMP
WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%'

--13. Compute yearly salary of SMITH.
SELECT SAL*12 AS "YEAR SAL"
FROM EMP
WHERE ENAME='SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
SELECT ENAME ,SAL
FROM EMP
WHERE SAL BETWEEN 1500 AND 2850
