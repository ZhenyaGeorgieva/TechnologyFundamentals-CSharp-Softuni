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
            Dictionary<string, List<string>> wordsDefinitions = new Dictionary<string, List<string>>();
            string[] tokens = Console.ReadLine().Split(" | ");
            for (int i = 0; i < tokens.Length; i++)
            {
                string[] wordAndDefTokens = tokens[i].Split(": ");
                string word = wordAndDefTokens[0];
                string definition = wordAndDefTokens[1];
                if (!wordsDefinitions.ContainsKey(word))
                {
                    wordsDefinitions[word] = new List<string>();
                    wordsDefinitions[word].Add(definition);
                }
                else
                {
                    wordsDefinitions[word].Add(definition);
                }
            }
            string[] wordsToSearch = Console.ReadLine().Split(" | ");
            for (int i = 0; i < wordsToSearch.Length; i++)
            {
                string wordToSearchInDictionary = wordsToSearch[i];
                if (wordsDefinitions.ContainsKey(wordToSearchInDictionary))
                {
                    Console.WriteLine($"{wordToSearchInDictionary}");

                    foreach (var item in wordsDefinitions[wordToSearchInDictionary].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($"-{item}");
                    }
                }
            }
            string command = Console.ReadLine();
            if (command == "List")
            {
                foreach (var kvp in wordsDefinitions.OrderBy(x => x.Key))
                {
                    Console.Write($"{kvp.Key} ");
                }
            }

        }
    }
}

