using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            listOfIntegers.RemoveAll(n => n < 0);

            if (listOfIntegers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                listOfIntegers.Reverse();
                Console.WriteLine(string.Join(" ", listOfIntegers));
            }
        }
    }
}
