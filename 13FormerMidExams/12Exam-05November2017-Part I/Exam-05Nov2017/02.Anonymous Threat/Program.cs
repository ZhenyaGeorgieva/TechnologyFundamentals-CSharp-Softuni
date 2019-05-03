using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AnonimousTreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
     
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "3:1")
                {
                    break;
                }
                else
                {

                    string[] tokens = command.Split().ToArray();
                    string action = tokens[0];
                    if (action == "merge")
                    {
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        string concatWord = string.Empty;
                        if (endIndex > names.Count - 1 || endIndex < 0)
                        {
                            endIndex = names.Count - 1;
                        }
                        if (startIndex < 0 || startIndex > names.Count)
                        {
                            startIndex = 0;
                        }
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatWord += names[i];
                        }
                        names.RemoveRange(startIndex, endIndex - startIndex + 1);
                        names.Insert(startIndex, concatWord);
                    }
                    else if (action == "divide")
                    {
                        int index = int.Parse(tokens[1]);
                        int partitions = int.Parse(tokens[2]);
                        string wordToDivide = names[index];
                        int lengthOfWord = wordToDivide.Length;
                        int lengthOfSubstring = lengthOfWord / partitions;
                        List<string> substrings = new List<string>();
                        int i = 0;
                        for (i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                substrings.Add(wordToDivide.Substring(i * lengthOfSubstring));
                            }
                            else
                            {
                                substrings.Add(wordToDivide.Substring(i * lengthOfSubstring, lengthOfSubstring));
                            }
                        }
                        names.RemoveAt(index);
                        names.InsertRange(index, substrings);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}