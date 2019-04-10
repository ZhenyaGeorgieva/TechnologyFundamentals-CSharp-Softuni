using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Students> listOfStudens = new List<Students>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);
                Students student = new Students(firstName, lastName, grade);
                listOfStudens.Add(student);
            }

            listOfStudens = listOfStudens.OrderBy(x => x.Grade).Reverse().ToList();
            foreach (var x in listOfStudens)
            {
                Console.WriteLine($"{x.FirstName} {x.LastName}: {x.Grade:f2}");
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }

}