using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex24
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter a number to find square root");
            //Random r = new Random();
            //Console.Write("Random"+r.Next(9));
            n = ISSConsole.ReadInt();
            int g = ISSMath.RNDInt(n);
            int sqrt;
            while (g * g != n)
            {
                g = (g + (n / g)) / 2;

            }
            sqrt = g;            
            Console.WriteLine("The square root of {0} is {1}", n, sqrt);
        }
    }
}
