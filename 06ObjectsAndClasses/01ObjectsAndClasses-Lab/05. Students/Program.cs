using System;
using System.Collections.Generic;
using System.Linq;

namespace _05Students_my
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> listOfStudents = new List<Student>();
            while (command != "end")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.SecondName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;
                listOfStudents.Add(student);

                command = Console.ReadLine();
            }
            string commandHomeTown = Console.ReadLine();
            List<Student> listToPrint = listOfStudents.Where(x => x.HomeTown == commandHomeTown).ToList();
            foreach (var x in listToPrint)
            {
                Console.WriteLine($"{x.FirstName} {x.SecondName} is { x.Age} years old.");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}