using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex23a
    {
        static void Main(string[] args)
        {
            int comp_mind = ISSMath.RNDInt(9);
            Console.WriteLine("In my mind=" + comp_mind);
            int yourguess;
            int count = 0;
            do
            {
                if (count >= 1)
                {
                    Console.WriteLine("Try again");
                }
                yourguess = ISSConsole.ReadInt("Guess the number in my mind");                
                ++count;
            } while (comp_mind != yourguess);
            if (count <= 2)
            {
                Console.WriteLine("Congrats. you have made {0} attempts", count);
                Console.WriteLine("You are a wizard");
            }
            else if (count>=3 && count<=5)
            {
                Console.WriteLine("You are a good guess");
            }
            else
            {
                Console.WriteLine("Your are lousy");
            }
        }
    }
}
