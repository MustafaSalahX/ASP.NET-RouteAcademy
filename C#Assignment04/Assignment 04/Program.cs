using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("***********************MustafaSalah**********************");
            Console.WriteLine("***********************RouteAcademyC42*******************");
            Console.WriteLine("*********************************************************");
            #region  Write a program that prints an identity matrix using for loop,

            //Console.WriteLine("Enter the size of the matrix: ");

            //int size = int.Parse(Console.ReadLine());

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if(i == j)
            //            Console.Write($"{1} ");
            //        else
            //            Console.Write($"{0} ");
            //    }
            //    Console.WriteLine("");
            //}

            //int[,] arr = new int[size,size];

            //for (int i = 0; i < size; i++)
            //{
            //    arr[i, i] = 1;
            //}
            //int counter = 0;
            //foreach (int i in arr)
            //{
            //    if(counter % size == 0)
            //        Console.WriteLine("");

            //    Console.Write($"{i} ");
            //    counter++;

            //}






            #endregion

            #region Write a program in C# Sharp to find the sum of all elements of the array.


            //Console.WriteLine("Enter the size of the array :");

            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"enter number {i + 1} in the array");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;

            //foreach (var item in arr)
            //{
            //    sum += item;
            //}

            //Console.WriteLine(sum);
            //// OR
            //sum = arr.Sum();

            //Console.WriteLine(sum);



            #endregion

            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr1 = { 1, 5, 3, 4 };
            //int[] arr2 = { 2, 6, 8, 7 };

            //int[] totalArray = new int[arr1.Length + arr2.Length];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    totalArray[i] = arr1[i];

            //}


            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    totalArray[i + arr1.Length] = arr2[i];

            //}

            //int temp;
            //for (int i = 0; i < totalArray.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < totalArray.Length; j++)
            //    {
            //        if (totalArray[i] > totalArray[j])
            //        {
            //            temp = totalArray[i];
            //            totalArray[i] = totalArray[j];
            //            totalArray[j] = temp;
            //        }
            //    }

            //}


            //Console.WriteLine(string.Join(", ", totalArray));


            #endregion

            #region Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arr = { 1, 8, 2, 6, 9, 8, 4, 8, 5, 4, 7, 7 };

            //Dictionary<int, int> frequency = new Dictionary<int, int>();
            //foreach (var num in arr)
            //{
            //    if(frequency.ContainsKey(num))
            //        frequency[num]++;
            //    else
            //        frequency[num] = 1;

            //}

            //foreach (var item in frequency)
            //{
            //    Console.WriteLine($"Element {item.Key} occurs {item.Value} Times");
            //}

            //OR

            //int[] frequency = new int[arr.Length];
            //bool[] visited = new bool[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (visited[i])
            //        continue;
            //    int counter = 1;
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            counter++;
            //            visited[j] = true;
            //        }


            //    }
            //    frequency[i] = counter;
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!visited[i])
            //        Console.WriteLine($"Element {arr[i]} occurs {frequency[i]} times");
            //}



            #endregion

            #region Write a program in C# Sharp to find maximum and minimum element in an array


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //int max = arr[0];
            //int min = arr[0];

            //foreach (var element in arr)
            //{
            //    if (element > max)
            //        max = element;
            //    if (element < min) 
            //        min = element;
            //}

            //Console.WriteLine($"Max Number = {max}, Min number = {min}");



            #endregion

            #region Write a program in C# Sharp to find the second largest element in an array.


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 13,8, 9, 10, 11, 12, 14 };

            //int max = arr[0];
            //int SecondMax = arr[0];
            //foreach (int i in arr)
            //{
            //    if (i > max) 
            //    {
            //        SecondMax = max;
            //        max = i;       
            //    }
            //    if(i > SecondMax && i != max)
            //        SecondMax = i;
            //}
            //Console.WriteLine(SecondMax);

            #endregion

            #region Consider an Array of Integer values with size N, having values as


            //int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //int dist = 0;
            //for(int i = 0 ; i < arr.Length; i++)
            //{
            //    for (int j = i +1; j < arr.Length; j++)
            //    {
            //        if(arr[i] == arr[j] )
            //            if(dist < j-i-1)
            //                dist = j-i-1;
            //    }
            //}

            //Console.WriteLine($"distance ={dist}");






            #endregion

            #region Given a list of space separated words, reverse the order of the words.


            //Console.WriteLine("Enter Words Separated With Space: ");

            //string[] strings = Console.ReadLine().Split(' ');

            //for (int i = strings.Length -1; i >=0 ; i--)
            //{
            //    Console.Write($"{strings[i]} ");
            //}




            #endregion

            #region Write a program to create two multidimensional arrays of same size. Accept value from user



            //Console.WriteLine("Enter the size of the array :");

            //int size = int.Parse(Console.ReadLine());

            //int[] arr1 = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"enter number {i + 1} in the array");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arr2 = new int[arr1.Length];

            //for (int i = 0;i < arr1.Length; i++)
            //{
            //    arr2[i] = arr1[i];
            //}

            //Console.WriteLine(string.Join(", ", arr2));


            #endregion

            #region Write a Program to Print One Dimensional Array in Reverse Order


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //for (int i = arr.Length -1; i >= 0 ; i--)
            //{
            //    Console.Write($"{arr[i]}, ");

            //}




            #endregion
            //General
            #region Write a program that calculates the simple interest given the  principal amount, rate of interest, and time.

            //double principal = 5000.0;
            //double rate = 13.5;
            //double time = 6.0;

            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest);

            #endregion
            #region Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters.
            //double weight = 76;
            //double height = 1.80;
            //double bmi = weight / Math.Pow(height, 2);
            //Console.WriteLine(bmi);

            #endregion
            #region Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            //Console.WriteLine("Temprature = ");
            //double temp = double.Parse(Console.ReadLine());
            //string result = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
            //Console.WriteLine(result);

            #endregion
            #region Write a program that takes the date from the user and displays it in various formats using string interpolation.

            //DateTime dateTime = new DateTime(2001, 11, 20);

            //Console.WriteLine($"Today’s date : {dateTime.Day} , {dateTime.Month} , {dateTime.Year}");
            //Console.WriteLine($"Today’s date : {dateTime.Day} / {dateTime.Month} / {dateTime.Year}");

            //Console.WriteLine($"Today’s date : {dateTime.Day} - {dateTime.Month} - {dateTime.Year}");



            #endregion
            #region What is the output of the following C# code?
            //a) The event is on 14/06/2024



            #endregion
        }
    }
}
