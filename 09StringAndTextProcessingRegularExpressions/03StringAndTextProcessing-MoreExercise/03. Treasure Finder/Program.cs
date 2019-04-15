using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while (command != "find")
            {
                string text = command;
                StringBuilder decrypted = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    int numberOfChar = (int)text[i];
                    if (i < keys.Length)
                    {
                        int numberToDecrease = keys[i];
                        numberOfChar -= numberToDecrease;
                    }
                    else if (i >= keys.Length
                        && ((i + 1) % (keys.Length) != 0))
                    {
                        int indexOfnumberToDecrease = ((i + 1) % (keys.Length)) - 1;
                        int numberToDecrease = keys[indexOfnumberToDecrease];
                        numberOfChar -= numberToDecrease;
                    }
                    else if (i >= keys.Length
                        && ((i + 1) % keys.Length == 0))
                    {
                        int indexOfnumberToDecrease = (keys.Length - 1);
                        int numberToDecrease = keys[indexOfnumberToDecrease];
                        numberOfChar -= numberToDecrease;
                    }
                    char newToAdd = (char)numberOfChar;
                    decrypted.Append(newToAdd);
                }
                string decrypted1 = decrypted.ToString();
                string regexCoordinates = @"<(?<coordinates>[\S\s]*?)>";
                string regexTreasure = @"&(?<treasure>[\S\s]*?)&";
                var treasures = Regex.Matches(decrypted1, regexTreasure);
                var coordinates = Regex.Matches(decrypted1, regexCoordinates);
                if (Regex.IsMatch(decrypted1, regexCoordinates) && Regex.IsMatch(decrypted1, regexTreasure))
                {
                    string treasurePrint = Regex.Match(decrypted1, regexTreasure).Groups["treasure"].Value;
                    string coordPrint = Regex.Match(decrypted1, regexCoordinates).Groups["coordinates"].Value;
                    Console.WriteLine($"Found {treasurePrint} at {coordPrint}");
                }
                command = Console.ReadLine();
            }
        }
    }
}
