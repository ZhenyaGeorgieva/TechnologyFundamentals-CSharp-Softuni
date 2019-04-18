using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<peak>[A-Za-z0-9\!\@\#\$\?]{1,})\=(?<length>[0-9]{1,})<<(?<geohash>[\w\d\s]{1,})$";
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Last note")
                {
                    break;
                }
                else
                {
                    if (Regex.IsMatch(command, pattern))
                    {
                        var collectionOfMatches = Regex.Matches(command, pattern);
                        StringBuilder sb = new StringBuilder();
                        string peakToDescrypt = string.Empty;
                        int lengthOfCode = int.MinValue;
                        string code = string.Empty;
                        foreach (Match x in collectionOfMatches)
                        {
                            peakToDescrypt = x.Groups["peak"].Value.ToString();
                            lengthOfCode = int.Parse(x.Groups["length"].Value.ToString());
                            code = x.Groups["geohash"].Value.ToString();
                        }
                        if (code.Length != lengthOfCode)
                        {
                            Console.WriteLine("Nothing found!");
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < peakToDescrypt.Length; i++)
                            {
                                char symbol = peakToDescrypt[i];
                                if (char.IsLetterOrDigit(symbol))
                                {
                                    sb.Append(symbol);
                                }
                            }
                            string nameToPrint = sb.ToString();
                            Console.WriteLine($"Coordinates found! {nameToPrint} -> {code}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
            }
        }
    }
}