using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex22
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int hcf = 0;
            while (a != b)
            {
                if (b > a)
                {
                    b = b - a;
                    hcf = b;
                }
                else
                {
                    a = a - b;
                    hcf = a;
                }

            }

            Console.WriteLine("HCF={0}", hcf);

           // Console.WriteLine("LCM={0}",a*b/a
        }
    }
}
