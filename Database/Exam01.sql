--Exam01 SQl Querys ----
-- Made By MustafaSalah -- 
--Write a query that displays Full name of an employee who has more than 3 letters in his/her First Name

Select FName+' '+LName AS FullName
from Employee
Where LEN(FName) > 3 

-- Write a query to display the total number of Programming books available in the library with alias name 'NO OF PROGRAMMING BOOKS'
SELECT COUNT(*) AS TotalProgrammingBooks
FROM Book b ,Category c
WHERE c.Id= b.Cat_id and Cat_name = 'Programming'

--Write a query to display the number of books published by (HarperCollins) with the alias name 'NO_OF_BOOKS'
                              
SELECT COUNT(*) AS 'NO_OF_BOOKS'
FROM book b , Publisher p
WHERE p.Id=b.Publisher_id and  Name = 'HarperCollins';
-- Write  a query to display the User SSN and name, date of borrowing and due date  of the User whose due date is before July 2022

SELECT User_SSN, User_Name, Borrow_date, Due_date
FROM Borrowing b , Users u
WHERE u.SSN=b.User_ssn and Due_date < '2022-07-01';


-- Write a query to display book title, author name and display in the  following format, ' [Book Title] is written by [Author Name]

Select  Title +' Is Written By '+ Name   AS AuthorsBooks
From  Book ,Author 


--Write a query to display the name of users who have letter 'A' in their names. 
SELECT User_Name
FROM users
WHERE User_Name LIKE '%A%';

--7. Write a query that display user SSN who makes the most borrowing
SELECT u.ssn , u.User_Name
FROM users u
JOIN (SELECT User_ssn, COUNT(*) as borrowing_count FROM borrowing GROUP BY user_ssn) as b ON u.ssn = b.user_ssn
ORDER BY b.borrowing_count DESC 

--8. Write a query that displays the total amount of money that each user paid for borrowing books. 
SELECT user_ssn as ID, SUM(Amount) as total_paid
FROM borrowing
GROUP BY user_ssN 


--9. write a query that displays the category which has the book that has the minimum amount of money for borrowing. 
Select b.Cat_id As ID , cc.Cat_name , B.Title 
From book b ,Category CC ,Borrowing br
Where B.Id=br.Book_id and cc.Id = b.Cat_id  --JOIN borrowing br ON b.id = br.book_ id
Order bY br.amount ASC

--10.write a query that displays the email of an employee if it's not found, display address if it's not found, display date of birthday. 
--select e.Email , e.Address, e.DOB from Employee e 
--group by  e.Email IS null 
-- serched for this and found 2 wayes !
SELECT CASE 
        WHEN e.Email IS NOT NULL THEN e.Email
        WHEN e.Address IS NOT NULL THEN e.Address
        ELSE 'e.DOB'
    END AS ContactInfo
FROM Employee e;

select coalesce(email, address , 'DOB') as contact_info
from employee;
--Its To Hard to Do Honestly !

--11.Write a query to list the category and number of books in each category with the alias name 'Count Of Books'. 
Select c.Cat_name, COUNT(b.id) AS 'Count Of Books'
From Category c
JOIN book b ON c.id = b.Cat_id
Group By c.cat_name;


--12.Write a query that display books id which is not found in floor num = 1  and shelf-code = A1.

SELECT distinct id ,B.Title 
FROM book b , Floor f , Shelf S
WHERE NOT (f.Number = 1 AND S.Code = 'A1') 
ORDER BY ID ASC

SELECT b.id, b.Title
FROM book b
JOIN Floor f ON b.Id = f.Number
JOIN Shelf s ON b.Shelf_code = s.Code
WHERE NOT (f.Number = 1 AND s.Code = 'A1')
ORDER BY b.id ASC 


--13.Write a query that displays the floor number , Number of Blocks and number of employees working on that floor.

select e.Floor_no , f.Num_blocks ,e.Fname+' '+e.Lname as Names from Employee e , Floor f 
where f.Number = e.Floor_no 
group by e.Floor_no , f.Num_blocks ,e.Fname+' '+e.Lname 

--14.Display Book Title and User Name to designate Borrowing that occurred  within the period ‘3/1/2022’ and ‘10/1/2022’.
select b.Title as 'Book Title', u.User_Name as 'User Name'
from Borrowing br join Book b on br.book_id = b.id 
join Users u on br.User_ssn = u.ssn
where br.borrow_date between '2022-03-01' and '2022-10-01';

