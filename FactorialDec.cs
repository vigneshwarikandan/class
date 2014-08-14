using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class FactorialDec
    {
        
        static void Main(string[] args)
        {
            int factorial = 1;
            Console.WriteLine("Enter a number");
            int num = ISSConsole.ReadInt();
            for (int i = num; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("The factorial is {0}",factorial);
        }
    }
}
