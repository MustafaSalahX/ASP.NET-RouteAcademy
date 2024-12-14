using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
	internal static class Math
	{
        #region Methods Non static
        //public int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public int Subtract(int x, int y)
        //{
        //    return x - y;
        //}
        //public int Multiply(int x, int y)
        //{
        //    return x * y;
        //}
        //public int Divide(int x, int y)
        //{
        //    if (y == 0)
        //        return -1;
        //    return x / y;
        //} 
        #endregion

        #region Static Methods
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if (y == 0)
                return -1;
            return x / y;
        }
        #endregion
    }
}
