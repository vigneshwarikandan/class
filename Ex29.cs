using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex29
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find whether it is perfect");
            int number=ISSConsole.ReadInt();
            int pn = 0;
           // findOdd();
            for (int i = 1; i < number; i++)
            {
                if (number == 6)
                {
                    pn = pn + i;
                    if (pn == number)
                    {
                        System.Console.WriteLine("Perfect number");
                        break;
                    }
                }
                else
                {
                    for (int k = 1; k < 30; k++)
                    {
                        if (k % 2 != 0)
                        {
                            pn = pn +(int) Math.Pow(k, 3);
                            if (pn == number)
                            {
                                System.Console.WriteLine("Perfect number");
                                break;
                            }
                        }
                        
                    }
                }
            }
        }

        //static void findOdd()
        //{
        //    for (int i = 1; i < 30; i++)
        //    {
        //        if (i % 2 != 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}
    }
}
