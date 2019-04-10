using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Students2_my
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> listofStudents = new List<Student>();
            while (command != "end")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                string name = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                if (IsStudentExisting(listofStudents, name, lastName))
                {
                    Student student = GetStudent(listofStudents, name, lastName);
                    student.FirstName = name;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                }
                else
                {
                    Student newStudent = new Student();
                    newStudent.FirstName = name;
                    newStudent.LastName = lastName;
                    newStudent.Age = age;
                    newStudent.HomeTown = homeTown;
                    listofStudents.Add(newStudent);
                }
                command = Console.ReadLine();
            }
            string commandTown = Console.ReadLine();
            List<Student> listToPrint = listofStudents
                .Where(x => x.HomeTown == commandTown)
                .ToList();
            foreach (var x in listToPrint)
            {
                Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old.");
            }
        }
        static bool IsStudentExisting(List<Student> listOfStudents, string firstName, string lastName)
        {
            foreach (var x in listOfStudents)
            {
                if (x.FirstName == firstName && x.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> listOfStudent, string first, string last)
        {
            Student existingStudent = null;
            foreach (var x in listOfStudent)
            {
                if (x.FirstName == first && x.LastName == last)
                {
                    existingStudent = x;
                }
            }
            return existingStudent;
        }
    }
}