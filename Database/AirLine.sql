create database Airline
use AirLine
create table airline (id int primary key ,name nvarchar(50),[Address] nvarchar(50),constantperson nvarchar(50))
create table AirCraft (id int primary key , capacity float,Model NVARCHAR(50),MajPilot nvarchar(20),Assistant nvarchar(20),Host1 nvarchar(20),Host2 nvarchar(20),airlineId int references airline(id) )
create table AirlinePhones(airlineid int references Aircraft(id),phones int, primary key (airlineid,phones) )
create table [Transaction](Id int primary key,[description] nvarchar(100),Amount float,[date] date, Airlineid int references airline(id) )
create table employee (id int primary key,Name nvarchar(20),Address nvarchar(50),gender char(5),Position nvarchar(20),BDYEAR INT ,DBMONTH INT, Airlineid int references airline(id))
create table empQualifications (empid int references employee(id),Qualifications Nvarchar(50),primary key(empid, Qualifications))
create table [route] (id int primary key ,distance float ,Destination nvarchar(50),origin nvarchar(50),[Classification] nvarchar(20))
create table aircraftRoutes(Aircraftid int references aircraft(id),routeid int references route(id),Departure nvarchar(50),NumOfPass int, Price float , arrival datetime2)