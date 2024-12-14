using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopTwoOOP3.Interfaces;

namespace WorkShopTwoOOP3.Classes
{
    public class Rectangle : IRectangle
    {
        public double Length { set; get; }
        public double Width { set; get; }

        public double Area
        {
            get { return Length * Width;}
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The length = {Length} and width = {Width} and the area = {Area}");
        }
    }
}
