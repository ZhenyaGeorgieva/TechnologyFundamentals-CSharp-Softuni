using System;
using System.Collections.Generic;
using System.Linq;

namespace _05OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfWords = Console.ReadLine().Split().ToArray();
            var dictionaryOfWords = new Dictionary<string, int>();

            for (int i = 0; i < listOfWords.Length; i++)
            {
                string word = listOfWords[i].ToLower();
                if (!dictionaryOfWords.ContainsKey(word))
                {
                    dictionaryOfWords[word] = 1;
                }
                else
                {
                    dictionaryOfWords[word]++;
                }
            }
            foreach (var x in dictionaryOfWords)
            {
                int count = x.Value;
                if (count % 2 != 0)
                {
                    Console.Write($"{x.Key} ");
                }
            }
        }
    }
}