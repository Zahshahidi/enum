using System;
using System.Collections.Generic;

namespace Enum_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Reza";
            s1.Age = 20;
            s1.Grade = 18;
            s1.Courses = new List<string> { "Math", "Physics", "English" };

            s1.addCourse("Chemistry");
            s1.removeCourse("Physics");

            Console.WriteLine("Student Name: " + s1.Name);
            Console.WriteLine("Age: " + s1.Age);
            Console.WriteLine("Grade: " + s1.Grade);
            Console.WriteLine("Courses: " );

            foreach (string course in s1.Courses)
            {
                Console.WriteLine(course);
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string courseName { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public List<string> Courses { get; set; }

        public void addCourse(string courseName)
        {
           
            Courses.Add(courseName);

        }

        public void removeCourse(string courseName)
        {
           
            Courses.Remove(courseName);
        }
    }
}
