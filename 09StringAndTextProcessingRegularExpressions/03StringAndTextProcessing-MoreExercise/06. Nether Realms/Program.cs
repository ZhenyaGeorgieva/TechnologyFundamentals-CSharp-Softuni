using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textInitial = Console.ReadLine()
                .Split(new char[] { ',', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < textInitial.Count; i++)
            {
                string text = textInitial[i];
                var regexChars = @"([^0-9\+\*\-\.\/]){1}";
                var matchesChars = Regex.Matches(text, regexChars);
                int health = 0;

                foreach (Match x in matchesChars)
                {
                    char charToAdd = char.Parse(x.Value);
                    health += (int)charToAdd;
                }
                var regexNumbers = @"([\-]{0,}[0-9]{1,}[\.]{0,1}[0-9]{0,})";
                var matchesNumbers = Regex.Matches(text, regexNumbers);
                double sumNumbers = 0;
                foreach (Match y in matchesNumbers)
                {
                    double num = double.Parse(y.Value);
                    sumNumbers += num;
                }
                var regexDiv = @"([*|\/]{1})";
                var matchesDiv = Regex.Matches(text, regexDiv);
                foreach (Match x in matchesDiv)
                {
                    char symbol = char.Parse(x.Value);
                    if (symbol == '*')
                    {
                        sumNumbers *= 2;
                    }
                    else if (symbol == '/')
                    {
                        sumNumbers /= 2;
                    }
                }
                Console.WriteLine($"{text} - {health} health, {sumNumbers:f2} damage");
            }
        }
    }
}
