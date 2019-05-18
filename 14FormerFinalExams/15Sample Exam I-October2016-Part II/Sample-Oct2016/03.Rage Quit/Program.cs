using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _31RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialText = Console.ReadLine();
            string pattern = @"(?<word>[^0-9]{1,})(?<count>[0-9]{1,})";

            StringBuilder sb = new StringBuilder();

            if (Regex.IsMatch(initialText, pattern))
            {
                var collectionA = Regex.Matches(initialText, pattern);
                foreach (Match x in collectionA)
                {
                    string textToRepeat = x.Groups["word"].Value.ToString().ToUpper();
                    int repeatTimes = int.Parse(x.Groups["count"].Value.ToString());
                    for (int i = 0; i < repeatTimes; i++)
                    {
                        sb.Append(textToRepeat);
                    }
                }
            }
            int uniqueSymbols = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(sb.ToString());
        }
    }
}
