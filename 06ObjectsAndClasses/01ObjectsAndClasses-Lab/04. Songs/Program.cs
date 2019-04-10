using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Songs_my
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Songs> listOfSongs = new List<Songs>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] tokens = Console.ReadLine()
                     .Split("_")
                     .ToArray();
                string typeLists = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Songs song = new Songs();
                song.TypeLists = typeLists;
                song.Name = name;
                song.Time = time;

                listOfSongs.Add(song);
            }
            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach (var x in listOfSongs)
                {
                    Console.WriteLine($"{x.Name}");
                }
            }
            else
            {
                List<Songs> selectedSongs = listOfSongs.Where(x => x.TypeLists == command).Select(x => x).ToList();
                foreach (var x in selectedSongs)
                {
                    Console.WriteLine($"{x.Name}");
                }
            }
        }
        class Songs
        {
            public string TypeLists { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}