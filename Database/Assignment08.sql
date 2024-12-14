----------------------------------------------------------------
-- Created By Mustafa Salah ---------
--Part 01
use ITI


create procedure ShowNumberOfStudentPerDepartment
as
select d.Dept_Name , COUNT(s.St_Id) as NumberOfStudent
from Department d inner join Student s
on d.Dept_Id = s.Dept_Id
group by Dept_Name
	--Test --
ShowNumberOfStudentPerDepartment
--------------------------------------------------------------------
use MyCompany

create or alter proc CheckNumberOfEmployeeinProject
as
declare @EmpCounter int
select @EmpCounter= COUNT(ESSn)
from Works_for
where Pno = 100
if(@EmpCounter > 3)
select 'The number of employees in the project 100 is 3 or more'
else
select 'The following employees work for the project 100'
select e.Fname, E.Lname
from Employee e inner join Works_for wf
on e.SSN = wf.ESSn
where wf.Pno = 100

---------- test -------------------------------

CheckNumberOfEmployeeinProject

----------------------------------------------------

 create proc ReplaceEmployeeProject @oldEmp int ,@newEmp int, @pNo int
 as
update Works_for
set ESSn = @newEmp
where ESSn = @oldEmp and Pno = @pNo


exec ReplaceEmployeeProject 512463,112233, 500

create table AuditBudget
(
projectNo int,
UserName varchar(50),
ModifiedDate date,
Budget_Old money,
Budget_New money
)
use SD32-Company

on hr.Project
after update
as if update(Budget)
begin 
insert into AuditBudget
select i.ProjectNo, SUSER_SNAME(), GetDate(), d.Budget, i.Budget
from inserted i, deleted d
end
update hr.Project
set Budget = 8000
where ProjectNo =1

select * from AuditBudget
------------------------------------------------------------------------------
--Part 02

create or alter proc CalcSum @start int, @end int , @sum int output
as
begin
set @sum = 0
while @start <= @end 
begin
set @sum += @start
set @start +=1
end
end
declare @result int
exec CalcSum @start = 1, @end = 3, @sum = @result out
select @result

create proc CircleArea @r float , @area float output
as
begin
set @area = PI()* POWER(@r, 2)
end
declare @area int
exec CircleArea 5, @area out
select @area



create or alter proc CategoryPersonAges @age int, @category varchar(10) out
as
begin
if @age < 18
set @category ='Child'
else if @age >= 18 and @age <60
set @category ='Adult'
else
set @category ='Senior'
end

declare @category varchar(10)
exec CategoryPersonAge 60, @category  out
select @category

create proc DeterminesMaxMin @number varchar(max), @max int out, @min int out, @avg int out
as
begin
create table #TempTable (value int)
insert into #TempTable(value)
select value
from string_split(@number,',');
select @max = max(value), @min = Min(value), @avg = AVG(value)
from #TempTable
end
declare @max int
declare @min int
declare @avg int
exec DeterminesMaxMin '5,10,15,20,25', @max out, @min out, @avg out

select @max, @min, @avg

		
create table StudentAudit
(
ServerUserName varchar(50),
Date date,
Note varchar(100)
)


create trigger studentAuditInsert
on Student
after insert
as
insert into StudentAudit
select Suser_sname(), getDate(), concat(Suser_sname(),' Insert New Row with Key = ', i.St_id, ' in table Student')
from inserted i
insert into student(St_id,st_fname, st_lname)
values(20,'sayed','karem')
select * from StudentAudit



create trigger studentAuditDelete
on Student
instead of delete
as
insert into StudentAudit
select Suser_sname(), getDate(), concat(Suser_sname(),' try to delete Row with id = ', d.St_id, ' in table Student')
from deleted d
delete from Student 
where st_id = 1
select * from StudentAudit
---- Part 04 My Company Section ----

use mycompany

create trigger PreventInsertInEmployee on Employee instead of insert
as
begin 
if format(GetDate(), 'MMMM') = 'March'
select 'You Cant insert new record in March'
else
insert into Employee
select * from inserted
end
--CHECK --
insert into employee(SSn, Fname, LName) values (812364, 'Mustafa', 'Salah')

