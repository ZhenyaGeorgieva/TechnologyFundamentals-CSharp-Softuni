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
            string regex = @"\b[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}\b";
            string text = Console.ReadLine();
            var result = Regex.Matches(text, regex);
            foreach (Match x in result)
            {
                Console.Write(x + " ");
            }
        }
    }
}