using System;

namespace _02AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char limitFirst = char.Parse(Console.ReadLine());
            char limitSecond = char.Parse(Console.ReadLine());
            int firstNum = (int)limitFirst;
            int secondNum = (int)limitSecond;
            int bigger = 0;
            int smaller = 0;
            if (firstNum >= secondNum)
            {
                bigger = firstNum;
                smaller = secondNum;
            }
            else
            {
                bigger = secondNum;
                smaller = firstNum;
            }
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int numberToCompare = (int)text[i];
                if (numberToCompare > smaller && numberToCompare < bigger)
                {
                    sum += numberToCompare;
                }
            }
            Console.WriteLine(sum);
        }
    }
}