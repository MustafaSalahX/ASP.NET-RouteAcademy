--Part 01 --
use Hospital
INSERT INTO Nurse VALUES(1,'MENNA','CAIRO',NULL)
INSERT INTO Ward VALUES(1,'ERO',1)
INSERT INTO Nurse VALUES(2,'Tala','CAIRO',NULL)
INSERT INTO Ward VALUES(2,'ERT',2)
INSERT INTO Patient VALUES(1,'Ahmed','ERO',1,Null)
use ITI
INSERT INTO Student VALUES(20,'Mustafa','Salah','Qena',21,10,1) --Note Want to be at Dep 10 not 30 ! 
INSERT INTO Instructor VALUES(16,'Mohammed','Master',4000,30)
update Instructor set Salary  = Salary+800  --20% Bonus
-- Another Way 
update Instructor set Salary  = Salary * 0.2 
--Part 02 --
use MyCompany
SELECT * FROM Employee 
SELECT e.fname,lname,Salary,Dno from Employee e
SELECT p.Pname, p.Plocation, d.Dname responsible_department FROM project p JOIN departments d ON p.Dnum = d.Dnum 
Select e.Fname+' '+e.Lname ,SALARY+Salary*0.1  ANNUALCOMM from Employee e
SELECT e.SSn , e.Fname+' '+e.Lname name ,Salary FROM employee e WHERE salary > 1000
SELECT e.SSn , e.Fname+' '+e.Lname name ,Salary*12 Salary  FROM employee e WHERE salary * 12 > 10000;
Select e.Fname , e.Sex from Employee e where Sex = 'F'
SELECT D.Dnum, D.Dname FROM Departments D WHERE D.MGRSSN = 968574 
SELECT p.Pnumber, p.Pname, p.Plocation FROM project p WHERE p.Dnum = 10;
 --Part 03 -- 
 use ITI
 select DISTINCT i.Ins_Name from Instructor i 
 SELECT I.Ins_Name , I.Dept_Id FROM Instructor I 
 SELECT i.Ins_Name, d.Dept_Name FROM instructor I LEFT JOIN department d ON i.Dept_Id = d.Dept_Id; 
 SElect t.St_Fname+' '+t.St_Lname fullname ,c.Crs_Name ,SC.Grade  from Student t join Stud_Course SC ON t.St_Id = SC.St_Id  join Course c On c.Crs_Id = SC.Crs_Id
 select @@VERSION -- Is the IDE Version (The IDE THAT WE ARE USING NOW ) !
 select @@SERVERNAME -- Is the service Name (Service Name Is the Local Server On Our Machine ) !
 -- Part 04 --
 use MyCompany
 Select d.Dnum , d.Dname , d.MGRSSN ,e.Fname+' '+e.Lname Name From Departments d join Employee e On d.Dnum = e.Dno
 select d.Dname ,p.Pname from Departments d join Project p on p.Dnum = d.Dnum
-- select d.ESSN, d.Dependent_name ,d.Sex,d.Bdate ,e.Fname+' '+e.Lname FullName from Dependent d join Employee e on e.SSN = d.ESSN join Project p --
select  d.ESSN , d.Dependent_name ,d.Sex ,d.Bdate ,e.Fname+' '+e.Lname FullName , p.Pnumber, p.Pname, p.Plocation , p.City , p.Dnum from Dependent d , Employee e , Project p where d.ESSN = e.SSN and p.Pname LIKE 'a%';
select e.Fname+' ' +e.Lname Fname, salary FROM Employee e ,  Departments d WHERE d.Dnum=30 AND salary BETWEEN 1000 AND 2000;
SELECT DISTINCT  e.Fname+' '+e.Lname EmployeeName, d.Dname  ,d.Dnum ,p.Pname  FROM employee e , Departments D , Project P,Works_for w WHERE  d.Dnum = 10 AND p.Pname = 'AL Rabwah'AND w.Hours >= 10 
-- I CANT DO THIS -->
SELECT  e.Fname+''+e.Lname FullName, p.Pname FROM employee e , Departments d , Project p where p.Dnum= d.Dnum and d.Dnum = e.Dno ORDER BY p.Pname
SELECT p.Pname ,p.Pnumber, d.Dname, d.MGRSSN manager, e.address, e.Bdate
FROM project p , Departments d , Employee e  WHERE d.Dnum = E.Dno and P.Dnum =D.Dnum AND p.City = 'Cairo';

