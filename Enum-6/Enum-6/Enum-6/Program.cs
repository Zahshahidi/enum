using System;

namespace Enum_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "Reza";
            e1.Age = 25;
            e1.Gender = Gender.Male;
            e1.salary = 10000;
            e1.position = "Manager";
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class Employee : Person
    {
        public double salary { get; set; }
        public string position { get; set; }
    }
}
