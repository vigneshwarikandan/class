using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex38
    {       
        static void Main(string[] args)
        {
            int swap = 0;
            string swapName = "";
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            string[] name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };

            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = i; j < marks.Length - 1; j++)
                {
                    if (marks[i] < marks[j + 1])
                    {
                        swap = marks[i];
                        marks[i] = marks[j + 1];
                        marks[j + 1] = swap;

                        swapName = name[i];
                        name[i] = name[j + 1];
                        name[j + 1] = swapName;
                    }
                }
            }

            for (int i = 0; i < marks.Length; i++)
            {
                    Console.WriteLine(name[i] + "\t" + marks[i]);              
            }

            string swapString = "";
            int swapMarks = 0;
            for (int s = 0; s < name.Length - 1; s++)
            {
                for (int b = s; b < name.Length - 1; b++)
                {
                    if (name[s].CompareTo(name[b + 1]) == 1)
                    {
                        swapString = name[s];
                        name[s] = name[b + 1];
                        name[b + 1] = swapString;

                        swapMarks = marks[s];
                        marks[s] = marks[b + 1];
                        marks[b + 1] = swapMarks;
                    }
                }
            }

            for (int m = 0; m < name.Length; m++)
            {
                Console.WriteLine("The sorted names are in asc {0}\t{1}", name[m],marks[m]);
            }
        }
    }
}
