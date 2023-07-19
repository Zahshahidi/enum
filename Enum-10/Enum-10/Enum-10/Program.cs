using System;

namespace Enum_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.color = "Red";
            r1.filled = true;
            r1.width = 10;
            r1.height = 5;
            r1.Area();
            Console.WriteLine("color= " + r1.color);
            Console.WriteLine("filled= " + r1.filled);
            Console.WriteLine("width= " + r1.width);
            Console.WriteLine("height= " + r1.height);
            Console.WriteLine();

            Triangle t1 = new Triangle();
            t1.color = "Blue";
            t1.filled = true;
            t1.width = 10;
            t1.height = 5;
            t1.Area();

            Console.WriteLine("color= " + t1.color);
            Console.WriteLine("filled= " + t1.filled);
            Console.WriteLine("width= " + t1.width);
            Console.WriteLine("height= " + t1.height);
            Console.WriteLine();
        }
    }

    public class Shape
    {
        public string color { get; set; }
        public bool filled { get; set; }

        public virtual void Area()
        {
            Console.WriteLine("The area is: ");
        }
    }

    public class Rectangle:Shape
    {
        public double width { get; set; }
        public double height { get; set; }
       
        public override void Area()
        {
            double area = width * height;
            Console.WriteLine("The Area is: " +area);
        }
    }

    public class Triangle:Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public override void Area()
        {
            double area = (width * height)/2;
            Console.WriteLine("The Area is: " + area);
        }
    }
}
