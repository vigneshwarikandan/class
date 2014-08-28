using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex45
    {
        static void Main(string[] args)
        {
            double number = 0.25;
            double numberOfCents = 0.0; 
            number =number* Math.Pow(10, 2);
            Console.WriteLine(number);
            int r = (int)number % 100;
            int q = (int)number / 100;
            Console.WriteLine(q);
            Console.WriteLine(r);
            if (q > 0)
            {
            }
        }
    }
}
