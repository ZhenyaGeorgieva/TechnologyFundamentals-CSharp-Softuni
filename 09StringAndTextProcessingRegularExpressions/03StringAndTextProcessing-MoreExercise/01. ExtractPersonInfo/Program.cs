using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string namePattern = @"@(?<name>[\S\s]*?)\|";
        string agePattern = @"#(?<age>[\S\s]*?)\*";

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, namePattern) && Regex.IsMatch(input, agePattern))
            {
                Console.WriteLine($"{Regex.Match(input, namePattern).Groups["name"].Value} is {Regex.Match(input, agePattern).Groups["age"].Value} years old.");
            }
        }
    }
}
