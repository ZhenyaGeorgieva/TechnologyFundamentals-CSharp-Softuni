using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ListsManipulation
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

            while (command != "end")
            {
                List<string> commandTranslated =
                    command
                    .Split()
                    .ToList();
                if (commandTranslated[0] == "Add")
                {
                    listToManipulate.Add(int.Parse(commandTranslated[1]));
                }
                if (commandTranslated[0] == "Remove")
                {
                    listToManipulate.Remove(int.Parse(commandTranslated[1]));
                }
                if (commandTranslated[0] == "RemoveAt")
                {
                    listToManipulate.RemoveAt(int.Parse(commandTranslated[1]));
                }
                if (commandTranslated[0] == "Insert")
                {
                    listToManipulate.Insert(int.Parse(commandTranslated[2]), int.Parse(commandTranslated[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listToManipulate));
        }
    }
}