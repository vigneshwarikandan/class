using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex23
    {
        static void Main(string[] args)
        {
            int comp_mind = ISSMath.RNDInt(9);
            int yourguess;
            int count = 0;
            do
            {
                yourguess = ISSConsole.ReadInt("Guess the number in my mind");
                ++count;
            } while (comp_mind != yourguess);
            Console.WriteLine("Congrats. your have made {0} attempts",count);
        }
    }
}
