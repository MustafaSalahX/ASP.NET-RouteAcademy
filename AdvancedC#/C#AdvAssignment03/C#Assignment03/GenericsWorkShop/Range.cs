using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWorkShop
{
	/*2.	create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
     Requirements:
     1.	Create a generic class named Range<T> where T represents the type of values.
     2.	Implement a constructor that takes the minimum and maximum values to define the range.
     3.	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
     4.	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
     5.	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
	 */
	public class Range<T> where T : IComparable<T>
	{
        public T Max { get; set; }
        public T Min { get; set; }
        public Range(T min , T max)
        {
            Max = max;
            Min = min;
        }
        public bool IsInRange(T num)
        {
            return num.CompareTo(Min) > 0 && num.CompareTo(Max) <= 0;
        }
        public T Length()
        {
            dynamic a = Max;
            dynamic b = Min;
            return a - b;
        }

    }
}
