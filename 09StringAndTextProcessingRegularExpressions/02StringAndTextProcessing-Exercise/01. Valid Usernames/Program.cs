using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringProcessingRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ").ToArray();
            List<string> validUsernames = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string userName = text[i];
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    bool valid = true;
                    for (int j = 0; j < userName.Length; j++)
                    {
                        char symbol = userName[j];
                        if (char.IsLetterOrDigit(symbol)
                            || symbol == '-'
                            || symbol == '_')
                        {
                            continue;
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        validUsernames.Add(userName);
                    }
                }
            }
            foreach (var x in validUsernames)
            {
                Console.WriteLine(x);
            }
        }
    }
}
