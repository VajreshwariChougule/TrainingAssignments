use AssignmentDB
/* 1.Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction */

begin
declare @salary float = 46000;
declare @SAL float,@HRA float,@DA float,@PF float,@IT float
declare @Deductions float, @GrossSAlary float, @NetSalary float

--a)HRA  as 10% Of sal
set @HRA = ((@salary)*10/100)
print 'HRA Salary is : '+''+cast(@HRA as varchar(10))


--b)DA as  20% of sal
set @DA =((@salary)*20/100)
print 'DA SAlary is : '+''+cast(@DA as varchar(10))


--c)PF as 8% of sal
set @PF =((@salary)*8/100)
print 'PF SAlary is : '+''+cast(@PF as varchar(10))


--d)IT as 5% of sal
set @IT =((@salary)*5/100)
print 'IT SAlary is : '+''+cast(@IT as varchar(10))


--e)Deductions as sum of PF and IT
set @Deductions = @PF+@IT
print 'Deductions is : '+''+cast(@Deductions as varchar(10))


--f)Gross Salary as sum of SAL,HRA,DA and Deductions
set @SAL = @salary -(@HRA+@DA+@Deductions)
set @GrossSAlary = @SAL+(@HRA+@DA+@Deductions)
print 'Gross Salary is : '+''+cast(@GrossSAlary as varchar(10))


--g)Net salary as  Gross salary- Deduction
set @NetSalary = @GrossSAlary-@Deductions
print 'Net Salary is : '+''+cast(@NetSalary as varchar(10))
end

--2.Write a T-SQL Program to find the factorial of a given number.

begin
	declare @num int
	declare @factorial int
	set @num=5
	set @factorial=1
while @num>0
	begin
		set @factorial=@factorial*@num
		set @num=@num-1
	end
	print 'Factorial of a given number is : '+cast(@factorial as varchar)
	
end

--3.Create a stored procedure to generate multiplication tables up to a given number.

create or alter proc Multiplication_Table(@num1 int)
as
begin
 declare @num2 int = 1, @result int

  while(@num2<=10)
  begin
    set @result = @num1 * @num2
	print @result

  set @num2 = @num2+1
  end
end

exec Multiplication_Table @num1=10