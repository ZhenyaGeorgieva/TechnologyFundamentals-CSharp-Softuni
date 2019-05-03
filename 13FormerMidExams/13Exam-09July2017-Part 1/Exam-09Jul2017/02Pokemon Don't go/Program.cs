using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PokeMonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                int elementToRemove = int.MaxValue;
                if (index < 0)
                {
                    elementToRemove = pokemons[0];
                    sum += elementToRemove;
                    pokemons.RemoveAt(0);
                    int elementToInsert = pokemons[pokemons.Count - 1];
                    pokemons.Insert(0, elementToInsert)
;
                }
                else if (index > pokemons.Count - 1)
                {
                    elementToRemove = pokemons[pokemons.Count - 1];
                    sum += elementToRemove;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    int elementToInsert = pokemons[0];
                    pokemons.Add(elementToInsert);
                }
                else
                {
                    elementToRemove = pokemons[index];
                    sum += elementToRemove;
                    pokemons.RemoveAt(index);
                }
                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= elementToRemove)
                    {
                        pokemons[i] += elementToRemove;
                    }
                    else
                    {
                        pokemons[i] -= elementToRemove;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}