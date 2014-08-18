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
            double addDistance = 0.0;
            double totalfare5c = 0.0;
            double finaltotalfare = 0.0;
            Console.WriteLine("Enter the distance in meters ");
            double totalDistance = Convert.ToDouble(Console.ReadLine());
            if (totalDistance > 500 && totalDistance <= 8500)
            {
                extraDistance = totalDistance - 500;
                Console.WriteLine(" extra distance" + extraDistance);
                totalfare = extraDistance / 100;
                Console.WriteLine(" totalfare" + totalfare);
                totalfare = mincharge + totalfare * 0.04;
                finaltotalfare = totalfare;

            }
            else if (totalDistance > 8500)
            {
                extraDistance = 8500 - 500;
                Console.WriteLine(" extra distance" + extraDistance);
                totalfare = extraDistance / 100;
                Console.WriteLine(" totalfare=" + totalfare);
                totalfare = mincharge + totalfare * 0.04;


                addDistance = totalDistance - 8500;
                Console.WriteLine(" extra distance" + addDistance);
                totalfare5c = addDistance / 100;
                Console.WriteLine(" totalfare5c=" + totalfare);
                totalfare5c = totalfare + totalfare5c * 0.05;
                finaltotalfare = totalfare5c;
            }
            System.Console.WriteLine("the total fare={0:##.#0}", finaltotalfare);
        }
    }
}
