using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ListsManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listToManipulate =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int counterOfChanges = 0;
            while (command != "end")
            {
                List<string> commandTranslated =
                    command
                    .Split()
                    .ToList();
                if (commandTranslated[0] == "Add")
                {
                    listToManipulate.Add(int.Parse(commandTranslated[1]));
                    counterOfChanges++;
                }
                if (commandTranslated[0] == "Remove")
                {
                    listToManipulate.Remove(int.Parse(commandTranslated[1]));
                    counterOfChanges++;
                }
                if (commandTranslated[0] == "RemoveAt")
                {
                    listToManipulate.RemoveAt(int.Parse(commandTranslated[1]));
                    counterOfChanges++;
                }
                if (commandTranslated[0] == "Insert")
                {
                    listToManipulate.Insert(int.Parse(commandTranslated[2]), int.Parse(commandTranslated[1]));
                    counterOfChanges++;
                }
                if (commandTranslated[0] == "Contains")
                {
                    if (listToManipulate.Contains(int.Parse(commandTranslated[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (commandTranslated[0] == "PrintEven")
                {
                    for (int i = 0; i < listToManipulate.Count; i++)
                    {
                        if (listToManipulate[i] % 2 == 0)
                        {
                            Console.Write($"{listToManipulate[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                if (commandTranslated[0] == "PrintOdd")
                {
                    for (int i = 0; i < listToManipulate.Count; i++)
                    {
                        if (listToManipulate[i] % 2 != 0)
                        {
                            Console.Write($"{listToManipulate[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                if (commandTranslated[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < listToManipulate.Count; i++)
                    {
                        sum += listToManipulate[i];
                    }
                    Console.WriteLine(sum);
                }
                if (commandTranslated[0] == "Filter")
                {
                    string condition = commandTranslated[1];
                    int number = int.Parse(commandTranslated[2]);
                    List<int> newList = new List<int>();
                    if (condition == ">")
                    {
                        newList = listToManipulate
                              .Where(x => x > number)
                              .ToList();
                    }
                    if (condition == "<")
                    {
                        newList = listToManipulate
                              .Where(x => x < number)
                              .ToList();
                    }
                    if (condition == ">=")
                    {
                        newList = listToManipulate
                               .Where(x => x >= number)
                               .ToList();
                    }
                    if (condition == "<=")
                    {
                        newList = listToManipulate
                              .Where(x => x <= number)
                              .ToList();
                    }
                    Console.WriteLine(string.Join(" ", newList));
                }
                command = Console.ReadLine();
            }
            if (counterOfChanges > 0)
            {
                Console.WriteLine(string.Join(" ", listToManipulate));
            }
        }
    }
}
