using System;
using System.Linq;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initial = Console.ReadLine().Split().ToArray();
            string firstText = initial[0];
            string secondText = initial[1];

            int lengthOne = firstText.Length;
            int lengthTwo = secondText.Length;

            string longerString = string.Empty;
            string shorterString = string.Empty;
            if (lengthOne >= lengthTwo)
            {
                shorterString = secondText;
                longerString = firstText;
            }
            else
            {
                shorterString = firstText;
                longerString = secondText;
            }
            int totalSum = 0;
            for (int i = 0; i < shorterString.Length; i++)
            {
                totalSum += (int)shorterString[i] * (int)longerString[i];
            }
            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                totalSum += (int)longerString[i];
            }
            Console.WriteLine(totalSum);
        }
    }
}