using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(new[] { '|' })
                .ToList();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                List<string> IncorporatedList = list[i]
                     .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .ToList();
                foreach (var number in IncorporatedList)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}