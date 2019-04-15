using System;
using System.Linq;
using System.Text;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string bannedWord = bannedWords[i];
                string replacementWord = new string('*', bannedWord.Length);
                while (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, replacementWord);
                }
            }
            Console.WriteLine(text);
        }
    }
}
