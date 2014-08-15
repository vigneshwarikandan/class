using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class ex30
    {
        static void Main(string[] args)
        {
           // Console.Write("Enter a number to check prime");
           // int number = ISSConsole.ReadInt();
            
            for (int j = 2; j < 1000; j++)
            {
                bool prime = true; 
                for (int i = 2; i < j; i++)
                {


                    if (j % i == 0)
                    {

                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(j);
                }
                
                
            }
            
        }
    }
}
