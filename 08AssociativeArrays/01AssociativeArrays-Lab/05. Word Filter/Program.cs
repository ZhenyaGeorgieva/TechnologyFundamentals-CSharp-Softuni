using System;
using System.Linq;

namespace _03WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWords = Console.ReadLine().Split().ToArray();
            string[] wordsWithEvenLength = arrayOfWords.Where(x => x.Length % 2 == 0).ToArray();
            foreach (var x in wordsWithEvenLength)
            {
                Console.WriteLine(x);
            }
        }
    }
}
