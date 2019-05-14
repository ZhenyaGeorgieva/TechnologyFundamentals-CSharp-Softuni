using System;
using System.Text.RegularExpressions;

namespace _20Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string patternDidi = @"[^A-Za-z-]{1,}";
            string patternBojo = @"[A-Za-z]{1,}-[A-Za-z]{1,}";
            string didiMatch = string.Empty;
            string bojoMatch = string.Empty;
            while (true)
            {
                if (Regex.IsMatch(command, patternDidi))
                {

                    var didiCollection = Regex.Matches(command, patternDidi);
                    foreach (Match x in didiCollection)
                    {
                        didiMatch = x.Value.ToString();
                        Console.WriteLine(didiMatch);
                        break;
                    }
                }
                else
                {
                    return;
                }
                int indexDidiMatch = command.IndexOf(didiMatch);
                command = command.Substring(indexDidiMatch + didiMatch.Length);

                if (Regex.IsMatch(command, patternBojo))
                {
                    var bojoCollection = Regex.Matches(command, patternBojo);
                    foreach (Match x in bojoCollection)
                    {
                        bojoMatch = x.Value.ToString();
                        Console.WriteLine(bojoMatch);
                        break;
                    }
                }
                else
                {
                    return;
                }
                int indexBojoMatch = command.IndexOf(bojoMatch);
                command = command.Substring(indexBojoMatch + bojoMatch.Length);
            }
        }
    }
}