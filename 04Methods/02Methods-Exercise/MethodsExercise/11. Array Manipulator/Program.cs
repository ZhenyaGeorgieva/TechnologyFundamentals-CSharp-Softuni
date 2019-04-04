using System;
using System.Collections.Generic;
using System.Linq;

namespace _11ArrayManipulator_myV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] tokens = commands.Split().ToArray();
                string action = tokens[0];

                if (action == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index < 0 || index >= integersList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        List<int> listToPrint = new List<int>();
                        if (index != integersList.Count - 1)
                        {
                            for (int i = index + 1; i < integersList.Count; i++)
                            {
                                listToPrint.Add(integersList[i]);
                            }
                            for (int i = 0; i < index + 1; i++)
                            {
                                listToPrint.Add(integersList[i]);
                            }
                            integersList = listToPrint;
                        }
                    }
                }
                else if (action == "max")
                {
                    if (tokens[1] == "even")
                    {
                        int maxEven = int.MinValue;
                        int maxEvenIndex = -1;

                        for (int i = 0; i < integersList.Count; i++)
                        {
                            if (integersList[i] % 2 == 0 && integersList[i] >= maxEven)
                            {
                                maxEven = integersList[i];
                                maxEvenIndex = i;
                            }
                        }
                        if (maxEvenIndex != -1)
                        {
                            Console.WriteLine(maxEvenIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (tokens[1] == "odd")
                    {
                        int maxOdd = int.MinValue;
                        int maxOddIndex = -1;

                        for (int i = 0; i < integersList.Count; i++)
                        {
                            if (integersList[i] % 2 != 0 && integersList[i] >= maxOdd)
                            {
                                maxOdd = integersList[i];
                                maxOddIndex = i;
                            }
                        }
                        if (maxOddIndex != -1)
                        {
                            Console.WriteLine(maxOddIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (action == "min")
                {
                    if (tokens[1] == "even")
                    {
                        int minEven = int.MaxValue;
                        int minEvenIndex = -1;

                        for (int i = 0; i < integersList.Count; i++)
                        {
                            if (integersList[i] % 2 == 0 && integersList[i] <= minEven)
                            {
                                minEven = integersList[i];
                                minEvenIndex = i;
                            }
                        }
                        if (minEvenIndex != -1)
                        {
                            Console.WriteLine(minEvenIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (tokens[1] == "odd")
                    {
                        int minOdd = int.MaxValue;
                        int minOddIndex = -1;

                        for (int i = 0; i < integersList.Count; i++)
                        {
                            if (integersList[i] % 2 != 0 && integersList[i] <= minOdd)
                            {
                                minOdd = integersList[i];
                                minOddIndex = i;
                            }
                        }
                        if (minOddIndex != -1)
                        {
                            Console.WriteLine(minOddIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (action == "first")
                {
                    int countOfElements = int.Parse(tokens[1]);

                    if (countOfElements > integersList.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.Write("[");
                        if (tokens[2] == "even")
                        {
                            var listToPrint = integersList.Where(x => x % 2 == 0).Take(countOfElements).ToList();
                            Console.Write(string.Join(", ", listToPrint));
                        }

                        else if (tokens[2] == "odd")
                        {

                            var listToPrint = integersList.Where(x => x % 2 != 0).Take(countOfElements).ToList();
                            Console.Write(string.Join(", ", listToPrint));
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                }
                else if (action == "last")
                {
                    int countOfElements = int.Parse(tokens[1]);

                    if (countOfElements > integersList.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.Write("[");
                        if (tokens[2] == "even")
                        {
                            var listToPrint = integersList.Where(x => x % 2 == 0).Reverse().Take(countOfElements).Reverse().ToList();
                            Console.Write(string.Join(", ", listToPrint));
                        }

                        else if (tokens[2] == "odd")
                        {
                            var listToPrint = integersList.Where(x => x % 2 != 0).Reverse().Take(countOfElements).Reverse().ToList();
                            Console.Write(string.Join(", ", listToPrint));
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                }
                commands = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", integersList));
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
