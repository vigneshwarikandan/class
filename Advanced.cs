using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace CalculateSalary
{
    class SalaryPercentile
    {
        static void Main(string[] args)
        {
            double salary = 0.0;
            double housingAllowance = 0.0;
            double transport_allowance = 0.0;
            Console.WriteLine("Enter the salary");
            salary = ISSConsole.ReadDouble();
            housingAllowance = salary * 0.1;            
            transport_allowance = salary *0.03;
            double totalSalary = salary + housingAllowance + transport_allowance;
            System.Console.WriteLine("The salary of the employee is " + totalSalary);
        }
    }
}

namespace degreeToFah
{
    class CentiGradeToFahrenheit
    {
        static void Main(string[] args){
            Console.WriteLine("Enter the centigrade");
        double C=ISSConsole.ReadDouble();
        double fahrenheit=1.8*C+32;
        Console.WriteLine("The fahrenheit is " + fahrenheit);
        }
    }
}

namespace algebra
{
    class Algebra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x");
            double x = ISSConsole.ReadDouble();   
            double y = 5 * Math.Pow(x,2) - 4 * x + 3;
            Console.WriteLine("The value of y is " + y);
        }
    }
}

namespace distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x and y");
            double x1 = ISSConsole.ReadDouble();
            double x2 = ISSConsole.ReadDouble();
            double y1, y2;
            y1 = ISSConsole.ReadDouble();
            y2 = ISSConsole.ReadDouble();
            double diff_x = x2 - x1;
            double diff_y = y2 - y1;
            double distance =Math.Sqrt( Math.Pow(diff_x, 2) + Math.Pow(diff_y, 2));
            Console.WriteLine("The value of y is " + distance);
        }
    }
}

namespace taxiFare
{
    class TaxiFare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the km");
            double kmsTravelled = ISSConsole.ReadDouble();
            double fare = 2.40 + kmsTravelled * 0.4;            
            Console.WriteLine("The fare is {0:##.#0}", Math.Round(fare,1));
        }
    }
}

namespace roundUpwards
{
    class RoundUpwards
    {
        static void Main(string[] args)
        {
            double fare = 12.13;            
            //Console.WriteLine("The fare is {0:##.#0}",fare);
           //  Console.WriteLine("The fare is " + Math.Ceiling());
        }
    }
}

namespace areaOfTriangle
{
    class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double c = 5;
            double s = (a + b + c) / 2;
            double sa = s - a;
            double sb = s - b;
            double sc = s - c;
            double threesides=Math.Sqrt(s*sa*sb*sc);
             Console.WriteLine("The area of triangle is " + threesides);
        }
    }
}
