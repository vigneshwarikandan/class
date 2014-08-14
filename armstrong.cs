using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class armstrong
    {
        static void usingWhile(string[] args)
        {
            Console.WriteLine("Enter a 3 digit number");
            int number = ISSConsole.ReadInt();
            int q=number;
            int r = 0;
            int sum = 0;
            while (q != 0)
            {
                r = q % 10;
                q = q / 10;
                sum = sum + (int)Math.Pow(r, 3);
            }
            if (sum == number)
            {
                System.Console.WriteLine("The number is an armstrong number");
            }
            else
            {
                System.Console.WriteLine("The number is not an armstrong number");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 3 digit number");
            int number = ISSConsole.ReadInt();
            int q = number;
            int r = 0;
            int sum = 0;
            q = number / 100;
            r = number % 100;
            sum=(int)Math.Pow(q,3);
            
            q = r / 10;
            r = r % 10;
            sum = sum + (int)Math.Pow(q, 3);
            
            sum = sum + (int)Math.Pow(r, 3);
            if (sum == number)
            {
                System.Console.WriteLine("The number is an armstrong number");
            }
            else
            {
                System.Console.WriteLine("The number is not an armstrong number");
            }

        }
        
    }
}
