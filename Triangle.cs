using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Triangle
    {
        int base_t = 3;
        int height = 2;
        int area = 0;
        //public Triangle(int b,int h)
        //{
        //    findArea(b, h);
        //}

        //void findArea(int b,int h)
        //{
        //    area= b*h/2;
        //}

        int getArea()
        {
            return base_t * height / 2;
        }

        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Console.WriteLine(t.getArea());
        }
    }
}
