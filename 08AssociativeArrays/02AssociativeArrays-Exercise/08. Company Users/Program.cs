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
            var companyEmployees = new SortedDictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else
                {
                    string[] tokens = command
                        .Split(" -> ")
                        .ToArray();

                    string companyName = tokens[0];
                    string employeeID = tokens[1];

                    if (!companyEmployees.ContainsKey(companyName))
                    {
                        companyEmployees[companyName] = new List<string>();
                        companyEmployees[companyName].Add(employeeID);
                    }
                    else if (companyEmployees.ContainsKey(companyName)
                        && !companyEmployees[companyName].Contains(employeeID))
                    {
                        companyEmployees[companyName].Add(employeeID);
                    }
                }
            }
            foreach (var kvp in companyEmployees)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var names in kvp.Value)
                {
                    Console.WriteLine($"-- {names}");
                }
            }
        }
    }
}
