using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?[0-9]{1,}(\.[0-9]{1,})?($|(?=\s))";
            string text = Console.ReadLine();
            var foundNumbers = Regex.Matches(text, regex);
            foreach (Match x in foundNumbers)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}