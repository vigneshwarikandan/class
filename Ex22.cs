using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex22
    {
        static void Main(string[] args)
        {
            int tempa, tempb;
            Console.WriteLine("Enter 2 numbers");
            int a = tempa = ISSConsole.ReadInt();
            int b = tempb = ISSConsole.ReadInt();
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

            Console.WriteLine("LCM={0}", tempa * tempb / hcf);
        }
    }
}
