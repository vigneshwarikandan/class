using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex21
    {
        static void Main(string[] args)
        {
            //do while
            int number=0;
            do
            {
                Console.WriteLine("Enter a number");
                number = ISSConsole.ReadInt();
                
            } while (number != 88);
            Console.WriteLine("Lucky you");
        }
    }
}
