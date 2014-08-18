using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex44
    {
        static void Main(string[] args)
        {
            string newString=substitute("Th1s 1s a program",'1','i');
            Console.WriteLine("The new string is {0}", newString);
        }

        static string substitute(string s, char c1, char c2)
        {
            s=s.Replace(c1, c2);
            return s;
        }
    }
}
