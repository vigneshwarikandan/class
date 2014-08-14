using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;
namespace greeting
{
    class Exercise1
    {
        static void Main(string[] args){
            Console.WriteLine("Enter your name");
            string username=ISSConsole.ReadString();
            Console.WriteLine("Good morning " + username);
        }

    }
}

namespace squareOfNuumber
{
    class numberSquare
    {
        //Can we write string args[]?
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int number = ISSConsole.ReadInt();
            //We have Math.pow
            int squareOfNumber = number *number;
            Console.WriteLine("square of the number is=" + squareOfNumber);
        }

    }

}

namespace doublePrecision
{
    class DoublePrecision
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a double precision number");
            double doubleNumber = ISSConsole.ReadDouble();
            double squareDouble = doubleNumber * doubleNumber;
            Console.WriteLine("the square of double precision number is =" + squareDouble);
        }
    }
}

namespace doublePrecisionSquareRoot
{
    class DoublePrecisionSquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a double precision number");
            double number = ISSConsole.ReadDouble();
            double squareRootOfNumber = Math.Sqrt(number);
            Console.WriteLine("The square root of the number" + squareRootOfNumber);
        }
    }
}

namespace squareRootRounded3
{
    class SquareRootRound3{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a double precision number to find square root and round to 3 decimals");
                double number=ISSConsole.ReadDouble();
            double sqrt=Math.Sqrt(number);
            double round3=Math.Round(sqrt);
            Console.WriteLine("The square root of "+number+" is "+sqrt+" \n"+"It is rounded of to 3 decimals as {0:##.###}",sqrt);
           // Console.WriteLine("The square root of " + number + " is " + sqrt);
            //Console.WriteLine("The rounded value is {0:##.000}" , sqrt);
        }
    }
}

namespace sqrtInteger
{
    class SqrtNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int number = ISSConsole.ReadInt();
            double sqrtInt = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1}", number, sqrtInt);
            ISSConsole.Pause();
        }
    }
}
