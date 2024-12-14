-- Made By Mustafa Mahmoud Salah --
-- Part 01--
Use Iti
select * from Instructor I where I.Salary < (select avg(salary) from Instructor)
select D.Dept_Name from Department D, Instructor I Where D.Dept_Id = I.Dept_Id and I.Salary = (select Min(Salary) from Instructor)
select top(2) Salary from Instructor order by salary desc 
select * from (select salary , Dept_Id , ROW_NUMBER() over (Partition by dept_Id order by salary desc ) as Rank1 from Instructor) as Table1 where Rank1<=2 
select * from (select st_fname , dept_Id , ROW_NUMBER() over (Partition by dept_Id order by newId()) as Rank1 from student) as Table1 where dept_id is not null and Rank1 = 1
Use MyCompany
select D.* from Departments D , Employee E1 where D.Dnum = E1.Dno and E1.SSN = (select Min(E2.ssn) from Employee E2) 
select E.Fname,E.Lname from Employee E , Departments D where E.SSN = D.MGRSSN  and E.SSn not in (Select essn from Dependent)
select D.Dnum , D.Dname , Count(E.SSN) as Num_Of_Empolyees from Departments D , Employee E where D.Dnum = E.Dno group by D.Dnum , D.Dname having Avg(E.Salary) <  (select Avg(Salary) From Employee)
select Max(Salary) from employee Union
select Max(Salary) from employee where Salary < (Select Max(Salary) from employee)
select E.SSN , E.Fname from Employee E , Dependent D where E.SSN = D.ESSN and exists(Select Essn from Dependent)                             
--Part 02--
Use AdventureWorks2012
select SalesOrderID , ShipDate from sales.SalesOrderHeader where OrderDate between '7/28/2002' and '7/29/2014'
select ProductID , Name from Production.Product where StandardCost < 110 
select ProductID , Name from Production.Product where Weight is null 
select ProductID , Name , Color from Production.Product where Color in ('Silver' , 'Black' , 'Red')
select Name as Product_Name from Production.Product where Name like 'B%'
UPDATE Production.ProductDescription SET Description = 'Chromoly steel_High of defects' WHERE ProductDescriptionID = 3
Select Description from Production.ProductDescription where Description like '%[_]%' 
select distinct HireDate from HumanResources.Employee
select 'The' + Name + 'is only!' + CONVERT(nvarchar(30),ListPrice) as Products_With_Price from Production.Product where ListPrice between 100 and 120 order by ListPrice
