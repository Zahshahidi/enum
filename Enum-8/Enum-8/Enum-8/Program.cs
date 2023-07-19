using System;
using System.Collections.Generic;

namespace Enum_8
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Circle> c1 = new List<Circle>
            {
               new Circle { Color = "Red", radius = 5 },
               new Circle { Color = "Blue", radius = 7 }
            };


            List<Rectangle> r1 = new List<Rectangle>
            {
                new Rectangle{Color="Green", Length=10, Width=5},
                new Rectangle{Color="Yellow", Length=6, Width=7}
            };

            foreach(Circle circle in c1)
            {
                Console.WriteLine(circle.Color);
                circle.GetArea();
                circle.GetPerimeter();
            }

            foreach (Rectangle rectangle in r1)
            {
                Console.WriteLine(rectangle.Color);
                rectangle.GetArea();
                rectangle.GetPerimeter();
            }
        }
    }

    public class Shape
    {
        public string Color { get; set; }

        public virtual void GetArea()
        {
            Console.WriteLine("The area is: ");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("The perimeter is: ");
        }
    }

    public class Circle : Shape
    {
        public double radius { get; set; }

        public override void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area is: " + area);
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The perimeter is: " + perimeter);
        }
    }
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override void GetArea()
        {
            double area = Length * Width;
            Console.WriteLine("The area is: " + area);
        }

        public override void GetPerimeter()
        {
            double perimeter = 2*(Length + Width);
            Console.WriteLine("The perimeter is: " + perimeter);
        }
    }
}
