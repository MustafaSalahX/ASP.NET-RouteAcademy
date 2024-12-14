-------------------------------------------------------
-------------- Created By Mustafa Salah ---------------
-------------------------------------------------------
-- Part 01 --
use RouteCompany

create table Department
(
DeptNo int primary key,
DeptName varchar(20),
Location varchar(50)
)

insert into Department
values (1 , 'Research' , 'NY'),
       (2 ,'Accounting','DS'),
	   (3 , 'Marketing','KW')


create table Employee
(
EmpNo int primary key ,
Fname varchar(20) not null,
Lname varchar(20) not null,
DeptNo int references Department(DeptNo),
salary money unique
)

insert into Employee
values (25348 , 'Mathew' , 'Smith' , 3 , 2500),
       (10102 , 'Ann' , 'Jones' , 3 , 3500),
	   (18316 , 'John' , 'Barrimore' , 1 , 2400),
       (29346 , 'James' , 'James' , 2 , 2800),
	   (9031 , 'Lisa' , 'Bertoni' , 2 , 4000),
	   (2581 , 'Elisa' , 'Hansel' , 2 , 3600),
	   (28559 , 'Sybl' , 'Moser' , 1 , 2900)

create table Project
(
ProjectNo int primary key,
ProjectName varchar(20) not null,
Budget money 
)

insert into Project
values ( 1 , 'Apollo' , 120000),
       ( 2 , 'Gemini' , 95000),
       ( 3 , 'Mercury' , null)



insert into Works_on
values (10102 , 1 , 'Analyst' ,'2006.10.1'),
       (10102 , 3 , 'Manager' ,'2012.1.1'),
	   (25348 , 2 , 'Clerk' ,'2007.2.15'),
       (18316 ,2,NULL,'2007.6.1'),
       (29346,2,NULL,'2006.12.15'),
       (2581,3,'Analyst','2007.10.15'),
       (9031,1,'Manager','2007.4.15'),
       (28559,1,NULL,'2007.8.1'),
       (28559,2, 'Clerk','2012.2.1'),
       (9031,3,'Clerk','2006.11.15'),
       (29346,1,'Clerk','2007.1.4')

insert into Works_on(EmpNo)
values(11111)

update Works_on
set EmpNo = 11111
where EmpNo = 10102
---Causes Error -- 


update Employee
set EmpNo = 22222
where EmpNo = 10102
----- Explaining Later 



delete Employee 
where EmpNo = 10102


alter table Employee
add TelephoneNumber varchar(20)

alter table Employee
drop column TelephoneNumber

create schema Company

alter schema Company
transfer Department

alter schema Company
transfer Project

create schema HR


alter schema HR
Transfer Employee


update Company.Project
set Budget += Budget *0.1
from HR.Employee e , Works_On wo , Company.Project p
where e.EmpNo = wo.EmpNo
and wo.Job ='manager' and e.EmpNo =10102
and wo.ProjectNo = p.ProjectNo



update Company.Department
set DeptName = 'Sales'
from HR.Employee e , Company.Department d
where e.DeptNo = d. DeptNo and e.Fname ='James'


update Works_On
set Enter_Date = '2007-12-12'
from HR.Employee e , Company.Department d, Company.Project p, Works_On w
where e.DeptNo = d.DeptNo
and w.ProjectNo = p.ProjectNo
and e.EmpNo = w.EmpNo
and d.DeptName = 'Sales' and w.ProjectNo = 1

delete from Works_On
where EmpNo in (select EmpNo from HR.Employee e , Company.Department d where e.DeptNo = d.DeptNo and d.Location = 'KW')


-- SD32-COMPANY
--Cant Solve this !! 
Create Table Audit(
ProjectNo int,
UserName varchar(max),
ModifiedDate Date,
Budget_Old int,
Budget_New int
)


-- Part 02 --
use ITI

create clustered index HireDateIndex
on Department(Manager_hiredate)
--The Primary Key Is Clusterd And Cannot Create Another One
create unique nonclustered index  AgeIndex
on student(St_age)
-- It Created Succsesfully	