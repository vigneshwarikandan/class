using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace day1
{
    public abstract class Shape
    {
        protected int x;
        protected int y;
        public Shape(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void draw();
        public virtual void plotPoints()
        {
        }

    }

    class Triangles : Shape
    {
        public Triangles(int x,int y):base(x,y)
        {
        }

        public override void draw()
        {
            System.Console.WriteLine("Triangle");
        }

        public override void plotPoints()
        {            
            System.Console.WriteLine("x={0} and y={1}",x,y);
        }
    }

     class Rectangles : Shape
     {
         public Rectangles(int x, int y):base(x,y)
         {
         }

        public override void draw()
        {
            System.Console.WriteLine("Rectangle");
        }

        public override void plotPoints()
        {
            System.Console.WriteLine("x={0} and y={1}", x, y);
        }
     }

    class Drawing
    {
        ArrayList shapes = new ArrayList();

        public void addShapes(Shape s)
        {
            shapes.Add(s);
        }

        public void Draw()
        {
            foreach (Shape s in shapes)
            {
                s.draw();
            }
            for (int i = 0; i < shapes.Count; i++)
            {
                Shape obj = (Shape) shapes[i];
                obj.draw();
            }
        }

        public void PlotPoints()
        {
            foreach (Shape s in shapes)
            {
                s.plotPoints();
            }
        }


        
    }

   public  class Tests
    {
        public static void Main(string[] args)
        {
            Drawing d = new Drawing();
            d.addShapes(new Triangles(2,3));
            d.addShapes(new Rectangles(3,3));
            d.addShapes(new Triangles(4, 13));
            d.addShapes(new Triangles(5, 6));
            d.addShapes(new Rectangles(7, 9));
            d.Draw();
            d.PlotPoints();
        }
    }
}
