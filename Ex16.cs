using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string username=ISSConsole.ReadString();
            Console.WriteLine("Enter your gender as M or F");
            char gender = ISSConsole.ReadChar();
            if (gender == 'M')
            {
                Console.WriteLine("Good morning Mr.{0}", username);
            }
            else
            {
                Console.WriteLine("Good morning Ms.{0}", username);
            }
        }
    }
}
