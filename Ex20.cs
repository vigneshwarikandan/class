using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace day1
{
    class Ex20
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the ordered quantity of TV");
            int q_tv = ISSConsole.ReadInt();
            Console.Write("Enter the ordered quantity of DVD");
            int q_dvd = ISSConsole.ReadInt(); 
            Console.Write("Enter the ordered quantity of MP3");
            int q_mp3 = ISSConsole.ReadInt();

            int price_tv = 900;
            int price_dvd = 500;
            int price_mp3 = 700;

            double tv_orderedAmount = price_tv * q_tv;
            double dvd_orderAmount = price_dvd*q_dvd;
            double mp3_orderAmount = price_mp3 * q_mp3;

            double totalOrderAmount=tv_orderedAmount+dvd_orderAmount+mp3_orderAmount;

            Console.WriteLine("The total ordered amount without discount=" + totalOrderAmount);

            if (totalOrderAmount > 5000 && totalOrderAmount<10000)
            {
                totalOrderAmount = totalOrderAmount - totalOrderAmount * 0.1;
            }
            else if (totalOrderAmount>10000)
            {
                totalOrderAmount = totalOrderAmount - totalOrderAmount * 0.15;
            }

            Console.WriteLine("The total ordered amount with discount=" + totalOrderAmount);

        }
    }
}
