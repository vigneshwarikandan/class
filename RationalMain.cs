using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class RationalMain
    {
        static void Main(string[] args)
        {
            RationalOverloaded rational_a = new RationalOverloaded(2, 3);
            RationalOverloaded rational_b = new RationalOverloaded(4, 5);
            RationalOverloaded rational_c = rational_a * rational_b;
            Console.WriteLine("The multiply is {0}", rational_c.StrVal());

            //RationalOverloaded ratio
        }
    }
}
