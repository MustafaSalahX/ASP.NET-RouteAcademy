------------- MustafaSalah ---------
-- Part 01 -- 
use ITI
-- test - 
select ISNULL(s.St_Age,99999) From Student s
---- 
select COUNT(*) NumStudents FRom student s WHERE St_Age IS NOT NULL
select c.Crs_Name, COUNT(c.Crs_Id) TopicNum FROM course c group by Crs_Name
select s.St_Fname,sp.St_super from Student s JOIN Student sp ON s.St_Id = sp.St_super
-- Cant Integrate Is null With the full name !
SELECT s.St_Id StudentID, s.St_Fname+' '+s.St_Lname StudentFullName, ISNULL(d.Dept_Name, 'N\A') DeptName FROM student s JOIN department d ON S.Dept_Id = d.Dept_Id
SELECT s.St_Id StudentID, s.St_Fname+' '+s.St_Lname StudentFullName, ISNULL(d.Dept_Name, 'N\A') DeptName FROM student s Left JOIN department d ON S.Dept_Id = d.Dept_Id
sELEct t.Ins_Name, ISNULL(salary, '0000') salary FRom instructor t
SELECT S.St_Fname, COUNT(S.St_Id) NumberOfStudents FROM Student s JOIN Student st ON s.St_Fname = s.St_super GROUP BY s.St_super
select MAX(Salary) MAXSALARY , MIN(Salary)MINSALARY from Instructor
Select AVG(Salary) fROM Instructor
----- PART 02 ------
use MyCompany
select p.Pname,p.Pnumber , w.Hours from Project p , Departments d , Works_for w  WHERE p.Pnumber = w.Pno and d.Dnum = p.Dnum 
Select d.Dname ,MAX(e.Salary) Maxsalary,MIN(e.Salary)MinSalary,AVG(E.Salary)AvgSalary from Departments D, Employee e where d.Dnum = e.Dno group by D.Dname
select e.Fname+' '+e.Lname Fullname, p.Pname  from Employee e , Project p , Departments d where d.Dnum = p.Dnum and e.Dno = d.Dnum order by d.Dname , e.Lname , e.Fname 
update e set Salary *= 1.3 from Employee e , Project p, Departments d where d.Dnum = p.Dnum and e.Dno = d.Dnum and p.Pname ='Al Rabwah'
insert into Departments (Dnum,Dname,MGRSSN,[MGRStart Date]) values (100,'DEPTIT',112233,'1-11-2006')
UPDATE Departments SET MGRSSN = 968574 where Departments.Dnum = 100
UPDATE Departments SET MGRSSN = 102672 where Departments.Dnum = 20
UPDATE Employee SET Superssn = 102672 Where SSN = 102660
insert into Employee (SSN,Fname,Lname) values(102672,'Mustafa','Salah')
update Dependent set ESSN = 102672 where ESSN = 223344
DELETE FROM Dependent WHERE ESSN = 223344
UPDATE Departments SET MGRSSN = NULL WHERE MGRSSN = 223344
UPDATE Employee SET Superssn = NULL WHERE Superssn  = 223344
Delete from Works_for Where  ESSn= 223344
Delete FROM Employee WHERE SSN = 223344
UPDATE Employee SET SSN =  102672  WHERE SSN = 102672
UPDATE Employee SET Superssn = 102672 WHERE SSN = 102660 
-- PART 03 -- 
SELECT e.Fname+''+E.Lname FullName, w.Hours ,d.Dnum FROM Employee E , Works_for w , Departments D , Project P 
where -- every rel causes errors and not showing data !!!
 -- ex -> p.Pnumber = w.Pno and e.Dno = d.Dnum and d.Dnum=p.Dnum and
 d.Dnum=10 and p.Pname = 'AL Rabwah' AND Hours >= 10;
select Fname, Lname From Employee e WHERe e.Superssn  = 321654;
select d.MGRSSN ,e.Fname+''+e.Lname ManagersSSN ,d.[MGRStart Date],e.Address , e.Bdate,e.Sex,e.Salary from Departments d ,Employee e where e.SSN = d.MGRSSN
SELECT e.Fname+''+e.Lname Fullname , p.Pname FROM Employee e , Works_for w, Project p where e.SSN = w.ESSn and p.Pnumber = w.Pno Order By p.Pnumber;
SELECT p.Pnumber,d.Dname, e.Lname,e.Address, e.Bdate , p.Plocation FROM Project p , Departments D , Employee e WHERE p.Dnum = d.Dnum and d.MGRSSN= e.SSN  and  p.City = 'Cairo' Order by p.Pnumber;
SELECT e.Fname+' '+e.Lname FullName, e.SSN, e.Address, e.Bdate, d.Dependent_name, d.Bdate  DependentBirthDate, d.ESSN from Employee e full join Dependent d ON e.SSN = d.ESSN Order by e.Lname, e.Fname;








