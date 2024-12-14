using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
	internal class Point3D : IComparable , ICloneable
	{
		private int x; 
		private int y; 
		private int z;

        public int X { get { return x; } set { x = value; } }
		public int Y { get { return y; } set { y = value; } }
		public int Z { get { return z; } set { z = value;  } }

        public Point3D(int X , int Y , int Z)
        {
            this.X = X;
			this.Y = Y;
			this.Z = Z;
        }
        public Point3D(int X , int Y) : this(X , Y , 0)
        {
            
        }
        public Point3D(Point3D point)
        {
            X = point.X;
            Y = point.Y;
            Z = point.Z;
        }
        public override string ToString()
        {
            return $"Point Coordinates : ({X},{Y},{Z})";
        }
        public static Point3D InputPoint()
        {
            int x, y, z;
            do
            {
                Console.WriteLine("Please enter X :");

            } while (!int.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.WriteLine("Please enter Y :");

            } while (!int.TryParse(Console.ReadLine(), out y));
            do
            {
                Console.WriteLine("Please enter Z :");

            } while (!int.TryParse(Console.ReadLine(), out z));
            return new Point3D(x, y, z);
        }
        public static void PrintArray(Point3D[] points)
        {
            for(int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);
            }
        }
        public static void SortArray(Point3D[] points)
        {
            Array.Sort(points);
        }

        public int CompareTo(object? obj)
        {
            Point3D p = (Point3D)obj;
            if (x > p.x)
                return 1;
            else if (x < p.x)
                return -1;
            else
            {

                if (y > p.y)
                    return 1;
                else if(y < p.y)
                    return -1;
                return 0;
            }
        }

        public object Clone()
        {
            return new Point3D(this);
        }

        public static bool operator == (Point3D point1 , Point3D point2)
        {
            return point1.x == point2.x && point1.y == point2.y && point1.z == point2.z;
        }
        public static bool operator !=(Point3D point1, Point3D point2)
        {
            return point1.x != point2.x || point1.y != point2.y || point1.z != point2.z;
        }
    }
}
