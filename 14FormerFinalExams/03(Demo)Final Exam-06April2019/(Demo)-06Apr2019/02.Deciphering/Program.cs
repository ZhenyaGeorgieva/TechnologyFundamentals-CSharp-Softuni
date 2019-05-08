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
            string pattern = @"^[d-z{}\|#]{1,}$";
            string text = Console.ReadLine();
            string[] textForReplacement = Console.ReadLine().Split();

            if (Regex.IsMatch(text, pattern))
            {
                var collectionOfText = Regex.Matches(text, pattern);
                string word = string.Empty;
                foreach (Match item in collectionOfText)
                {
                    word = item.Value.ToString();
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {
                    char currentSymbol = word[i];
                    int currentSymbolCode = (int)currentSymbol;
                    int newSymbolCode = currentSymbolCode - 3;
                    char newSymbolToAdd = (char)newSymbolCode;
                    sb.Append(newSymbolToAdd);
                }
                string oldWord = textForReplacement[0];
                string newWord = textForReplacement[1];
                sb.Replace(oldWord, newWord);
                string messageToPrint = sb.ToString();
                Console.WriteLine(messageToPrint);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}