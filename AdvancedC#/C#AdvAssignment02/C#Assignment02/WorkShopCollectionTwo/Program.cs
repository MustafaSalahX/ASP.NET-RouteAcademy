using System.Collections;
using System.Xml;

namespace WorkShopCollectionTwo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1.	Given an array of integers, count the frequency of each element using a hash table.
			//int[] arr = { 1, 2, 3, 2, 3, 1, 1, 1 };
			//Hashtable result = (Hashtable) Helper.CountFrequencies(arr);
			//foreach(DictionaryEntry pair in result)
			//{
			//	Console.WriteLine($"The Number {pair.Key} was found {pair.Value} times");
			//}

			//2.	You have a hashtable where its values are integers, find the key associated with the highest value.
			//Hashtable hashtable = new Hashtable
			// {
			//	 {"key1" , 10 },
			//	 {"key2" , 20 },
			//	 {"key3" , 30 }
			// };
			//var keyWithHighstValue = Helper.FindKeyWithHighstValue(hashtable);
			//Console.WriteLine($"the key associated with highst value {keyWithHighstValue}");

			//3.	You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue
			//Note : if the targetValue not found print(“Key not found”)
			//Hashtable hashtable = new Hashtable
			//{
			//	{"key1","apple" },
			//	{"key2" ,"banana" },
			//	{"key3" ,"apple" }
			//};
			//Helper.FindKeyByValue(hashtable, "apple");

			//4.	Given an array of strings, group anagrams together.
			//string[] str = { "loop", "pool", "eat", "tea", "silent", "listen" };
			//var groups = Helper.GroupAnagrams(str);
			//foreach (var group in groups)
			//{
			//	Console.WriteLine(string.Join(", ",group));
			//}

			//5.	Given an array of integers, check if the array contains any duplicates.
			//int[] arr = { 1, 2, 3, 1, 4, 2 };
			//bool isDuplicated = Helper.ContainsDuplicates(arr);
			//Console.WriteLine($"is the array contains duplicate elements? --> {isDuplicated}");

			//6.	Implement a SortedDictionary that stores student IDs (int) and their names (string). Perform operations like adding, removing, and retrieving student names.
			//Helper.CreateStudents();

			//7.	Create an employee directory where employee IDs (int) are keys and employee names (string) are values. Use a SortedList to manage and retrieve employees in order of their IDs.
			//Helper.CreateEmployees();

			//8.	Given an array of integers from 1 to N with some numbers missing, find the missing numbers.
			//int[] numbers = { 1, 2, 4, 6 };
			//int n = 10;
			//Helper.FindMissingNumbers(numbers, n);

			//9.	You  have a list of integers with possible duplicates, create a HashSet that contains only unique values.
			//List<int> myList = new List<int> { 1, 2, 3, 2, 4, 1, 3, 5, 6, 4 };
			//Helper.UniqueValues(myList);

			//10.	You have a hashtable with unique values, create a new hashtable where the keys and values are swapped.
			//Hashtable myHashTable = new Hashtable
			//{
			//	{"One",1 },
			//	{"Two",2 },
			//	{"Three",3 },
			//	{"Four",4 }
			//};
			//Helper.SwapElements(myHashTable);

			//11.   Find the union of two sets, returning the unique elements from both sets.
			//HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
			//HashSet<int> set2 = new HashSet<int> { 6, 7, 8, 9, 10 };
			//Helper.FindUnion(set1 , set2);	

			//12.	You have a dictionary with string keys, the user will enter targetChar , count how many keys start with this targetChar.
			//Dictionary<string, int> myDictionary = new Dictionary<string, int>
			//{
			//	{"Apple",1 },
			//	{"Airport",2 },
			//	{"Animal",3 },
			//	{"Banana",3 }
			//};
			//char targetChar;
			//do
			//{
			//	Console.WriteLine("Please enter the tagrget char");
			//} while (!char.TryParse(Console.ReadLine(), out targetChar));
			//Helper.CountTargetChar(myDictionary, targetChar);

			//13.	You have a sorted set , user will enter an integer target, find all elements that is greater than target and add them in list.
			//SortedSet<int> sortedSet = new SortedSet<int> { 10, 20, 30, 40, 50 };
			//int target;
			//do
			//{
			//	Console.WriteLine("Please enter the target");
			//} while (!int.TryParse(Console.ReadLine(), out target));
			//Helper.FindGreater(sortedSet, target);

			//14.   You have a sorted list with integer values, find all the keys associated with even values.
			//SortedList<int, int> sortedList = new SortedList<int, int>
			//{
			//	{1,4 },
			//	{2,3 },
			//	{3,6 },
			//	{4,5 },
			//	{5,10 }
			//};
			//Helper.FindKeysWithEvenValues(sortedList);
		}
	}
}

