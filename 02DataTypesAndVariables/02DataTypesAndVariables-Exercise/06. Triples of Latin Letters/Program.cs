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
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int x = 97; x < 97 + n; x++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)x}");
                    }
                }
            }
        }
    }
}