using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Enum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
               new Student { Name = "John Doe", Age = Convert.ToInt32( 20), Major = "Computer Science",GPA=19 },
               new Student { Name = "Jane Smith", Age = Convert.ToInt32(21), Major = "Mathematics",GPA=17 }
            };

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.GPA);
            }
        }
    }

    public class Student
    {
        public string Major { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
    }
}
