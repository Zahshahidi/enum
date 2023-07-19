using System;

namespace Enum_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();

            a1.Name = "Cat";
            a1.Sound = "Meow";

            a1.makeSound();
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public void makeSound()
        {
            Console.WriteLine("The sound of animal is: " + Sound);
        }
    }
}
