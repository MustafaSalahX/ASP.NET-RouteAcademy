using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWorkShop
{
	/*
	 * 1.	The Bubble Sort algorithm has a time complexity of O(n^2) 
	 * in its worst and average cases, which makes it inefficient for
	 * large datasets. How we can optimise the Bubble Sort algorithm 
             And implement the code of this optimised bubble sort algorithm
	 */
	public static class OptimizedBubbleSort<T> where T : IComparable<T>
	{
		public static void Sort(T[] arr)
		{
			for(int i = 0; i < arr.Length; i++)
			{
				bool flag = false;
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j].CompareTo(arr[j + 1]) > 0)
					{
						(arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
						flag = true;
					}
				}
				if (!flag)
					break;

			}
		}
	}
}
