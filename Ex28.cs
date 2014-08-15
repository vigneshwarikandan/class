using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex28
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check prime");
            int number = ISSConsole.ReadInt();
            bool prime = true;
            for (int i = 2; i < number; i++)
            {

                if(number%i==0)
                {

                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
