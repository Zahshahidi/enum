using System;
using System.Collections.Generic;

namespace Enum_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c1 = new Company();
            c1.AddEmployee(new Employee { Name = "John", Position = "Manager", Salary = 5000 });
            c1.AddEmployee(new Employee { Name = "Zahra", Position = "Developer", Salary = 10000 });

            Console.WriteLine("Total Salary is: " + c1.GetTotalSalary());
            Console.WriteLine("Average Salary is: " + c1.GetAverageSalary());

            c1.RemoveEmployee("John");


        }
    }

    public class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public class Company
    {
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(string employeeName)
        {
            Employee employee = Employees.Find(e => e.Name == employeeName);
            if (employee != null)
                Employees.Remove(employee);
        }

        public int GetTotalSalary()
        {
            int totalSalary = 0;
            foreach(Employee employee in Employees)
            {
                totalSalary += employee.Salary;
            }
            return totalSalary;
        }
             
        public double GetAverageSalary()
        {
            if (Employees.Count == 0)
                return 0;

            int totalSalary = GetTotalSalary();
            double averageSalary = (double)totalSalary / Employees.Count;
            return averageSalary;
        }
    }
}
