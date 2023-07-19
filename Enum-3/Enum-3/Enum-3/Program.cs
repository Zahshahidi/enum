using System;

namespace Enum_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.radius = 5;
            c1.Area();
        }
    }

    public class Circle
    {
        public double radius;

        public void Area()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area is : " + area);
        }
    }
}