--15.Display Employee Full Name and Name Of his/her Supervisor as Supervisor Name.
select e.Fname+' '+e.Lname as 'Employee Full Name', eSuper.Fname+' '+eSuper.Lname as 'Supervisor Name'
from Employee e
left join Employee eSuper on e.Super_id = eSuper.ID;

--16.Select Employee name and his/her salary but if there is no salary display Employee bonus. 
select e.Fname+' '+e.Lname as 'Employee Name', 
    COALESCE(e.Salary, e.Bouns) as 'Salary or Bonus'
from Employee e;

--17.Display max and min salary for Employees 
select 
    MAX(e.Salary) as 'Maximum Salary', 
    MIN(e.Salary) as 'Minimum Salary'
from Employee e;

--18.Write a function that take Number and display if it is even or odd 
go
create function CheckEvenOrOdd(@Number int)
returns VARCHAR(20)
as
begin
    if (@Number % 2 = 0)
        return 'Even';
    else
        return 'Odd';
end
----------------------------------------------------
go
create function Number(@Number int)
returns VARCHAR(20)
as
begin 
declare @name VARCHAR(20)

    if (@Number % 2 = 0)
        return '@Even';
    else
        return  '@Odd';

		return @name
		
end


--19.write a function that take category name and display Title of books in that category 
go
create function GetBooksByCategory(@CategoryName VARCHAR(100))
returns table
as
return (select b.Title from Book b INNER JOIN Category c on b.Cat_id = c.ID where c.Cat_name = @CategoryName)

--20. write a function that takes the phone of the user and displays Book Title ,  user-name, amount of money and due-date. 
go
CREATE FUNCTION GetUserInfoByPhone (@PhoneNumber int(20))
RETURNS TABLE
AS
RETURN (select b.Title AS 'Book Title', u.User_Name AS 'User Name', br.Amount AS 'Amount of Money', br.Due_date AS 'Due Date'
    from Borrowing br 
    INNER JOIN Book b ON br.Book_id = b.ID
    INNER JOIN Users u ON br.User_ssn = u.SSN
	inner join Employee e on  u.Emp_id = e.Id 
    WHERE e.phone = @PhoneNumber )

--21.Write a function that take user name and check if it's duplicated return Message in the following format ([User Name] is Repeated  [Count] times) if it's not duplicated display msg with this format [user name] is not duplicated,if it's not Found Return [User Name] is Not Found 
go
create function CheckUserNameDuplicate (@UserName nvarchar(100))
returns nvarchar(255)
as
begin
    DECLARE @Count INT;
    SELECT @Count = COUNT(*)
    FROM Users u
    WHERE u.User_Name  = @UserName;

    if @Count > 1
        return CONCAT('[' , @UserName , '] is Repeated ', @Count , ' times');
    else if @Count = 1
        RETURN CONCAT('[' , @UserName , '] is not duplicated');
    else 
        return CONCAT('[' , @UserName , '] is Not Found');
end

--22.Create a scalar function that takes date and Format to return Date With That Format. 
go
create function FormatDate (@Date DATE, @Format VARCHAR(100))
returns Nvarchar(100)
as
begin
    return FORMAT(@Date, @Format);
end

--23.Create a stored procedure to show the number of books per Category.
go
create proc GetBookCountPerCategory
as 
begin
    Select c.Cat_name as 'Category Name', COUNT(b.ID) as 'Number of Books'
    from Category c
    LEFT JOIN Book b on c.ID = b.Cat_id
    group by c.Cat_name;
end


--24.Create a stored procedure that will be used in case there is an old manager who has left the floor and a new one becomes his replacement. The procedure should take 3 parameters (old Emp.id, new Emp.id and the floor number) and it will be used to update the floor table. 
go
create proc UpdateFloorManager
    @OldManagerID int,
    @NewManagerID int,
    @FloorNumber int
as
begin
    update Floor
    set MG_ID = @NewManagerID
    where MG_ID = @OldManagerID
      and Floor.Number = @FloorNumber;
end

--25.Create a view AlexAndCairoEmp that displays Employee data for users who live in Alex or Cairo
go
create view AlexAndCairoEmp as
select * from Employee
where Address in ('Alex', 'Cairo');

