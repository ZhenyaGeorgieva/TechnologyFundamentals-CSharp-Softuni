using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "End")
                {
                    break;
                }
                if (command == "Add")
                {
                    int number = int.Parse(input[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(input[1]);
                    int index = int.Parse(input[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, numberToInsert);
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(input[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {

                        numbers.RemoveAt(index);
                    }
                }
                else if (command == "Shift")
                {
                    string direction = input[1];
                    int rotations = int.Parse(input[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < rotations % numbers.Count; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.Add(firstNum);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotations % numbers.Count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNum);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
