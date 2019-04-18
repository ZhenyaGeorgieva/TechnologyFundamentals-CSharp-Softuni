using System;
using System.Collections.Generic;
using System.Linq;

namespace _03TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                if (action == "Delete")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= -1 && index < list.Count - 1)
                    {
                        list.RemoveAt(index + 1);
                    }
                }
                else if (action == "Swap")
                {
                    string word1 = tokens[1];
                    string word2 = tokens[2];
                    if (list.Contains(word1) && list.Contains(word2))
                    {
                        int indexWord1 = list.IndexOf(word1);
                        int indexWord2 = list.IndexOf(word2);
                        string temp = list[indexWord1];
                        list[indexWord1] = list[indexWord2];
                        list[indexWord2] = temp;
                    }
                }
                else if (action == "Put")
                {
                    string word = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if (index - 1 >= 0 && index - 2 < list.Count)
                    {
                        list.Insert(index - 1, word);
                    }
                }
                else if (action == "Sort")
                {
                    list.Sort();
                    list.Reverse();
                }
                else if (action == "Replace")
                {
                    string word1 = tokens[1];
                    string word2 = tokens[2];
                    if (list.Contains(word2))
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == word2)
                            {
                                if (i != list.Count - 1)
                                {
                                    list.RemoveAt(i);
                                    list.Insert(i, word1);
                                }
                                else
                                {
                                    list.RemoveAt(i);
                                    list.Add(word1);
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
