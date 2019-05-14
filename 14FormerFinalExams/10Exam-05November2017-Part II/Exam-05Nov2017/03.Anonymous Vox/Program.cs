using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _13.AnonimousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"([A-Za-z]{1,})(?<placeholder>[\S]{1,})\1";
            string text = Console.ReadLine();
            List<string> placeholders = new List<string>();
            var placeholdersCollection = Regex.Matches(text, regex);
            string text1 = string.Empty;
            if (Regex.IsMatch(text, regex))
            {
                foreach (Match x in placeholdersCollection)
                {
                    placeholders.Add(x.Groups["placeholder"].Value);
                }
            }
            string wordsString = Console.ReadLine();
            string regexWords = @"([{]{1})(?<words>[^{}]{1,})([}]{1})";
            List<string> words = new List<string>();
            var wordsCollection = Regex.Matches(wordsString, regexWords);
            if (Regex.IsMatch(wordsString, regexWords))
            {
                foreach (Match w in wordsCollection)
                {
                    words.Add(w.Groups["words"].Value);
                }
            }
            if (placeholders.Count <= words.Count)
            {

                for (int i = 0; i < placeholders.Count; i++)
                {
                    int indexOf = text.IndexOf(placeholders[i]);
                    text = text.Remove(indexOf, placeholders[i].Length);
                    text = text.Insert(indexOf, words[i]);
                }
            }
            else
            {
                for (int i = 0; i < words.Count; i++)
                {
                    int indexOf = text.IndexOf(placeholders[i]);
                    text = text.Remove(indexOf, placeholders[i].Length);
                    text = text.Insert(indexOf, words[i]);
                }
            }
            Console.WriteLine(text);
        }
    }
}