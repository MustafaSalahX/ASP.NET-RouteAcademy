-----------------------------------------------------
------------- Created By Mustafa Salah --------------
-----------------------------------------------------
use ITI

create function GetMonthName(@date date)
returns varchar(20)
begin
	return Format(@date, 'MMMM')
end

--------------Check-----------------

select dbo.GetMonthName(GetDate())


create function GetValuesBetween(@start int, @end int)
returns varchar(max)
as
begin
declare @result varchar(max) =''
declare @current int
set @current = @start + 1
while @current < @end
begin
set @result +=CONCAT(@current, ', ')
set @current +=1
end
return @result
end
--------------Check-----------------
select dbo.GetValuesBetween(0,6)


create function GetDeptNameByStId(@St_id int)
returns @table table (FUllName varchar(50), DeptName varchar(20))
as
begin 
insert @table
select CONCAT(s.St_Fname,' ', s.St_Lname), d.Dept_Name
from Student s inner join Department d
on s.Dept_Id = d.Dept_Id
where s.St_Id = @St_id
return
end
--------------Check-----------------
select * from GetDeptNameByStId(1)
--------------------------------------
create function NameStatus(@st_id int)
returns varchar(50)
begin
declare @msg varchar(50)
declare @fname varchar(20)
declare @lname varchar(20)
select @fname = St_Fname, @lname = St_Lname
from Student
where St_Id = @st_id

if(@fname is null) and (@lname is null)
set @msg = 'First And Last Name Are NULL'
else if(@fname is null) 
set @msg = 'First Name is null'
else if(@lname is null) 
set @msg = 'Last Name is null'
else
set @msg = 'First Name And Last Name Are Not NULL'
return @msg
end

--------------Check-----------------
select dbo.NameStatus(13)
------------------------------------
create function ManagerformatHiringDate(@format int)
returns @table table (deptName varchar(50), ManagerName varchar(50), HiringDate varchar(20)) 
as
begin
insert @table
select d.Dept_Name, i.Ins_Name, CONVERT(varchar, D.Manager_hiredate, @format)
from Instructor i inner join Department d
on i.Ins_Id = d.Dept_Manager
return
end
--------------Check-----------------
select * from ManagerformatHiringDate(109)
-----------------------------------------------
create function GetStudentName(@nameFormat varchar(15))
returns @table table  (student_Name varchar(20))
as
begin
if(@nameFormat = 'first name')
insert into @table
select ISNULL(St_Fname, '404 Not Found')
from Student
if(@nameFormat = 'last name')
insert into @table
select ISNULL(St_Lname, '404 Not Found')
from Student
if(@nameFormat = 'full name')
insert into @table
select ISNULL(St_Fname, '404 Not Found') + ISNULL(St_Lname, '404 Not Found')
from Student
return
end 

--------------Check-----------------
select * from GetStudentName('last name')
------------------------------------------
use MyCompany

create function GetAllEmployee(@projectNo int)
returns @table table
(
	[Employee Name] varchar(20)
)
as
begin
insert into @table
select CONCAT(e.Fname,' ', e.Lname)
from Employee e inner join Works_for wf
on e.SSN = wf.ESSn
where wf.Pno = @projectNo
return
end

--------------Check-----------------

select * from GetAllEmployee(100)

---- Part 02 Views ------
use ITI

create view DisplayStudents
as
	select CONCAT(s.St_Fname, ' ', s.St_Lname) as [Full Name], c.Crs_Name as [Course Name]
	from Student s, Course c, Stud_Course sc
	where s.St_Id = sc.St_Id
	and sc.Crs_Id = c.Crs_Id
	and sc.Grade > 50

--------------Check-----------------
select * from DisplayStudents
-------------------------------------
create or alter  view InstructorTopics
with encryption
as
	select distinct i.Ins_Name, t.Top_Name
	from Instructor i, Topic t, Ins_Course ic, Course c, Department d
	where i.Ins_Id = d.Dept_Manager
	and i.Ins_Id = ic.Ins_Id
	and ic.Crs_Id = c.Crs_Id
	and c.Top_Id = t.Top_Id


--------------Check-----------------
select * from InstructorTopics
-------------------------------------

create view  InstructorInSdJava
with schemabinding, encryption
as 
	select i.Ins_Name, d.Dept_Name
	from dbo.Instructor i inner join dbo.Department d
	on i.Dept_Id = d.Dept_Id
	where d.Dept_Name in('SD', 'Java')
	
--------------Check-----------------
select * from InstructorInSdJava
------------------------------------
create view V1
as
	select * 
	from  Student
	where St_Address in ('alex', 'cairo')
	with check option

--------------Check-----------------

select * from V1
------------------------------------------
Update V1 set st_address='tanta'
Where st_address='alex';

use MyCompany

create view ProjectWithEmployeeCount
as
	select p.Pname , COUNT(wf.ESSn) as [Number of employee]
	from Project p inner join Works_for wf
	on p.Pnumber = wf.Pno
	group by Pname

--------------Check-----------------
select * from ProjectWithEmployeeCount

---- Part 02 -----

use SD32-Company


create or alter view v_clerk
as
	select EmpNo, ProjectNo, Enter_Date
	from Works_on
	where  Job = 'clerk'
--------------Check-----------------
select * from v_clerk
--------------------------------

create or alter view v_without_budget
as
	select ProjectNo, ProjectName
	from HR.Project

--------------Check-----------------
select * from v_without_budget
---------------------------------------------
create view v_count
as
	select p.ProjectName, count(wo.Job) as [Number of jobs]
	from Hr.Project p, Works_on wo
	where p.ProjectNo = wo.ProjectNo
	group by p.ProjectName


--------------Check-----------------
select * from v_count
---------------------------------------
create or alter view v_project_p2
as
	select  EmpNo [Employee Number]
	from v_clerk
	where ProjectNo = 2


--------------Check-----------------
select * from v_project_p2
---------------------------------------
alter view v_without_budget
as
	select *
	from HR.Project
	where ProjectNo in (1, 2)

--------------Check-----------------
select * from v_without_budget
-----------------------------------
drop view v_count, v_clerk

create or alter view EmpData
as
	select EmpNo, EmpLname
	from HR.Employee
	where DeptNo = 1
--------------Check-----------------
select * from EmpData
--------------------------------------
select EmpLname
from EmpData
where EmpLname like '%j%'


create or alter view v_dept
as 
	select DeptNo [Department Number], DeptName [Department Name]
	from Department

--------------Check-----------------
select * from v_dept
-----------------------------
insert into v_dept
values(4, 'Development')


create or alter view v_2006_check
as
	select EmpNo, ProjectNo, Enter_Date
	from Works_on
	where Enter_Date between '2006-1-1' and  '2006-12-31'
	with Check option


--------------Check-----------------
select * from v_2006_check

insert into v_2006_check
values(22222, 3, '2007-2-1')
