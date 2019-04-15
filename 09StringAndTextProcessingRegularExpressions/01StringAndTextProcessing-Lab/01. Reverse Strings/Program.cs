using System;
using System.Linq;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "end")
            {
                string word = command;
                var reversed = command.ToCharArray().Reverse();
                Console.WriteLine($"{word} = {string.Join("", reversed)}");
                command = Console.ReadLine();
            }
        }
    }
}