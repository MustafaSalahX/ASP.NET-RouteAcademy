using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWorkShop
{
	public static class Helper
	{
		/*3.	You are given an ArrayList containing a sequence of elements. 
		 *      try to reverse the order of elements in the ArrayList 
		 *      in-place(in the same arrayList) without using
		 *      the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
		 */
		public static void ReverseArrayList(ArrayList arrayList)
		{
			int left = 0 , right = arrayList.Count-1;
			while(left < right)
			{
				object temp = arrayList[left];
				arrayList[left] = arrayList[right];
				arrayList[right] = temp;
				left++;
				right--;
			}
		}
		/*
		4.	You are given a list of integers. Your task is to find and return a
		new list containing only the even numbers from the given list.
		*/
		public static List<int> GetEvenNumbers(List<int> list)
		{
			List<int> result = new List<int>();
			foreach(int i in list)
			{
				if(i%2 ==0)
					result.Add(i);
			}
			return result;
		}
		/*
        * 6.	Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary
        */
		public static int FindFirstIndex(string str)
		{
			Dictionary<char, int> result = new Dictionary<char, int>();
			foreach(char c in str)
			{
				if (result.ContainsKey(c))
				{
					result[c]++;
				}
				else
				{
					result[c] = 1;
				}
			}
			for(int i =0; i < str.Length; i++)
			{
				if (result[str[i]] == 1)
					return i;
			}
			return -1;
		}
	}
}
