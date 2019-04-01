using System;
class Program
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());
        decimal numbersSum = 0;
        for (int i = 1; i <= numberCount; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            numbersSum += number;
        }
        Console.WriteLine(numbersSum);
    }
}