using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> townBestTime = new Dictionary<string, int>();
            Dictionary<string, int> townPassangers = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Slide rule")
                {
                    break;
                }
                else
                {
                    string[] tokens = command.Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[1] != "ambush")
                    {
                        string town = tokens[0];
                        int time = int.Parse(tokens[1]);
                        int passangers = int.Parse(tokens[2]);
                        if (!townBestTime.ContainsKey(town))
                        {
                            townBestTime[town] = time;
                        }
                        else
                        {
                            if (time < townBestTime[town] && townBestTime[town] > 0)
                            {
                                townBestTime[town] = time;
                            }
                            if (townBestTime[town] == 0)
                            {
                                townBestTime[town] = time;
                            }
                        }
                        if (!townPassangers.ContainsKey(town))
                        {
                            townPassangers[town] = passangers;
                        }
                        else
                        {
                            townPassangers[town] += passangers;
                        }
                    }
                    else
                    {
                        string town = tokens[0];
                        int passangers = int.Parse(tokens[2]);
                        if (townPassangers.ContainsKey(town))
                        {
                            townPassangers[town] -= passangers;
                        }
                        if (townBestTime.ContainsKey(town))
                        {
                            townBestTime[town] = 0;
                        }
                    }
                }
            }
            foreach (var kvp in townBestTime.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                string town = kvp.Key;
                int time = kvp.Value;
                int passangers = townPassangers[town];
                if (passangers > 0 && time > 0)
                {
                    Console.WriteLine($"{town} -> Time: {time} -> Passengers: {passangers}");
                }
            }
        }
    }
}
