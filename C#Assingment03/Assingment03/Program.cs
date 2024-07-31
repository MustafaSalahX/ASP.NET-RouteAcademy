namespace Assingment03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("***********************MustafaSalah**********************");
            Console.WriteLine("***********************RouteAcademyC42*******************");
            Console.WriteLine("*********************************************************");
            #region Write a program that takes a number from the user then print yes

            //Console.WriteLine("Enter A Number : \n");

            //int num = int.Parse(Console.ReadLine());

            //if(num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");




            #endregion

            #region Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive

            //Console.WriteLine("Enter A Number : \n");
            //int num = int.Parse(Console.ReadLine());
            //if(num > 0)
            //{
            //    Console.WriteLine("Postive");
            //}
            //else if (num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("(Zero)");


            #endregion

            #region Write a program that takes 3 integers from the user then prints the max element and the min element.


            //Console.WriteLine("Enter the first Number :\n");
            //int fN1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number :\n");
            //int sN2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third Number : ");
            //int th3 = int.Parse(Console.ReadLine());

            //int max = Math.Max(fN1, Math.Max(sN2, th3));
            //int Min = Math.Min(fN1, Math.Min(sN2, th3));

            //Console.WriteLine($"Max ELEMENT = {max}, Min ELEMENT = {Min}");



            #endregion

            #region Write a program that allows the user to insert an integer number then check If a number is even or odd.


            //Console.WriteLine("Enter A Number : ");

            //int Checker = int.Parse(Console.ReadLine());

            //string result = Checker % 2 == 0 ? "Even" : "ODD";

            //Console.WriteLine(result);





            #endregion

            #region Write a program that takes character from the user then

            //Console.WriteLine("Enter A Character:\n");
            //char Ch = char.Parse(Console.ReadLine().ToLower());

            //if("aeiou".Contains(Ch))
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //    Console.WriteLine("consonant");



            #endregion

            #region Write a program that allows the user to insert an integer then print all numbers between 1 to that number.


            //Console.WriteLine("Enter A Number :\n");

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write($"{i}, ");
            //}


            #endregion

            #region Write a program that allows the user to insert an integer then //Write a program that allows the user to insert an integer then 

            //Console.WriteLine("Enter A Number :\n");

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{

            //    Console.WriteLine($"{i} * {num} = {i*num}");
            //}



            #endregion

            #region  Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter A Number:\n");

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 2; i < num; i+=2)
            //{
            //    Console.Write($"{i}, ");
            //}




            #endregion

            #region  Write a program that takes two integers then prints the power.


            //Console.WriteLine("Enter A Number:\n");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Power:\n");
            //int power = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Num : {num} ^ Power : {power} = {Math.Pow(num, power)}"); //Stole This one from Internet !




            #endregion

            #region Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] subjects = new int[5];
            //for (int i = 0; i < subjects.Length; i++)
            //{
            //    Console.WriteLine($"enter the Marks of subject {i +1}");
            //    subjects[i] = int.Parse(Console.ReadLine());
            //}
            //int total = 0;
            //foreach (var mark in subjects)
            //{
            //    total += mark;

            //}

            //int avg = total / subjects.Length;
            //Console.WriteLine($"Total = {total}\nAverage = {avg} \nPercentage = {avg}%");


            #endregion

            #region Write a program to input the month number and print the number of days in that month



            //Console.WriteLine("Enter a Month Number");

            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 2:
            //        Console.WriteLine("30 Days in This Month");
            //        break;
            //    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            //        Console.WriteLine("31 Days in This Month");
            //        break;
            //    case 4: case 6: case 9: case 11:
            //        Console.WriteLine("28 Days in This Month");
            //        break;
            //    default: 
            //        Console.WriteLine("RE Enter A Number Between 1 to 12");
            //        break;

            //}


            #endregion

            #region Write a program to create a Simple Calculator.


            //Console.WriteLine("Enter the first number");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Choose the Operator ( + , - , * , / )");
            //char op = char.Parse(Console.ReadLine());
            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine($"{num1} {op} {num2} = {num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{num1} {op} {num2} = {num1 - num2}");
            //        break;
            //    case '*':
            //    case 'x':
            //        Console.WriteLine($"{num1} {op} {num2} = {num1 * num2}");
            //        break;

            //    case '/':
            //        if (num2 == 0)
            //            Console.WriteLine("infinity");
            //        else
            //            Console.WriteLine($"{num1} {op} {num2} = {num1 / num2}");
            //        break;
            //    default:
            //        Console.WriteLine("RE Enter An Operator from Above !!");
            //        break;
            //}



            #endregion

            #region Write a program to allow the user to enter a string and print the REVERSE of it.


            //Console.WriteLine("Enter a string");

            //string word = Console.ReadLine();

            //for (int i = word.Length-1;  i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}


            #endregion

            #region Write a program to allow the user to enter int and print the REVERSED of it


            //Console.WriteLine("Enter A Number");
            //int num = int.Parse(Console.ReadLine()); // 231

            //int reversedNumber = 0;
            //int reminder;
            //I Couldnt Solve This .. 



            #endregion

            #region Write a program in C# Sharp to find prime numbers within a range of numbers.



            #endregion

            #region Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.WriteLine("please enter a number : ");

            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine(Convert.ToString(number, 2));



            #endregion

            #region Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.









            #endregion

            #region Within a company, the efficiency of workers is


            //Console.WriteLine("Enter WorkingHours  :");

            //double Hours = double.Parse(Console.ReadLine());

            //if( Hours < 2 )
            //{
            //    Console.WriteLine("Wrong input");
            //}

            //if(Hours >= 2 && Hours <= 3)
            //    Console.WriteLine("Highly efficient");
            //else if(Hours <= 4)
            //    Console.WriteLine("Instructed to increase their speed");
            //else if(Hours <= 5)
            //    Console.WriteLine("Provided with training to enhance their speed");
            //else if (Hours > 5)
            //    Console.WriteLine("Leave The Company");


            #endregion

        }
    }
}
