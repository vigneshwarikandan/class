using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string username = ISSConsole.ReadString();
            Console.WriteLine("Enter your gender");
            char gender=ISSConsole.ReadChar();
            Console.WriteLine("Enter your age");
            int age = ISSConsole.ReadInt();            
            if (gender == 'M')
            {
                if(age>=40)
                {
                     Console.WriteLine("Good morning Uncle {0}",username);
                }else
                {
                     Console.WriteLine("Good morning Mr {0}",username);
                }
            }           
            else
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good morning Aunty {0}", username);
                }
                else
                {
                    Console.WriteLine("Good morning Ms. {0}", username);
                }
                
            }
        }

    }
}
