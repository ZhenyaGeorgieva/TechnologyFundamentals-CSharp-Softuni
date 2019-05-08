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
            string[] tokens = Console.ReadLine().Split("&");
            List<string> messages = new List<string>();
            string pattern = @"[A-Za-z0-9]{16,25}";
            for (int i = 0; i < tokens.Length; i++)
            {
                string text = tokens[i];
                StringBuilder sb = new StringBuilder();

                if (Regex.IsMatch(text, pattern) && text.Length == 16)
                {
                    for (int j = 0; j < text.Length; j++)
                    {
                        char symbol = text[j];

                        if (char.IsDigit(symbol))
                        {
                            int digit = int.Parse(symbol.ToString());
                            int newDigit = 9 - digit;
                            string textToAdd = newDigit.ToString();
                            sb.Append(textToAdd);
                        }
                        else if (char.IsLower(symbol))
                        {
                            string textToAdd = symbol.ToString().ToUpper();
                            sb.Append(textToAdd);
                        }
                        else
                        {
                            sb.Append(symbol);
                        }
                        if ((j != text.Length - 1) && ((j + 1) % 4 == 0))
                        {
                            sb.Append("-");
                        }
                    }
                    string textToAddToList = sb.ToString();
                    messages.Add(textToAddToList);
                }
                if (Regex.IsMatch(text, pattern) && text.Length == 25)
                {

                    for (int j = 0; j < text.Length; j++)
                    {
                        char symbol = text[j];

                        if (char.IsDigit(symbol))
                        {
                            int digit = int.Parse(symbol.ToString());
                            int newDigit = 9 - digit;
                            string textToAdd = newDigit.ToString();
                            sb.Append(textToAdd);
                        }
                        else if (char.IsLower(symbol))
                        {
                            string textToAdd = symbol.ToString().ToUpper();
                            sb.Append(textToAdd);
                        }
                        else
                        {
                            sb.Append(symbol);
                        }
                        if ((j != text.Length - 1) && ((j + 1) % 5 == 0))
                        {
                            sb.Append("-");
                        }
                    }
                    string textToAddToList = sb.ToString();
                    messages.Add(textToAddToList);
                }

            }
            Console.WriteLine(string.Join(", ", messages));
        }
    }
}
