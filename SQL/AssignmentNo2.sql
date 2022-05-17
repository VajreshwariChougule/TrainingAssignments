use AssignmentDB

--1. Retrieve a list of MANAGERS.
SELECT ENAME
FROM EMP
WHERE EMPNO IN (SELECT MGR
FROM EMP)

--2. Find out salary of both MILLER and SMITH.
SELECT SAL,ENAME
FROM EMP
WHERE ENAME IN ('SMITH','MILLER')

--3. Find out the names and salaries of all employees earning more than 1000 per MONTH
SELECT ENAME,SAL
FROM EMP
WHERE SAL>1000

--4. Display the names and salaries of all employees except JAMES.
SELECT ENAME,SAL
FROM EMP
WHERE ENAME !='JAMES'

--5. Find out the details of employees whose names begin with ‘S’.
SELECT *
FROM EMP
WHERE ENAME LIKE 'S%'

--6. Find out the names of all employees that have ‘A’ anywhere in their name.
SELECT *
FROM EMP
WHERE ENAME LIKE '%A%'

--7. Find out the names of all employees that have ‘L’ as their third character in their name.
SELECT ENAME
FROM EMP
WHERE ENAME LIKE '__L%'

--8. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
SELECT ENAME
FROM EMP
WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%'

--9. Compute yearly salary of SMITH.
SELECT SAL*12 AS "SMITH YEARLY SAL"
FROM EMP
WHERE ENAME = 'SMITH'

--10. Compute daily salary of JONES.
SELECT SAL/30 "JONES DAILY SAL"
FROM EMP
WHERE ENAME='JONES'

--11. Calculate the total monthly salary of all employees.
SELECT SUM(SAL) AS "TOTAL SAL"
FROM EMP

--12. Print the average annual salary.
SELECT AVG(SAL*12) AS "AVG ANNUAL SAL"
FROM EMP

--13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
SELECT ENAME,JOB,SAL,DEPTNO
FROM EMP
WHERE JOB!='SALESMAN' AND DEPTNO=30




--14. List unique departments of the EMP table.
SELECT DEPTNO
FROM EMP
GROUP BY DEPTNO



--15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30.
-- Label the columns Employee and Monthly Salary respectively.
SELECT ENAME AS "EMPLOYEE",SAL AS "MONTHLY SALARY"
FROM EMP
WHERE SAL>1500 AND DEPTNO IN (10,30)