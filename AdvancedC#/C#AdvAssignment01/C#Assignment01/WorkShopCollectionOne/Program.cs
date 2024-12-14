using System.Collections;

namespace WorkShopCollectionOne
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
			//int[] nums = { 1, 2, 3, 4, 5 };
			//int numOfQueries = 3;
			//Helper.CheckGreaterThanX(nums, numOfQueries);


			//2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
			//int[] nums = { 1, 2, 3, 2, 1 };
			//int n = nums.Length;
			//bool result = Helper.IsPlaindrome(nums, n);
			//Console.WriteLine($"Is the array plaindrome ? --> {result}");


			//3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
			//   Queue inputQueue = new Queue();
			//for (int i = 1; i <= 10 ; i++)
			//{
			//	inputQueue.Enqueue(i);
			//}
			//inputQueue = Helper.ReverseQueue(inputQueue);
			//Console.WriteLine("Queue after reversing using stack : ");
			//foreach(int i in inputQueue)
			//	Console.Write(i + " ");


			//4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
			//string str = "{{[]}}";
			//bool result = Helper.AreBalanced(str);
			//Console.WriteLine($"Is the expression balanced ? --> {result}");


			//5. Given an array, implement a function to remove duplicate elements from an array.
			//int[] arr = { 1, 2, 4, 2, 1, 4, 5 };
			//arr = Helper.RemoveDuplicate(arr);
			//foreach(int i in arr)
			//{
			//	Console.Write(i + " ");
			//}


			//6. Given an array list , implement a function to remove all odd numbers from it.
			//ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			//Helper.RemoveOddElements(list);
			//foreach(int i in list)
			//	Console.Write(i + " ");


			//7. Implement a queue that can hold different data types. 
			//Helper.CreateQueue();


			//8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
			//Stack<int> stack = new Stack<int>();
			//for(int i = 1; i <= 10; i++)
			//{
			//	stack.Push(i);
			//}
			//int target;
			//do 
			//{
			//	Console.WriteLine("Please enter target to search in stack");
			//}while(!int.TryParse(Console.ReadLine(), out target));

			//Helper.SearchTargetInStack(stack, target);


			//9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
			//int[] nums1 = { 1, 2, 3, 4, 4 };
			//int[] nums2 = { 5, 4, 4 };
			//int[]res = Helper.Intersection(nums1 , nums2);
			//foreach(int i in res)
			//	Console.Write(i + " ");

			//10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
			//ArrayList list = new ArrayList() { 1, 5, 20, 3, 50, 14 };
			//int tagretSum = 25;
			//int[] res = Helper.FindContSubarray(list, tagretSum);
			//Console.WriteLine("The subarray : ");
			//foreach(int i in res)
			//	Console.Write(i + " ");


			//11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
			//Queue<int> queue = new Queue<int>();
			//for(int i = 1; i <=5;i++)
			//	queue.Enqueue(i);
			//int k = 3;
			//Helper.ReversekElements(queue, k);
			//Console.WriteLine($"Queue after reverse first {k} elements");
			//foreach(int i in queue)
			//	Console.Write(i + " ");

		}
	}
}
