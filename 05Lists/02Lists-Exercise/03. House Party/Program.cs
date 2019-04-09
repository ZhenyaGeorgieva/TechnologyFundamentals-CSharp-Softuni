using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guestsList = new List<string>();
            for (int i = 0; i < commandsCount; i++)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();
                string nameOfGuest = command[0];
                if (command[2] == "going!")
                {
                    bool isItIncludedInList = false;
                    for (int j = 0; j < guestsList.Count; j++)
                    {
                        if (nameOfGuest == guestsList[j])
                        {
                            Console.WriteLine($"{nameOfGuest} is already in the list!");
                            isItIncludedInList = true;
                            break;
                        }
                    }
                    if (!isItIncludedInList)
                    {
                        guestsList.Add(nameOfGuest);

                    }
                }
                if (command[2] == "not")
                {
                    bool isItInTheList = false;

                    for (int y = 0; y < guestsList.Count; y++)
                    {
                        if (nameOfGuest == guestsList[y])
                        {
                            guestsList.Remove(nameOfGuest);
                            isItInTheList = true;
                            break;
                        }
                    }
                    if (!isItInTheList)
                    {
                        Console.WriteLine($"{nameOfGuest} is not in the list!");

                    }
                }
            }
            foreach (var name in guestsList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
