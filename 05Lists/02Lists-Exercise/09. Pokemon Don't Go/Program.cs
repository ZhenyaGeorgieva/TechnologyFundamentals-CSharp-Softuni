using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sumOfRemoved = 0;
            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int number = 0;
                if (index < 0)
                {
                    number = list[0];
                    sumOfRemoved += number;
                    list.RemoveAt(0);
                    int lastElement = list[list.Count - 1];
                    list.Insert(0, lastElement);
                }
                else if (index > list.Count - 1)
                {
                    number = list[list.Count - 1];
                    sumOfRemoved += number;
                    list.RemoveAt(list.Count - 1);
                    int firstElement = list[0];
                    list.Add(firstElement);
                }
                else
                {
                    number = list[index];
                    sumOfRemoved += number;
                    list.RemoveAt(index);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= number)
                    {
                        list[i] += number;
                    }
                    else
                    {
                        list[i] -= number;
                    }
                }
            }
            Console.WriteLine(sumOfRemoved);
        }
    }
}