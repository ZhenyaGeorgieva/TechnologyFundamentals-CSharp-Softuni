using System;
using System.Linq;
using System.Text;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToReplace = Console.ReadLine().ToLower();
            string stringOfWords = Console.ReadLine();
            while (stringOfWords.Contains(wordToReplace))
            {
                stringOfWords = stringOfWords.Replace(wordToReplace, "");
            }

            Console.WriteLine(string.Join("", stringOfWords));
        }
    }
}
