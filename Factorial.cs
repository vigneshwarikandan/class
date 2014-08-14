using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for factorial");
            int number = ISSConsole.ReadInt();
            int factorial = 1;
            for (int i = 1; i <=5; i++)
            {                
                factorial = factorial * i;
            }
            Console.WriteLine("The factorial is {0}", factorial);
        }
    }
}
