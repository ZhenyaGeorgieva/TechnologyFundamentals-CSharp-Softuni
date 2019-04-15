using System;
using System.Linq;
using System.Text;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                int wordLength = words[i].Length;
                for (int j = 0; j < wordLength; j++)
                {
                    sb.Append(words[i]);
                }
            }
            Console.WriteLine(string.Join("", sb));
        }
    }
}