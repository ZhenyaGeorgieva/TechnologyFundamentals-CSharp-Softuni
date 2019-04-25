using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split().ToArray();
                string action = tokens[0];

                if (action == "Change")
                {
                    int paintingNumber = int.Parse(tokens[1]);
                    int changedNumber = int.Parse(tokens[2]);
                    if (numbersList.Contains(paintingNumber))
                    {
                        int indexFirst = numbersList.IndexOf(paintingNumber);
                        numbersList.RemoveAt(indexFirst);
                        numbersList.Insert(indexFirst, changedNumber);
                    }
                }
                if (action == "Hide")
                {
                    int paintingNumber = int.Parse(tokens[1]);
                    numbersList.Remove(paintingNumber);
                }
                if (action == "Switch")
                {
                    int paintingNumber1 = int.Parse(tokens[1]);
                    int paintingNumber2 = int.Parse(tokens[2]);
                    if (numbersList.Contains(paintingNumber1) && numbersList.Contains(paintingNumber2))
                    {
                        int index1 = numbersList.IndexOf(paintingNumber1);
                        int index2 = numbersList.IndexOf(paintingNumber2);

                        numbersList.RemoveAt(index1);
                        numbersList.Insert(index1, paintingNumber2);
                        numbersList.RemoveAt(index2);
                        numbersList.Insert(index2, paintingNumber1);
                    }
                }
                if (action == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    int paintingToInsert = int.Parse(tokens[2]);
                    if (index >= 0 && index <= numbersList.Count - 1)
                    {
                        if (index == numbersList.Count - 1)
                        {
                            numbersList.Add(paintingToInsert);
                        }
                        else
                        {
                            numbersList.Insert(index + 1, paintingToInsert);
                        }
                    }
                }
                if (action == "Reverse")
                {
                    numbersList.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
