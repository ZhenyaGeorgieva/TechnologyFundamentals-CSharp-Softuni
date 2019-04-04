using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacter(text);
        }
        public static void PrintMiddleCharacter(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write($"{(char)text[text.Length / 2 - 1]}{(char)text[text.Length / 2]}");
            }
            else
            {
                Console.Write((char)text[text.Length / 2]);

            }
        }
    }
}
