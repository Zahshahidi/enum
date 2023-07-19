using System;

namespace Enum_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();

            c1.x = 10;
            c1.y = 5;

            c1.add();
            c1.subtract();
            c1.multiply();
            c1.divide();
        }
    }

    public class Calculator
    {
        public double x { get; set; }
        public double y { get; set; }

        public void add()
        {
            double add = x + y;
            Console.WriteLine("Add is: " +add);
        }
        public void subtract()
        {
            double subtract = x - y;
            Console.WriteLine("Subtract is: " + subtract);
        }
        public void multiply()
        {
            double multiply = x * y;
            Console.WriteLine("Multiply is: " + multiply);
        }
        public void divide()
        {
            double divide = x / y;
            Console.WriteLine("Divide is: " + divide);
        }
    }
}
