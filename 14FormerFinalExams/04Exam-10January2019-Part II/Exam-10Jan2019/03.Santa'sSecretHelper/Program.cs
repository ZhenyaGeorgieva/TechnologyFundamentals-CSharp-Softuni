using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> goodKids = new List<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < command.Length; i++)
                    {
                        char symbol = command[i];
                        int asciiCode = (int)symbol;
                        int newAsciiCode = asciiCode - key;
                        char newSymbolToAdd = (char)newAsciiCode;
                        sb.Append(newSymbolToAdd);
                    }
                    string decryptedText = sb.ToString();
                    string pattern = @"([^@\-\!\:\>]{0,})@(?<name>[A-Za-z]{1,})([^@\-\!\:\>]{0,})!(?<type>[G|N]{1})!([^@\-\!\:\>]{0,})";
                    if (Regex.IsMatch(decryptedText, pattern))
                    {
                        var matchesCollection = Regex.Matches(decryptedText, pattern);
                        foreach (Match x in matchesCollection)
                        {
                            string name = x.Groups["name"].Value.ToString();
                            string type = x.Groups["type"].Value.ToString();
                            if (type == "G")
                            {
                                goodKids.Add(name);
                            }
                        }
                    }
                }
            }
            foreach (var x in goodKids)
            {
                Console.WriteLine(x);
            }
        }
    }
}
