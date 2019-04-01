using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int ASCIIcode = (int)letter;
                totalSum += ASCIIcode;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}