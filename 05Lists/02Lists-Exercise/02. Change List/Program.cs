using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line = Console.ReadLine();

            while (line != "end")
            {
                List<string> command = line.
                    Split()
                    .ToList();

                if (command[0] == "Delete")
                {
                    int numberToDelete = int.Parse(command[1]);
                    for (int i = 0; i < integersList.Count; i++)
                    {
                        if (integersList[i] == numberToDelete)
                        {
                            integersList.Remove(integersList[i]);
                        }
                    }
                }
                if (command[0] == "Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    integersList.Insert(index, numberToInsert);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", integersList));
        }
    }
}