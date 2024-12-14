using OOP02;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WorkShopOneOOP2
{
    internal class Program
	{
		static void Main(string[] args)
		{
			#region 1.	Design and implement a Class for the employees in a company:
			//⮚	Employee is identified by an ID, Name, security level, salary, hire date and Gender.


			#endregion
			#region 2.	Develop a Class to represent the Hiring Date Data:
			//⮚ Consisting of fields to hold the day, month and Years.


			#endregion
			#region 3.	We need to restrict the Gender field to be only M or F [Male or Female] 
			#endregion
			#region 4.	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
			#endregion
			#region 5.	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
			#endregion
			#region 6.     Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
			Employee[] employee = new Employee[3];
			//Adding employees using object intilizer 

			//employee[0] = new Employee
			//{
			//	Id = 1,
			//	Name = "Mariam",
			//	Salary = 10000,
			//	Gender = Gender.F,
			//	SecuirtyLevel = SecuirtyLevel.DBA,
			//	HiringDate = new HiringDate { Day = 20, Month = 11, Year = 2003 }
			//};
			//employee[1] = new Employee
			//{
			//	Id = 2,
			//	Name = "Mohamed",
			//	Salary = 7000,
			//	Gender = Gender.M,
			//	SecuirtyLevel = SecuirtyLevel.Secrtary,
			//	HiringDate = new HiringDate { Day = 11, Month = 12, Year = 2001 }
			//};
			//employee[2] = new Employee
			//{
			//	Id = 3,
			//	Name = "Momen",
			//	Salary = 9000,
			//	Gender = Gender.M,
			//	SecuirtyLevel = SecuirtyLevel.Guest,
			//	HiringDate = new HiringDate { Day = 11, Month = 12, Year = 2023 }
			//};

			//Adding employees based on user's input
			Employee.InsertEmployeeData(employee);

			Employee.PrintEmployeeInfo(employee);
			Employee.SortEmployee(employee);
			Console.WriteLine("****************************");
			Console.WriteLine("After sorting : ");
			Console.WriteLine("****************************");
			Employee.PrintEmployeeInfo(employee);
			#endregion
			#region Notes:
			//⮚	Implement All the Necessary Member Functions on the Class(Getters, Setters)
			//⮚	Define all the Necessary Constructors for the Class
			//⮚	Allow NO RUNTIME errors if the user inputs any data
			//⮚	Write down all the necessary Properties(Instead of setters and getters)


			#endregion

		}
	}
}
