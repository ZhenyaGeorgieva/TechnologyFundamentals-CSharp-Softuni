using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsAndClasses_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();
            List<string> departments = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] tokens = Console.ReadLine()
                             .Split()
                             .ToArray();
                string name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string department = tokens[2];

                Employee employee = new Employee(name, salary, department);
                employeeList.Add(employee);

                if (departments.Contains(department) == false)
                {
                    departments.Add(department);
                }
            }

            List<Employee> bestDepartment = new List<Employee>();
            double bestAverageSalary = 0;
            string bestDepartmentName = string.Empty;
            for (int i = 0; i < departments.Count; i++)
            {
                List<Employee> departmentEmployees = employeeList
                    .Where(x => x.Department == departments[i])
                    .Select(x => x)
                    .ToList();

                double currentAverageSalary = departmentEmployees.Select(x => x.Salary).Average();
                if (currentAverageSalary >= bestAverageSalary)
                {
                    bestDepartmentName = departments[i];
                    bestDepartment = departmentEmployees.OrderBy(x => x.Salary).Reverse().ToList();
                    bestAverageSalary = currentAverageSalary;
                }
            }
            Console.WriteLine($"Highest Average Salary: {bestDepartmentName}");
            foreach (var x in bestDepartment)
            {
                Console.WriteLine($"{x.Name} {x.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}