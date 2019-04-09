using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfNumbers =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombCredentials =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombSpecialNumber = bombCredentials[0];
            int bombPower = bombCredentials[1];
            int sum = 0;
            while (sequenceOfNumbers.Contains(bombSpecialNumber))
            {
                List<int> newList = new List<int>();
                int index = sequenceOfNumbers.IndexOf(bombSpecialNumber);
                for (int i = 0; i < sequenceOfNumbers.Count; i++)
                {
                    if (i < index - bombPower || i > index + bombPower)
                    {
                        newList.Add(sequenceOfNumbers[i]);

                    }
                }
                sequenceOfNumbers = newList;
            }
            for (int i = 0; i < sequenceOfNumbers.Count; i++)
            {
                sum += sequenceOfNumbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}