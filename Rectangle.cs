using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    class Rectangle
    {
        int length;
        int breadth;
        int area=0;
        public Rectangle(int l,int b)
        {
            length = l;
            breadth = b;
        }
        public void findArea()
        {
            area = length * breadth;
        }

        public int getArea()
        {
            return area;
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(3,3);
           
            
            Console.WriteLine(r.getArea());

        }
    }
}
