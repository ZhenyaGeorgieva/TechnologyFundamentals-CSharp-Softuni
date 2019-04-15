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
            List<string> text = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            decimal totalSum = 0;
            decimal numberToManinulate = 0;
            Dictionary<char, decimal> positionInAlphabetUpper = new Dictionary<char, decimal>();
            decimal positionUpper = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                positionUpper++;
                positionInAlphabetUpper[i] = positionUpper;
            }
            Dictionary<char, decimal> positionInAlphabetLower = new Dictionary<char, decimal>();
            decimal positionLower = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                positionLower++;
                positionInAlphabetLower[i] = positionLower;
            }

            for (int i = 0; i < text.Count; i++)
            {
                string tokens = text[i];
                char firstLetter = tokens[0];
                char lastLetter = tokens[tokens.Length - 1];

                string number = string.Empty;
                for (int j = 1; j < tokens.Length - 1; j++)
                {
                    number += tokens[j];
                }
                numberToManinulate = decimal.Parse(number);

                if (char.IsUpper(firstLetter))
                {
                    decimal position1 = positionInAlphabetUpper[firstLetter];
                    numberToManinulate = numberToManinulate / position1;
                }
                else if (char.IsLower(firstLetter))
                {
                    decimal position1 = positionInAlphabetLower[firstLetter];
                    numberToManinulate = numberToManinulate * position1;
                }
                if (char.IsUpper(lastLetter))
                {
                    decimal position1 = positionInAlphabetUpper[lastLetter];
                    numberToManinulate = numberToManinulate - position1;
                }
                else if (char.IsLower(lastLetter))
                {
                    decimal position1 = positionInAlphabetLower[lastLetter];
                    numberToManinulate = numberToManinulate + position1;
                }
                totalSum += numberToManinulate;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
