use AssignmentDB

--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
SELECT ENAME,SAL
FROM EMP
WHERE SAL >1500 AND SAL<2850

--2. Display the name and job of all employees who do not have a MANAGER.
SELECT ENAME,JOB 
FROM EMP
WHERE MGR IS NULL

--3. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST 
--and their salary is not equal to 1000, 3000, or 5000. 
SELECT ENAME, JOB, SAL
FROM EMP
WHERE JOB IN ('MANAGER','ANALYST') AND SAL NOT IN(1000,3000,5000)

--4. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
SELECT ENAME, SAL+SAL*10/100 AS "Salary Increased By 10%", COMM
FROM EMP
WHERE COMM>SAL

--5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
SELECT ENAME 
FROM EMP
WHERE ENAME LIKE '%LL%' AND DEPTNO=30 OR MGR=7782

--6. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees
UPDATE EMP SET HIREDATE = '28-SEP-10' WHERE EMPNO IN (7654, 7900)

SELECT COUNT (HIREDATE) AS NO_OF_EMPLOYEES, ENAME
FROM EMP
WHERE CONVERT(varchar(3), DATEDIFF(YEAR, HIREDATE, GETDATE()))>10
AND CONVERT(VARCHAR(3), DATEDIFF(YEAR, HIREDATE, GETDATE()))<20
GROUP BY ENAME

--7. Retrieve the names of departments in ascending order and their employees in descending order.
SELECT DNAME ,ENAME
FROM DEPT JOIN EMP ON DEPT.DEPTNO = EMP.DEPTNO
ORDER BY DNAME, ENAME DESC

--8. Find out experience of MILLER.
Declare @HIREDATE datetime  
Declare @currentdate datetime  
Declare @years varchar(4)  
set @HIREDATE = '1982-01-23'  
set @currentdate  = getdate()
select @years = datediff(YEAR,@HIREDATE,@currentdate)  
select @years + ' YEAR,' AS YEARS 

--9. How many different departments are there in the employee table. 
SELECT COUNT(*) AS "DIFFERENT DEPT COUNT",DEPTNO
FROM EMP
GROUP BY DEPTNO 

--10. Find out which employee either work in SALES or RESEARCH department. 
SELECT ENAME, DEPT.DNAME 
FROM EMP JOIN DEPT ON DEPT.DEPTNO = EMP.DEPTNO
WHERE DNAME IN ('SALES','RESEARCH')

--11. Print the name and average salary of each department.
SELECT DNAME, AVG(SAL) AS AVERAGE_SALARY 
FROM EMP JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO
GROUP BY DNAME;

--12. Select the minimum and maximum salary from employee table. 
SELECT MAX(SAL) AS "MAX SAL" , MIN(SAL) AS "MIN SAL"
FROM EMP

--13. Select the minimum and maximum salaries from each department in employee table.
SELECT MAX(SAL) AS "MAX SAL" , MIN(SAL) AS "MIN SAL", DNAME
FROM EMP JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO
GROUP BY DNAME

--14. Select the details of employees whose salary is below 1000 and job is CLERK.
SELECT *
FROM EMP
WHERE SAL<1000 AND JOB ='CLERK'