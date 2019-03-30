using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int maxDivisionNumber = int.MinValue;

        if (number % 2 == 0)
        {
            maxDivisionNumber = 2;
        }
        if (number % 3 == 0)
        {
            maxDivisionNumber = 3;
        }
        if (number % 6 == 0)
        {
            maxDivisionNumber = 6;

        }
        if (number % 7 == 0)
        {
            maxDivisionNumber = 7;
        }
        if (number % 10 == 0)
        {
            maxDivisionNumber = 10;
        }
        if (maxDivisionNumber == int.MinValue)
        {
            Console.WriteLine("Not divisible");
        }
        else
        {
            Console.WriteLine($"The number is divisible by {maxDivisionNumber}");
        }
    }
}