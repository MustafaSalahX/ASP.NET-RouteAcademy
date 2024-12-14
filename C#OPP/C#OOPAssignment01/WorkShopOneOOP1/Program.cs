using System.ComponentModel;

namespace OOP01;

//Q1 Enum
enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
//Q2 Struct
struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public override string ToString()
    {
        return $"Name = {Name} , Age = {Age}";
    }

}

//Q3 Enum
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
//Q4 Enum
[Flags]
enum Permissions : byte
{
    delete = 1,   //0001
    Read = 2,     //0010
    Write = 4,    //0100
    Execute = 8    //1000
}

//Q5 Enum
enum Colors
{
    Red,
    Green,
    Blue
}

//Q6 Struct
struct Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public override string ToString()
    {
        return $"The point = ({X} , {Y})";
    }
}
internal class Program
{
    static Point CreateNewPoint()
    {
        Point point = new Point();
        Console.WriteLine("Please enter X");
        point.X = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter Y");
        point.Y = double.Parse(Console.ReadLine());
        return point;
    }
    static double CalculateDistance(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
    }

    static void Main(string[] args)
    {
        #region 1 - Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.
        //foreach(var day in Enum.GetValues(typeof(WeekDays)))
        //{
        //	Console.WriteLine(day);
        //}
        #endregion

        #region 2 - Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        //Person[] persons =
        //{
        //	new Person("Mariam",21),
        //	new Person("Ahmed" , 32),
        //	new Person("Menna", 40)
        //};
        //foreach(var person in persons)
        //{
        //	Console.WriteLine(person);
        //}
        #endregion

        #region 3 - Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        //Console.WriteLine("Please enter a season name");
        //string seasonName = Console.ReadLine();
        //Season season;
        //if(Enum.TryParse(seasonName,out season))
        //{
        //	switch(season)
        //	{
        //		case Season.Spring:
        //			Console.WriteLine("Months from march to may");
        //			break;
        //		case Season.Summer:
        //			Console.WriteLine("Months from june to august");
        //			break;
        //		case Season.Autumn:
        //			Console.WriteLine("Months from september to november");
        //			break;
        //		case Season.Winter:
        //			Console.WriteLine("Months from december to feburary");
        //			break;
        //	}
        //}
        //else
        //{
        //	Console.WriteLine("Invalid Input!!");
        //}
        #endregion

        #region  4 - Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        //Permissions permissions = Permissions.delete; // 0001
        //permissions ^= Permissions.Read;             // 0011
        //permissions |= Permissions.Write;            //0111
        //if((permissions&Permissions.Execute) == Permissions.Execute)
        //{
        //	Console.WriteLine("Permission is found");
        //}
        //else
        //{
        //	Console.WriteLine("Permission is not existed");
        //}
        #endregion

        #region 5 - Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        //Console.WriteLine("Please enter a color");
        //string input = Console.ReadLine();
        //Colors color;
        //if(Enum.TryParse(input,out color))
        //{
        //	Console.WriteLine("It's a primary color");
        //}
        //else
        //{
        //	Console.WriteLine("It's not a primary color");
        //}
        #endregion

        #region 6 - Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

        //Console.WriteLine("Please enter the first Point (X1,Y1)");
        //Point p1 =CreateNewPoint();
        //Console.WriteLine("Please enter the first Point (X1,Y1)");
        //Point p2 = CreateNewPoint();
        //double result = CalculateDistance(p1, p2);
        //Console.WriteLine($"The distance = {result}");
        #endregion

        #region 7 - Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        Person[] perons = new Person[3];
        for (int i = 0; i < 3; i++)
        {
            string name;
            do
            {
                Console.WriteLine($"Please enter the name for the person number {i + 1}");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            perons[i].Name = name;
            int age;
            bool flag;
            do
            {
                Console.WriteLine($"Please enter the age for the person number {i + 1}");
                flag = int.TryParse(Console.ReadLine(), out age);
            } while (!flag);
            perons[i].Age = age;
        }
        Person oldest = perons[0];
        for (int i = 0; i < 3; i++)
        {
            if (oldest.Age < perons[i].Age)
                oldest = perons[i];
        }
        Console.WriteLine(oldest);

        #endregion




        #region Permssion enum expalination 
        /*
         enum Permission : byte
     {
         delete = 1,   // 0001
         read = 2,     // 0010
         write = 4,    // 0100
         execute = 8   //1000
     }

         1) 0001 ^ 0010

     0001 delete
     0010 read 
     ---------
     0011 delete + read

    2) 0011 | 0100

     0011 delete + read
     0100 write 
     ---------
     0111 delete + read + write		
         1000
         ----------
         1111
         */
        #endregion

    }
}
