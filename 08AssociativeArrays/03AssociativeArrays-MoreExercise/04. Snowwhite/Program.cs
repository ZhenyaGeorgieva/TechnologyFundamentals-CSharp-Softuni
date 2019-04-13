using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Dwarf> dwarf = new List<Dwarf>();

            while (input != "Once upon a time")
            {
                string[] splitedInput = input.Split(new string[] { " <:> " }, StringSplitOptions.None);

                string dwarfName = splitedInput[0];
                string dwarfColor = splitedInput[1];
                BigInteger dwarfPhysics = BigInteger.Parse(splitedInput[2]);

                Dwarf dd = new Dwarf();

                dd.Color = dwarfColor;
                dd.Name = dwarfName;
                dd.Physics = dwarfPhysics;

                bool contains = false;
                for (int i = 0; i < dwarf.Count; i++)
                {
                    if (dwarf[i].Name == dd.Name && dwarf[i].Color == dd.Color)
                    {
                        if (dwarf[i].Physics < dd.Physics) dwarf[i].Physics = dd.Physics;
                        contains = true;
                    }
                }

                if (!contains)
                {
                    int count = dwarf.Where(x => x.Color == dwarfColor).Count() + 1;
                    dd.ColorCount = count;
                    dwarf.Add(dd);
                    foreach (var item in dwarf.Where(x => x.Color == dwarfColor))
                    {
                        item.ColorCount = count;
                    }
                }

                input = Console.ReadLine();
            }
            var tmpDwarf = dwarf;

            foreach (var item in dwarf.OrderByDescending(z => z.Physics).ThenByDescending(z => z.ColorCount))
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
            }
        }
        class Dwarf
        {
            public string Color { get; set; }
            public string Name { get; set; }
            public BigInteger Physics { get; set; }
            public int ColorCount { get; set; }
        }
    }
}