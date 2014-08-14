using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Ex19
    {
        static void Main(string[] args)
        {
            double mincharge = 2.40;
            double extraDistance;
            double totalfare = 0.0;
            //  double distance = 500;
            Console.WriteLine("Enter the distance in meters 1");
            double totalDistance = Convert.ToDouble(Console.ReadLine());
            if (totalDistance > 500 && totalDistance <= 8500)
            {
                extraDistance = totalDistance - 500;
                Console.WriteLine(" extra distance" + extraDistance);
                totalfare = extraDistance / 100;
                Console.WriteLine(" totalfare" + totalfare);
                totalfare = mincharge + totalfare * 0.04;

            }
            else if (totalDistance > 8500)
            {
                extraDistance = totalDistance - 500;
                Console.WriteLine(" extra distance" + extraDistance);
                totalfare = extraDistance / 100;
                Console.WriteLine(" totalfare" + totalfare);
                totalfare = mincharge + totalfare * 0.05;
            }
            System.Console.WriteLine("the total fare={0}", totalfare);
            
        }
    }
}