--26.create a view "V2" That displays number of books per shelf 
go 
CREATE VIEW V2 AS
SELECT b.Shelf_code, COUNT(ID) AS 'Number of Books'
FROM Book b
GROUP BY b.Shelf_code;

--27.create a view "V3" That display the shelf code that have maximum number of books using the previous view "V2"
go 
create view V3 as
select top 1 Shelf_code
from V2
order by [Number of Books] desc
--28.Create a table named ‘ReturnedBooks’ With the Following Structure 
create table ReturnedBooks (
UserSSN int primary key ,
bookid int unique ,
due_Date date ,
RetrunDate date ,
fees float )
go
-- i cant do it --- 
-- This one is hard so giving up -- 


--29.In the Floor table insert new Floor With Number of blocks 2 , employee  with SSN = 20 as a manager for this Floor,The start date for this manager is Now. Do what is required if you know that : Mr.Omar Amr(SSN=5) moved to be the manager of the new Floor (id = 6), and they give Mr. Ali Mohamed(his SSN =12) His position
INSERT INTO Floor (Number, Num_blocks, MG_ID, Hiring_Date)
VALUES (7, 2, 20, GetDate()) --VALUES (7, 2, 20, NOW()) --Now() Function is not working in this situation
UPDATE Floor
SET MG_ID = 12 
WHERE Number = 6
UPDATE Floor
SET MG_ID = 12 
WHERE Number = 6

--
go
CREATE VIEW v_2006_check as
SELECT MG_ID , Number, Num_blocks ,Hiring_Date
FROM Floor
WHERE Hiring_Date BETWEEN '2022-03-01' AND '2022-05-31';

insert into v_2006_check values (2,6,2,'7-8-2023')
--Violation of PRIMARY KEY constraint 'PK_Floor'. Cannot insert duplicate key in object 'dbo.Floor'. The duplicate key value is (6).
insert into v_2006_check values (4,7,1,'4-8-2022')
--Violation of PRIMARY KEY constraint 'PK_Floor'. Cannot insert duplicate key in object 'dbo.Floor'. The duplicate key value is (7).
-- I HAVE ONLY Access for A FEW DATA IN THIS VIEW AND THERE IS DATA WITH THE SAME CREDINCTIAL ! s
--31.Create a trigger to prevent anyone from Modifying or Delete or Insert in the Employee table ( Display a message for user to tell him that he can’t take any action with this Table)
go
Create trigger PreventAllActions
on Employee
instead of INSERT, UPDATE, DELETE
as
begin	
    raiserror ('You cannot take any action on this table.',404,405)
    rollback transaction;
end

--Testing Referential Integrity , Mention What Will Happen When : 
--1- 
insert  into User_phones values (50,01010574543)
--The INSERT statement conflicted with the FOREIGN KEY constraint "FK_User_phones_User". The conflict occurred in database "Library", table "dbo.Users", column 'SSN'.
-- I CANT iNSERT Values because i should Add This Number At USERS Table First 
--2- 
UPDATE Employee
SET Id= 21
WHERE id = 20;
--Error severity levels greater than 18 can only be specified by members of the sysadmin role, using the WITH LOG option.
--severity levels greater than 18 indicate more serious errors and can only be specified by members of the sysadmin fixed server role, which is the highest level of privilege in SQL Server.
--There a Trigger Controling all of this so i cant Update Or Delete OR Insert !
--3-
DELETE FROM Employee
WHERE id = 1
--Error severity levels greater than 18 can only be specified by members of the sysadmin role, using the WITH LOG option.
--severity levels greater than 18 indicate more serious errors and can only be specified by members of the sysadmin fixed server role, which is the highest level of privilege in SQL Server.
--There a Trigger Controling all of this so i cant Update Or Delete OR Insert !
--4-
DELETE FROM Employee
WHERE id = 12
--Error severity levels greater than 18 can only be specified by members of the sysadmin role, using the WITH LOG option.
--severity levels greater than 18 indicate more serious errors and can only be specified by members of the sysadmin fixed server role, which is the highest level of privilege in SQL Server.
--There a Trigger Controling all of this so i cant Update Or Delete OR Insert !
--5-
CREATE CLUSTERED INDEX IX_Employee_Salary
ON Employee (Salary);
--Cannot create more than one clustered index on table 'Employee'. Drop the existing clustered index 'PK_Employee' before creating another.
-- I Cant Create another clusterd Index because there is already one !


