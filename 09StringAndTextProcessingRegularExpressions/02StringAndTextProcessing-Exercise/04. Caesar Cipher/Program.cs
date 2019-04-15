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
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int symbolNumberEnscrypted = (int)text[i] + 3;
                char enscryptedChar = (char)symbolNumberEnscrypted;
                sb.Append(enscryptedChar);
            }
            Console.WriteLine(sb);
        }
    }
}