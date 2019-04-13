using System;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var charsCount = new Dictionary<char, int>();
            string command = Console.ReadLine();
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] != ' ')
                {
                    if (!charsCount.ContainsKey(command[i]))
                    {
                        charsCount[command[i]] = 0;
                    }
                    charsCount[command[i]]++;
                }
            }
            foreach (var x in charsCount)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}
