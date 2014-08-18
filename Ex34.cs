using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex34
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 4] { { 60, 70, 80, 90 }, { 70, 80, 90, 100 }, { 90, 60, 50, 60 }, { 100, 90, 80, 50 }, { 60, 70, 70, 90 } };
            string[] students = new string[5] { "a", "b", "c", "d", "e" };
            string[] subjects = new string[4] { "Mat", "phy", "Che", "Bio" };
            int classAvg = 0;
            int classSum = 0;

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                Console.Write("{0}", students[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("\t{0}", marks[i, j]);
                    sum = sum + marks[i, j];
                }
                Console.Write("\tTotal={0}", sum);
                classSum = classSum + sum;
                Console.WriteLine();
            }
            classAvg = classSum / (5 * 4);


            Console.WriteLine("The class average ={0}", classAvg);

            for (int m = 0; m < 4; m++)
            {
                int subclassSum = 0;
                int subClassAvg = 0;
                Console.Write("{0}", subjects[m]);
                for (int s = 0; s < 5; s++)
                {
                    Console.WriteLine("\t{0}", marks[s, m]);
                    subclassSum = subclassSum + marks[s, m];
                }

                subClassAvg = subclassSum / 5;
                Console.WriteLine("The subject class avg={0}", subClassAvg);

                    int sumOfVariance = 0;
                    double standardDeviation = 0;
                    for (int h = 0; h < 5; h++)
                    {                        
                        sumOfVariance = sumOfVariance + (int)Math.Pow(marks[h, m] - subClassAvg,2);
                    }
                    sumOfVariance = sumOfVariance / 5;
                    standardDeviation = Math.Sqrt(sumOfVariance);
                    Console.WriteLine("The standard deviation of {0} is {1}", subjects[m], standardDeviation);                    

                Console.WriteLine();
            }

           
        }
        
    }
}
