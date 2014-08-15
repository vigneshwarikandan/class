using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NO");
            for (float i = 1; i <= 10; i++)
            {                
                Console.Write("{0,10}",i+"\t");

                Console.Write("{0,10:0.0##}\t", 1/i );
                //Console.Write("\t");
                Console.Write("{0,10}", i * i + "\t");
                
                Console.WriteLine("{0,10:#0.###}", Math.Sqrt(i));

                
            }
        }
    }
}
