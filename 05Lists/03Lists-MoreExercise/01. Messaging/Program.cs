using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNumbers =
                Console.ReadLine()
                    .Split()
                    .ToList();
            List<char> message = Console.ReadLine()
                .ToList();

            List<char> wordToPrint = new List<char>();

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int number = int.Parse(listOfNumbers[i]);
                int sum = 0;
                int index = -1;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }
                if (sum >= 0 && sum < message.Count)
                {
                    index = sum;
                }
                if (sum == message.Count)
                {
                    index = 0;

                }
                if (sum > message.Count)
                {
                    index = sum % message.Count;
                }
                char charToAdd = message[index];
                wordToPrint.Add(message[index]);
                message.RemoveAt(index);
            }
            for (int i = 0; i < wordToPrint.Count; i++)
            {

                Console.Write(wordToPrint[i]);
            }
            Console.WriteLine();
        }
    }
}
