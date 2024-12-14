using System.Collections;

namespace GenericsWorkShop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * 1.	The Bubble Sort algorithm has a time complexity of O(n^2) 
			 * in its worst and average cases, which makes it inefficient for
			 * large datasets. How we can optimise the Bubble Sort algorithm 
				And implement the code of this optimised bubble sort algorithm
			 */

			//int[] arr = { 1, 5, 2, 3, 4, 7, 8, 10, 9 };
			//Console.WriteLine("Array before sorting");
			//foreach (int i in arr) Console.Write(i + " ");
			//OptimizedBubbleSort<int>.Sort(arr);
			//Console.WriteLine();
			//Console.WriteLine("Array After sorting");
			//foreach (int i in arr) Console.Write(i + " ");

			/*2.	create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
			Requirements:
			1.	Create a generic class named Range<T> where T represents the type of values.
			2.	Implement a constructor that takes the minimum and maximum values to define the range.
			3.	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
			4.	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
			5.	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
			*/

			//Range<int> range = new Range<int>(1, 5);
			//Console.WriteLine($"Id 3 is In Range ? --> {range.IsInRange(3)}");
			//Console.WriteLine($"Id 6 is In Range ? --> {range.IsInRange(6)}");
			//Console.WriteLine($"The Length = {range.Length()}");

			/*3.	You are given an ArrayList containing a sequence of elements. 
			 *      try to reverse the order of elements in the ArrayList 
			 *      in-place(in the same arrayList) without using
			 *      the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
			 */
			//var arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6 };
			//Console.WriteLine("ArrayList Before Reverse");
			//foreach(int i in arrayList)
			//	Console.Write(i + " ");
			//Console.WriteLine();
			//Helper.ReverseArrayList(arrayList);
			//Console.WriteLine("ArrayList After Reverse");
			//foreach (int i in arrayList)
			//	Console.Write(i + " ");

			/*
			4.	   You are given a list of integers. Your task is to find and return a
					new list containing only the even numbers from the given list.
			*/
			//List<int> myList = new List<int>();
			//List<int> result = new List<int>();
			//for (int i = 1; i < 6; i++)
			//{
			//	myList.Add(i);
			//}
			//// 1 2 3 4 5
			//result = Helper.GetEvenNumbers(myList);
			//foreach(int i in result)
			//{
			//	Console.Write(i + " ");
			//}

			/*5.	implement a custom list called FixedSizeList<T> with a predetermined capacity. 
			 *      This list should not allow more elements than its capacity and 
			 */
			//FixedSizeList<int> list = new FixedSizeList<int>(5);
			//list.Add(1);
			//list.Add(2);
			//list.Add(3);
			//list.Add(4);
			//list.Add(5);
			//foreach (int i in list)
			//{
			//	Console.Write(i + " ");
			//}
			//Console.WriteLine();
			//Console.WriteLine($"The element in index 2 is --> {list.Get(2)}");

			/*
			 * 6.	Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary
			 * */
			//string str = "mariam";
			//int indexResult = Helper.FindFirstIndex(str);
			//Console.WriteLine(indexResult);
		}
	}
}
