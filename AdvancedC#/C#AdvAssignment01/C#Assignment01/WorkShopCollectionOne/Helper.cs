using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopCollectionOne
{
	public static class Helper
	{
		//1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
		public static void CheckGreaterThanX(int[]numbers , int numOfQueries)
		{
			for(int i = 0;i < numOfQueries; i++)
			{
				int x;
				do
				{
					Console.WriteLine("Please enter the target X");
				} while (!int.TryParse(Console.ReadLine(), out x));
				int cnt = 0;
				for(int j = 0; j < numbers.Length; j++)
				{
					if (x < numbers[j])
						cnt++;
				}
				Console.WriteLine($"there is {cnt} numbers that is greater than x");
			}
		}
		//2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
		public static bool IsPlaindrome(int[] numbers , int n)
		{
			bool plaindrome = true;
			for(int i = 0; i < numbers.Length/2; i++)
			{
				if (numbers[i] != numbers[numbers.Length - i - 1])
				{
					plaindrome = false;
					break;
				}
			}
			return plaindrome;
		}
 		//3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
		public static Queue ReverseQueue(Queue inputQueue)
		{
			Stack tempStack = new Stack();
			int n = inputQueue.Count;
			while(inputQueue.Count > 0)
			{
				tempStack.Push(inputQueue.Dequeue());
			}
			while (tempStack.Count > 0)
			{
				inputQueue.Enqueue(tempStack.Pop());
			}
			return inputQueue;
		}

		//4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
		private static bool IsPair(char open , char close)
		{
			if (open == '(' && close == ')')
				return true;
			else if (open == '[' && close == ']')
				return true;
			else if (open == '{' && close == '}')
				return true;
			return false;
		}
		public static bool AreBalanced(string exp)
		{
			Stack<char> stack = new Stack<char>();
		    int length = exp.Length;
			for (int i = 0; i < length; i++)
			{
				if (exp[i] == '(' || exp[i] == '[' || exp[i] == '{')
					stack.Push(exp[i]);
				else if (exp[i] == ')' || exp[i] == ']' || exp[i] == '}')
				{
					if (stack.Count == 0 || !IsPair(stack.Peek(), exp[i]))
						return false;
					else
						stack.Pop();
				}
			}
			return stack.Count == 0 ? true : false;
		}
		//5. Given an array, implement a function to remove duplicate elements from an array.
		public static int[] RemoveDuplicate(int[] arr)
		{
			HashSet<int> values = new HashSet<int>(arr);
			arr = values.ToArray();
			return arr;
		}
		//6. Given an array list , implement a function to remove all odd numbers from it.
		public static void RemoveOddElements(ArrayList list)
		{
			for(int i = 0; i < list.Count; i++)
			{
				if ((int?)list[i] % 2 == 1)
					list.RemoveAt(i);
			}
		}
		//7. Implement a queue that can hold different data types. 
		//And insert the following data:
		// queue.Enqueue(1)
		// queue.Enqueue(“Apple”)
		//queue.Enqueue(5.28)
		public static void CreateQueue()
		{
			Queue<object> queue = new Queue<object> ();
			queue.Enqueue(1);
			queue.Enqueue("Apple");
			queue.Enqueue(5.28);
			foreach (object item in queue)
				Console.Write(item + " ");
		}
		//8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
		public static void SearchTargetInStack(Stack<int>stack , int target)
		{
			bool flag = false;
			int cnt = 0;
			foreach(int item in stack)
			{
				cnt++;
				if(item == target)
				{
					flag = true;
					break;
				}
			}
			if (flag)
				Console.WriteLine($"Target was found successfully and the counter = {cnt}");
			else
				Console.WriteLine("Target was not found");
		}
		//9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
		public static int[] Intersection(int[] nums1 , int[] nums2)
		{
			Dictionary<int , int >countMap = new Dictionary<int, int> ();
			foreach(int num in nums1)
			{
				if(countMap.ContainsKey(num))
					countMap[num]++;
				else
					countMap[num] = 1;
			}
			List<int> intersection = new List<int>();
			foreach(int num in nums2)
			{
				if(countMap.ContainsKey(num) && countMap[num] > 0)
				{
					intersection.Add(num);
					countMap[num]--;
				}
			}
			return intersection.ToArray();
		}

		//10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
		public static int[] FindContSubarray(ArrayList arrayList , int target)
		{
			int n = arrayList.Count;
			int[] arr = (int[]) arrayList.ToArray(typeof(int));
			for(int start = 0; start < n; start++)
			{
				int currentSum = 0;
				for(int end = start; end < n; end++)
				{
					currentSum += arr[end];
					if(currentSum == target)
					{
						int[] result = new int[end - start + 1];
						Array.Copy(arr, start, result, 0, end - start + 1);
						return result;
					}
				}
			}
			return null!;

		}
		//11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
		public static void ReversekElements(Queue<int> queue, int k)
		{
			if(k <= 0 || k >= queue.Count)
			{
				throw new Exception("Invalid value for k ");
			}
			// 1 2 3 4 5
			Stack<int> stack = new Stack<int>();
			for(int i = 0; i < k; i++)
			{
				// 1 2 3 
				stack.Push(queue.Dequeue());
			}
			// 4 5 3 2 1 
			while(stack.Count > 0)
			{
				queue.Enqueue(stack.Pop());
			}
			for(int i = 0; i < queue.Count - k; i++)
			{
				// 3 2 1 4 5
				queue.Enqueue(queue.Dequeue());
			}
		}
	}
}
