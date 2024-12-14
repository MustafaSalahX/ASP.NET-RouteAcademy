using WorkShopOneOOP2;

namespace OOP02;

public enum Gender
{
    M = 1,
    F = 2
}
[Flags]
public enum SecuirtyLevel : byte
{
    Guest = 1,
    Developer = 2,
    Secrtary = 4,
    DBA = 8
}
public class Employee : IComparable
{
    int id;
    string name;
    double salary;
    Gender gender;
    HiringDate hiringDate;
    SecuirtyLevel secuirtyLevel;

    public Employee()
    {

    }


    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public double Salary { get => salary; set => salary = value; }
    internal Gender Gender { get => gender; set => gender = value; }
    public HiringDate HiringDate { get => hiringDate; set => hiringDate = value; }
    internal SecuirtyLevel SecuirtyLevel { get => secuirtyLevel; set => secuirtyLevel = value; }

    public override string ToString()
    {
        return $"The name = {name} , The salary = {salary} , The Gender = {gender} ,\n The SecurityLevel = {secuirtyLevel} , The HiringDate = {hiringDate}";
    }
    public static void SortEmployee(Employee[] employees)
    {
        if (employees is not null)
            Array.Sort(employees);
    }

    //Sorting descending 
    public int CompareTo(object? obj)
    {
        Employee right = obj as Employee;
        if (hiringDate.Year > right.hiringDate.Year)
        {
            return -1;
        }
        else if (hiringDate.Year < right.hiringDate.Year)
        {
            return 1;
        }
        else
        {
            if (hiringDate.Month < right.hiringDate.Month)
            {
                return 1;
            }
            else if (hiringDate.Month > right.hiringDate.Month)
            {
                return -1;
            }
            else
            {
                if (hiringDate.Day > right.hiringDate.Day)
                {
                    return -1;
                }
                else if (hiringDate.Day < right.hiringDate.Day)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }

    public static void InsertEmployeeData(Employee[] employees)
    {
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = new Employee();
        }

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Please eneter the employee data");
            bool flag;
            do
            {
                Console.WriteLine("Please enter the ID ");
                flag = int.TryParse(Console.ReadLine(), out employees[i].id);
            } while (!flag);

            do
            {
                Console.WriteLine("Please enter the Name ");
                employees[i].name = Console.ReadLine();

            } while (string.IsNullOrEmpty(employees[i].name));

            do
            {
                Console.WriteLine("Please enter the Salary ");
                flag = double.TryParse(Console.ReadLine(), out employees[i].salary);
            } while (!flag || employees[i].salary <= 0);

            int genderNum;
            Console.WriteLine("Please enter 1 for Male and 2 for Female :");
            do
            {
                Console.WriteLine("Please enter the Gender ");
                flag = int.TryParse(Console.ReadLine(), out genderNum);
            } while (!flag || !Enum.IsDefined(typeof(Gender), genderNum));
            employees[i].gender = (Gender)genderNum;

            Console.WriteLine("Please enter the Secuirty level ==> Guest = 1 , Developer = 2 , Secratry = 4 , DB = 8");
            int secuirtyprev;
            do
            {
                Console.WriteLine("Please enter the SecuirtyPrivelege ");
                flag = int.TryParse(Console.ReadLine(), out secuirtyprev);
            } while (!flag || !(secuirtyprev > 0 && secuirtyprev <= 15));
            employees[i].secuirtyLevel = (SecuirtyLevel)secuirtyprev;

            Console.WriteLine("Please enter the hiring date that consist of Day , Month , Year :");
            int day, month, year;
            employees[i].hiringDate = new HiringDate();
            do
            {
                Console.WriteLine("Please enter the day");
                flag = int.TryParse(Console.ReadLine(), out day);
            } while (!flag);
            employees[i].hiringDate.Day = day;

            do
            {
                Console.WriteLine("Please enter the month");
                flag = int.TryParse(Console.ReadLine(), out month);
            } while (!flag);
            employees[i].hiringDate.Month = month;

            do
            {
                Console.WriteLine("Please enter the year");
                flag = int.TryParse(Console.ReadLine(), out year);
            } while (!flag);
            employees[i].hiringDate.Year = year;
        }
    }

    public static void PrintEmployeeInfo(Employee[] employees)
    {
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"Information for employee number{i + 1}");
            Console.WriteLine(employees[i]);
            Console.WriteLine();
        }
    }
}
