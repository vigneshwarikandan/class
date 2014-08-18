using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex40Sqrt
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                System.Console.WriteLine(findSqrt(i));
            }
        }

        static double findSqrt(int number)
        {
            return Math.Sqrt(number);
        }
    }
}
