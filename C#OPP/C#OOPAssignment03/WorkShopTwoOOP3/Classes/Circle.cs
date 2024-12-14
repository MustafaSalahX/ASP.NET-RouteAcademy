using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopTwoOOP3.Interfaces;

namespace WorkShopTwoOOP3.Classes
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The raidus = {Radius} and the area = {Area}");
        }
    }
}
