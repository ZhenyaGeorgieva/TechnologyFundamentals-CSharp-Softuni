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
            int firstSymbol = int.Parse(Console.ReadLine());
            int secondSymbol = int.Parse(Console.ReadLine());

            for (int i = firstSymbol; i <= secondSymbol; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
