using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = Regex.Replace(input, "(.)\\1+", "$1");
            Console.WriteLine(output);
        }
    }
}
