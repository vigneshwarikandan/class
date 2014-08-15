using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex27
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the value of x");
            //double x = ISSConsole.ReadDouble();
            for (int i = -10; i < 0; i++)
            {
                double y = 5 * Math.Pow(i, 2) - 4 * i + 3;
                Console.WriteLine("The value of y is " + y);
            }

            Console.WriteLine("**************");
            for (int j = 0; j < 10; j++)
            {
                double y = 5 * Math.Pow(j, 2) - 4 * j + 3;
                Console.WriteLine("The value of y is " + y);
            }
            
        }
    }
}
