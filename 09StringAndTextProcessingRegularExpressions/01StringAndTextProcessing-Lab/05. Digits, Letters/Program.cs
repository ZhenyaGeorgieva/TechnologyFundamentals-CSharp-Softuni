using System;
using System.Linq;
using System.Text;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (char.IsDigit(symbol))
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (char.IsLetter(symbol))
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (!char.IsLetterOrDigit(symbol))
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
        }
    }
}