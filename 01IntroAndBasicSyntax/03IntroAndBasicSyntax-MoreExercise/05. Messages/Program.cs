using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_05_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string command = Console.ReadLine();

                int length = command.Length;
                int digit = int.Parse(command) % 10;

                int offset = (digit - 2) * 3;

                if (digit == 8 || digit == 9)
                {

                    offset += 1;
                }

                int letterIndex = (offset + length - 1);

                char letter = (char)(letterIndex + 97);
                if (int.Parse(command) == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(letter);
                }
            }
        }
    }
}