using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> tokens = command.Split().ToList();
                string action = tokens[0];
                if (action == "Chat")
                {
                    list.Add(tokens[1]);
                }
                else if (action == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == tokens[1])
                        {
                            list.Remove(tokens[1]);
                        }
                    }
                }
                else if (action == "Edit")
                {

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == tokens[1])
                        {
                            list[i] = list[i].Replace(tokens[1], tokens[2]);
                        }
                    }
                }
                else if (action == "Pin")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == tokens[1])
                        {
                            list.Add(tokens[1]);
                            list.Remove(tokens[1]);
                        }
                    }
                }
                else if (action == "Spam")
                {
                    for (int i = 1; i < tokens.Count; i++)
                    {
                        list.Add(tokens[i]);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}