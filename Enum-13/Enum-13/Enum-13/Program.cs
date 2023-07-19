using System;
using System.Collections.Generic;

namespace Enum_13
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Student
    {
        public string Course { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public List<Course> Courses { get; set; }

        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
            Console.WriteLine($"Course '{course.Title}' has been removed from student '{Name}'");
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
            Console.WriteLine($"Course '{course.Title}' has been added to student '{Name}'");
        }

        public void CalculateGPA()
        {
            if (Courses.Count == 0)
            {
                Console.WriteLine("No courses found. GPA calculation is not possible.");
                return;
            }

            double totalGradePoints = 0;
            double totalUnits = 0;

            foreach (Course course in Courses)
            {
                totalGradePoints += course.Grade * double.Parse(course.Units);
                totalUnits += double.Parse(course.Units);
            }

            GPA = totalGradePoints / totalUnits;
            Console.WriteLine($"GPA calculated for student '{Name}': {GPA:F2}");
        }
    }

    public class Course
    {
        public string Units { get; set; }
        public string Title { get; set; }
        public double Grade { get; set; }
    }

}
