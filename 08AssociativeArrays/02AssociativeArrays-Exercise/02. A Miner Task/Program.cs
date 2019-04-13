using System;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourses = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                else
                {
                    string resourseName = command;
                    int quantity = int.Parse(Console.ReadLine());

                    if (!resourses.ContainsKey(resourseName))
                    {
                        resourses[resourseName] = 0;
                    }
                    resourses[resourseName] += quantity;
                }
            }
            foreach (var kvp in resourses)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}