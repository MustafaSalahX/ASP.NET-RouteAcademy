using System.Collections;

namespace WorkShopCollectionTwo
{
	public static class Helper
	{
		//1.	Given an array of integers, count the frequency of each element using a hash table.
		public static object CountFrequencies(int[] arr)
		{
			Hashtable freq = new Hashtable();
			if(arr is not null)
			{
				for(int i = 0; i < arr.Length; i++)
				{
					if (freq.ContainsKey(arr[i]))
						freq[arr[i]] = (int)freq[arr[i]] + 1;
					else
						freq[arr[i]] = 1;
				}
			}
			return freq;
		}
		//2.	You have a hashtable where its values are integers, find the key associated with the highest value.
		public static object FindKeyWithHighstValue(Hashtable hashtable)
		{
			if (hashtable.Count == 0)
				return "HashTable is empty";
			object keyWithHighstValue = null!;
			int highestValue = int.MinValue;
			foreach(DictionaryEntry item in hashtable)
			{
				if((int)item.Value > highestValue)
				{
					highestValue = (int)item.Value;
					keyWithHighstValue = item.Key;
				}
			}
			return keyWithHighstValue;
		}

		//3.	You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue
		//Note : if the targetValue not found print(“Key not found”)
		public static void FindKeyByValue(Hashtable hashtable , string targetValue)
		{
			bool found = false;
			foreach(DictionaryEntry item in hashtable)
			{
				if(item.Value.ToString() == targetValue)
				{
					Console.WriteLine($"item Key --> {item.Key}");
					found = true;
				}
			}
			if (!found)
				Console.WriteLine("The key not found");
		}
		//4.	Given an array of strings, group anagrams together.
		public static List<List<string>> GroupAnagrams(string[] strs)
		{
			Dictionary<string, List<string>> angramGroups = new Dictionary<string, List<string>>();
			foreach(string str in strs)
			{
				char[] chars = str.ToCharArray();
				Array.Sort(chars);
				string sortedStr = new string (chars);
				if (!angramGroups.ContainsKey(sortedStr))
				{
					angramGroups[sortedStr] = new List<string>();
				}
				angramGroups[sortedStr].Add(str);
			}
			return angramGroups.Values.ToList();
		}

