using System;
using System.Collections.Generic;

namespace _02WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var synonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>();
                }
                var existingWords = synonyms[word];
                existingWords.Add(synonym);
            }
            foreach (var kvp in synonyms)
            {
                var word = kvp.Key;
                List<string> synonym = kvp.Value;
                Console.WriteLine($"{word} - {string.Join(", ", synonym)}");
            }
        }
    }
}