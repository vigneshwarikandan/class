using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score");
            int score = ISSConsole.ReadInt();
           // char grade;
            if (score >= 80 && score <= 100)
            {
                Console.WriteLine("You scored {0} marks which is A grade", score);
            }
            else if (score >= 60 && score <= 79)
            {
                Console.WriteLine("You scored {0} marks which is B grade", score);
            }
            else if (score >= 40 && score <= 59)
            {
                Console.WriteLine("You scored {0} marks which is C grade", score);
            }
            else if (score >=0 && score <= 40)
            {
                Console.WriteLine("You scored {0} marks which is F grade", score);
            }
            else if (score <0)
            {
                Console.WriteLine("**Error**");
            }
            else if (score > 100)
            {
                Console.WriteLine("**Error**");
            }

        }
    }
}
