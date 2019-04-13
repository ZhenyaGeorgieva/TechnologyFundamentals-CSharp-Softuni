using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01test
{
    class Program
    {
        static void Main(string[] args)
        {
            var coursesStudents = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    string[] tokens = command
                        .Split(" : ")
                        .ToArray();

                    string nameCourse = tokens[0];
                    string namePerson = tokens[1];

                    if (!coursesStudents.ContainsKey(nameCourse))
                    {
                        coursesStudents[nameCourse] = new List<string>();
                        coursesStudents[nameCourse].Add(namePerson);
                    }
                    else
                    {
                        coursesStudents[nameCourse].Add(namePerson);
                    }
                }
            }

            var coursesPrint = coursesStudents
            .OrderByDescending(x => x.Value.Count)
            .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in coursesPrint)
            {
                List<string> sortedList = kvp.Value.OrderBy(x => x).ToList();
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var kvp1 in sortedList)
                {
                    Console.WriteLine($"-- {kvp1}");
                }
            }
        }
    }
}