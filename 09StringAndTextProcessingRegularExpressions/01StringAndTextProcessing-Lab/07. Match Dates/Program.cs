using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([0-9]{2})([-.\/])([A-Z]{1}[a-z]{2})\2([0-9]{4})\b";
            string text = Console.ReadLine();
            MatchCollection validDates = Regex.Matches(text, regex);
            foreach (Match x in validDates)
            {
                Console.WriteLine($"Day: {x.Groups[1]}, Month: {x.Groups[3]}, Year: {x.Groups[4]}");

            }
        }
    }
}