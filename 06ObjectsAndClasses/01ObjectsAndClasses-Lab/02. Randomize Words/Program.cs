using System;
using System.Linq;

namespace _02RandomizeWords_my
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                 .Split()
                 .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length - 1; i++)
            {
                int random = rnd.Next(0, words.Length);
                string wordsRnd = words[random];
                words[random] = words[i];
                words[i] = wordsRnd;
            }
            foreach (var x in words)
            {
                Console.WriteLine(x);
            }
        }
    }
}