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
            var studentsGrades = new Dictionary<string, List<double>>();
            int countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] = new List<double>();
                    studentsGrades[name].Add(grade);
                }
                else
                {
                    studentsGrades[name].Add(grade);
                }
            }
            var filteredListStudents = studentsGrades
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in filteredListStudents)
            {
                string name = kvp.Key;
                double average = kvp.Value.Average();
                Console.WriteLine($"{name} -> {average:f2}");
            }
        }
    }
}
