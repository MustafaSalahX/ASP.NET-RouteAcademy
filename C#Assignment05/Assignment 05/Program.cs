using System.Drawing;

namespace Assignment_05
{

    #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

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
 

    #endregion

    #region  Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

    public struct Person
    {
        //MustafaSalah C42
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Person:\n Name : {Name} , Age : {Age} ";
        }

        public static Person GetPersonValues()
        {
            Person person = new Person();
            Console.WriteLine("Please Enter the Name of the person");
            person.Name = Console.ReadLine();

            Console.WriteLine("Please Enter the Age of the person");

            int.TryParse(Console.ReadLine(), out int age);
            person.Age = age;
            return person ;

        }


        public static Person[] CreatePersonArray(int size)
        {

            Person[] people = new Person[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter THe Data of The Person Number {i+1}");
                people[i] = GetPersonValues();

            }
            return people ;

        }

        public static Person GetOldest(Person[] arr)
        {
            Person Oldest = arr[0];
            for (int i =1; i<arr.Length;i++ )
            {
                if(Oldest.Age < arr[i].Age)
                    Oldest = arr[i];

            }
            return Oldest;
        }


    }

    #endregion

    #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    #endregion

    #region  Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
    // 
    // Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
    [Flags]
    enum Permission : byte
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8,
    }



    #endregion

    #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

    enum Colors
    {
        Red,
        Green,
        Blue,
    }


    #endregion

    #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

    public struct Point
    {
        public Point(int x, int y)
        {
            X= x; 
            Y=y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public double DistanceBetweenToPoints(Point point)
        {
            return Math.Abs(Math.Sqrt(Math.Pow((this.X - point.X), 2) + Math.Pow((this.Y - point.Y), 2)));
        }

        public static double Distance(Point point, Point point1)
        {
            return Math.Abs(Math.Sqrt(Math.Pow((point1.X - point.X), 2) + Math.Pow((point1.Y - point.Y), 2)));

        }
    }


    #endregion

    #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.



    #endregion
    internal class Program
    {
        #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

       

        #endregion
        static void Main(string[] args)
        {

            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] people =
            //{
            //    new Person("Mustafa", 24),
            //    new Person("Salah", 30),
            //    new Person("Rena", 39)
            //};

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person.ToString());

            //}



            #endregion

            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("please enter a season name: ");

            //string input = Console.ReadLine();

            //if(Enum.TryParse(input, out Season result))
            //{
            //    switch (result)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Range : march to may");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Range : june to augest");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Range : sep to Nov");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Range : Dec to feb");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input");
            //            break;
            //    }
            //}


            #endregion

            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Console.WriteLine("Please add a permission :");

            //Permission MyP, userP, hasP;

            //Enum.TryParse<Permission>(Console.ReadLine(), true, out MyP);

            //while (true)
            //{
            //    Console.WriteLine("do u want to add or delete a permission :");
            //    Enum.TryParse<Permission>(Console.ReadLine(), true, out userP);

            //    MyP ^= userP; // XOR ^ // OR |

            //    Console.WriteLine("Do you want to add or delete more  (Y , N):");

            //    if (Console.ReadLine() == "N")
            //        break;


            //}

            //Console.WriteLine("Write Permission name that you want to find :");
            //Enum.TryParse<Permission>(Console.ReadLine(), true, out hasP);


            //if ((MyP & hasP ) == hasP)
            //{
            //    Console.WriteLine("Permission is found");
            //}
            //else
            //    Console.WriteLine("404 , not found");




            #endregion
            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color to Check : ");



            //bool flag = Enum.TryParse(Console.ReadLine(), true, out Colors color);

            //if (flag)
            //{
            //    Console.WriteLine($"This is a Primary Color  and it is  {color}");
            //}
            //else
            //{ Console.WriteLine("Not a Primary Color"); }

            #endregion

            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point point1 = new Point(5, 10);
            //Point point2 = new Point(20, 13);

            //double distance = point1.DistanceBetweenToPoints(point2);
            //Console.WriteLine( $"The Distance Between Two Points = {Point.Distance(point1, point2)}");
            //Console.WriteLine($"The Distance Between Two Points = {distance}");


            #endregion

            #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] people = Person.CreatePersonArray(3);

            //var older = Person.GetOldest(people);
            //Console.WriteLine(older.ToString());

            #endregion
        }
    }
}
