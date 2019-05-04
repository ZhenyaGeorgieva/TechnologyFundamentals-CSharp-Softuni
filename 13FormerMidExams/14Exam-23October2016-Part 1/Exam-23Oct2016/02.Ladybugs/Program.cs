using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] positionsOfLadybugs =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < positionsOfLadybugs.Length; j++)
                {
                    if (i == positionsOfLadybugs[j])
                    {
                        field[i] = 1;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] givenDirections =
                    command
                    .Split()
                    .ToArray();

                int indexOfLadybug = int.Parse(givenDirections[0]);
                string directionOfFlight = givenDirections[1];
                int lengthOfFlight = int.Parse(givenDirections[2]);
                bool thereIsALadybugHere = true;

                while (indexOfLadybug >= 0 && indexOfLadybug < fieldSize && field[indexOfLadybug] == 1)
                {
                    if (thereIsALadybugHere)
                    {
                        thereIsALadybugHere = false;
                        field[indexOfLadybug] = 0;
                    }
                    if (directionOfFlight == "left")
                    {
                        indexOfLadybug -= lengthOfFlight;
                        if (indexOfLadybug >= 0 && indexOfLadybug < fieldSize && field[indexOfLadybug] == 0)
                        {
                            field[indexOfLadybug] = 1;
                            break;
                        }
                    }
                    if (directionOfFlight == "right")
                    {
                        indexOfLadybug += lengthOfFlight;
                        if (indexOfLadybug >= 0 && indexOfLadybug < fieldSize && field[indexOfLadybug] == 0)
                        {
                            field[indexOfLadybug] = 1;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}