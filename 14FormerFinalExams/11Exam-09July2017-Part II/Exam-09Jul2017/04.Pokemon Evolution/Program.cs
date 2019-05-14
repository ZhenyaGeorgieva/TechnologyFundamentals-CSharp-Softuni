using System;
using System.Collections.Generic;
using System.Linq;

namespace _22.PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pokemonEvolutionIndex = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "wubbalubbadubdub")
            {
                if (input.Contains("->"))
                {
                    string[] command = input
                        .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string pokemon = command[0].Trim();
                    string evolution = command[1].Trim();
                    int index = int.Parse(command[2].Trim());

                    if (!pokemonEvolutionIndex.ContainsKey(pokemon))
                    {
                        pokemonEvolutionIndex[pokemon] = new List<string>();
                        string stringToAdd = evolution + ">" + index;
                        pokemonEvolutionIndex[pokemon].Add(stringToAdd);
                    }
                    else
                    {
                        string stringToAdd = evolution + ">" + index;
                        pokemonEvolutionIndex[pokemon].Add(stringToAdd);
                    }
                }
                else
                {
                    string pokemon = input;
                    if (pokemonEvolutionIndex.ContainsKey(pokemon))
                    {
                        Console.WriteLine($"# {pokemon}");
                        foreach (var x in pokemonEvolutionIndex[pokemon])
                        {
                            string[] evolutionAndValue = x.Split(new char[] { '>' });
                            string evolution = evolutionAndValue[0];
                            int value = int.Parse(evolutionAndValue[1]);
                            Console.WriteLine($"{ evolution} <-> { value}");
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var kvp in pokemonEvolutionIndex)
            {
                string pokemon = kvp.Key;
                Console.WriteLine($"# {pokemon}");
                var evolutionAndValue = kvp.Value;
                foreach (var item in evolutionAndValue.OrderByDescending(x => int.Parse(x.Split(new char[] { '>' })[1])))
                {
                    string[] tokens = item.Split(new char[] { '>' });
                    string evolution = tokens[0];
                    int value = int.Parse(tokens[1]);
                    Console.WriteLine($"{ evolution} <-> { value}");
                }
            }
        }
    }
}

