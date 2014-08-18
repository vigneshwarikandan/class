using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex32
    {
        static void FairlyEfficientWay(string[] args)
        {
            int[] sales = new int[12] { 3000, 2000, 1500, 1000, 2500, 4000, 3500, 5000, 4500, 35000, 5500, 6000 };
            int[] newsalesArray = new int[12];
            int sum = 0;
            for (int k = 0; k < sales.Length; k++)
            {
                sum = sum + sales[k];
                newsalesArray[k] = sales[k];
            }



            Console.WriteLine("The average of sales =" + sum / sales.Length);

            int temp = 0;
            for (int i = 0; i < newsalesArray.Length - 1; i++)
            {
                for (int j = i; j < newsalesArray.Length - 1; j++)
                {
                    if (newsalesArray[i] > newsalesArray[j + 1])
                    {
                        temp = newsalesArray[i];
                        newsalesArray[i] = newsalesArray[j + 1];
                        newsalesArray[j + 1] = temp;
                    }
                }
            }

            
            for (int a = 0; a < sales.Length; a++)
            {
                if (newsalesArray[0] == sales[a])
                {
                    Console.WriteLine("The min sales is in" + a);
                }
                if (newsalesArray[sales.Length - 1] == sales[a])
                {
                    Console.WriteLine("The max sales is in" + a);
                }

            }
        }

        static void EfficientWay()
        {
            int[] sales = new int[12] { 3000, 2000, 1500, 1000, 2500, 4000, 3500, 5000, 4500, 35000, 5500, 6000 };
            int tempIndex = 0;
            for (int i = 0; i < sales.Length - 1; i++)
            {
                for (int j = i+1; j < sales.Length; j++)
                {
                    if (sales[i] > sales[j])
                    {
                        if (tempIndex == 0)
                        {
                            tempIndex = j;
                        }else
                        {
                            if(sales[j] < sales[tempIndex])
                            {
                                     tempIndex = j;
                            }
                        }
                       
                    }
                }
            }
            Console.WriteLine("The min value is {0}", sales[tempIndex]);

            tempIndex = 0;

            for (int i = 0; i < sales.Length - 1; i++)
            {
                for (int j = i + 1; j < sales.Length; j++)
                {
                    if (sales[i] < sales[j])
                    {
                        if (tempIndex == 0)
                        {
                            tempIndex = j;
                        }
                        else
                        {
                            if (sales[j] > sales[tempIndex])
                            {
                                tempIndex = j;
                            }
                        }

                    }
                }
            }
            Console.WriteLine("The max value is {0}", sales[tempIndex]);
        }

        static void Main(string[] args)
        {
            EfficientWay();
        }
    }
}
