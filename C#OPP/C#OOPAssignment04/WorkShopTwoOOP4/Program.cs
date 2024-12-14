using FirstProject;
using System.Drawing;

namespace WorkShopTwoOOP4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region == Operator
			//Console.WriteLine("Please enter the corrdinates of first point P1:");
			//Point3D point1 = Point3D.InputPoint();
			//         Console.WriteLine("Please enter the corrdinates of second point P2:");
			//         Point3D point2 = Point3D.InputPoint();

			//Console.WriteLine(point1);
			//Console.WriteLine(point2);

			//if(point1 == point2)
			//{
			//	Console.WriteLine("The 2 points are equal");
			//}
			//else
			//{
			//	Console.WriteLine("The 2 points are not equal");
			//} 
			#endregion
			#region Array

			//int size;
			//do
			//{
			//	Console.WriteLine("Please enter the size of the array");
			//}while(!int.TryParse(Console.ReadLine(), out size) && size <= 0);

			//Point3D[] points = new Point3D[size];
			//for(int i = 0; i < size; i++)
			//{
			//	Console.WriteLine($"Please enter the coordinates for point {i+1}");
			//	points[i] = Point3D.InputPoint();
			//}
			//Console.WriteLine("***************************");
			//Console.WriteLine("Array before sorting");
			//         Point3D.PrintArray(points);
			//         Console.WriteLine("***************************");
			//Point3D.SortArray(points);
			//         Console.WriteLine("Array after sorting");
			//         Point3D.PrintArray(points); 
			#endregion
			#region Clone
			//Point3D point1 = new Point3D(1, 2, 3);
			//Point3D point2 = (Point3D)point1.Clone();
			//Console.WriteLine($"{point1}");
			//Console.WriteLine($"{point2}"); 
			#endregion
		}
    }
}
