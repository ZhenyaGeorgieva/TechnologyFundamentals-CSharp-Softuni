using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char initialIndex = char.Parse(Console.ReadLine());
            char finalIndex = char.Parse(Console.ReadLine());
            PrintCharactersInRange(initialIndex, finalIndex);
        }
        public static void PrintCharactersInRange(char startingIndex, char finalIndex)
        {
            if ((int)startingIndex <= (int)finalIndex)
            {
                for (int i = (int)startingIndex + 1; i < (int)finalIndex; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = (int)finalIndex + 1; i < (int)startingIndex; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