		//5.	Given an array of integers, check if the array contains any duplicates.
		public static bool ContainsDuplicates(int[] arr)
		{
			HashSet<int> numSet = new HashSet<int>();
			foreach(int i in arr)
			{
				if (numSet.Contains(i))
					return true;
				numSet.Add(i);
			}
			return false;
		}
		//6.	Implement a SortedDictionary that stores student IDs (int) and their names (string). Perform operations like adding, removing, and retrieving student names.
		public static void CreateStudents()
		{
			SortedDictionary<int,string> students = new SortedDictionary<int,string>();
			students.Add(1111, "Mariam");
			students.Add(2222, "Omnia");
			students.Add(3333, "Amany");
			foreach (var student in students)
				Console.WriteLine($"ID --> {student.Key} , Name --> {student.Value}");
			students.Remove(3333);
			Console.WriteLine("After removing Amanay : ");
			foreach (var student in students)
				Console.WriteLine($"ID --> {student.Key} , Name --> {student.Value}");
			if (students.TryGetValue(1111, out string str))
				Console.WriteLine($"Student with id 1111 found and his/her name --> {str}");
		}
		//7.	Create an employee directory where employee IDs (int) are keys and employee names (string) are values. Use a SortedList to manage and retrieve employees in order of their IDs.
		public static void CreateEmployees()
		{
			SortedList<int, string> employees = new SortedList<int, string>();
			employees.Add(1111, "Mariam");
			employees.Add(2222, "Omnia");
			employees.Add(3333, "Amany");
			
			foreach(var employee in employees)
				Console.WriteLine($"ID --> {employee.Key} , Name --> {employee.Value}");

			employees.Remove(2222);

			Console.WriteLine("After removing Amanay : ");
			foreach (var employee in employees)
				Console.WriteLine($"ID --> {employee.Key} , Name --> {employee.Value}");

			if(employees.TryGetValue(1111,out string str))
				Console.WriteLine($"Employee with id 1111 found and his/her name --> {str}");

		}
		//8.	Given an array of integers from 1 to N with some numbers missing, find the missing numbers.
		public static void FindMissingNumbers(int[] numbers , int n)
		{
			bool[] present = new bool[n + 1];
			foreach(int num in numbers)
				present[num] = true;
			List<int> missingNumbers = new List<int>();
			for ( int i = 1; i <=n; i++)
			{
				if (!present[i])
					missingNumbers.Add(i);
			}
			Console.WriteLine("The missing numbers are : ");
			foreach (int num in missingNumbers)
				Console.Write(num + " ");
		}
		//9.	You  have a list of integers with possible duplicates, create a HashSet that contains only unique values.
		public static void UniqueValues(List<int> list)
		{
			Console.WriteLine("The original list : ");
			foreach (int item in list)
				Console.Write(item + " ");
			HashSet<int> unique = new HashSet<int>(list);
			Console.WriteLine();
			Console.WriteLine("The unique elements list : ");
			foreach (int item in unique)
				Console.Write(item + " ");
		}
		//10.	You have a hashtable with unique values, create a new hashtable where the keys and values are swapped.
		public static void SwapElements(Hashtable hashtable)
		{
			Hashtable swappedHashTable = new Hashtable();
			Console.WriteLine("The hashtable before swapping");
			foreach (DictionaryEntry entry in hashtable)
				Console.WriteLine($"({entry.Key} , {entry.Value})");
			foreach(DictionaryEntry entry in hashtable)
			{
				if(entry.Value is not null)
					swappedHashTable.Add(entry.Value,entry.Key);	
			}
			Console.WriteLine("The hashtable after swapping");
			foreach (DictionaryEntry entry in swappedHashTable)
				Console.WriteLine($"({entry.Key} , {entry.Value})");
		}
		
		
		//11.   Find the union of two sets, returning the unique elements from both sets.
		public static void FindUnion(HashSet<int> set1 , HashSet<int> set2)
		{
			HashSet<int> union = new HashSet<int>(set1);	
			union.UnionWith(set2);
			Console.WriteLine("The hashset after union : ");
			foreach (int item in union)
				Console.Write(item + " ");
		}
		//12.	You have a dictionary with string keys, the user will enter targetChar , count how many keys start with this targetChar.
		public static void CountTargetChar(Dictionary<string,int> myDictionary , char target)
		{
			int cnt = 0;
			foreach(var key in myDictionary.Keys)
			{
				if (key.StartsWith(Char.ToUpper(target)) || key.StartsWith(Char.ToLower(target)))
					cnt++;
			}
			Console.WriteLine($"There is {cnt} strings that start with {target}");
		}
		//13.	You have a sorted set , user will enter an integer target, find all elements that is greater than target and add them in list.
		public static void FindGreater (SortedSet<int> sortedSet , int target)
			{
			 List<int> result = new List<int> ();
			foreach (int item in sortedSet)
			{
				if (item > target)
					result.Add(item);
			}
			if(result.Count > 0)
			{
				foreach (var item in result)
					Console.Write(item + " ");
			}
			else
			{
				Console.WriteLine("There is no element > target in sorted set");
			}
			}
		//14.   You have a sorted list with integer values, find all the keys associated with even values.
		public static void FindKeysWithEvenValues(SortedList<int,int> sortedList)
		{
			List<int> result = new List<int>();
			foreach(KeyValuePair<int,int> element in sortedList)
			{
				if (element.Value % 2 == 0)
					result.Add(element.Key);
			}
			if (result.Count > 0)
			{
				Console.WriteLine("The keys asscoiated with even values");
				foreach (int item in result)
					Console.Write(item + " ");
			}
			else
			{
				Console.WriteLine("No even values found in the sorted list");
			}
		}


	}

}
