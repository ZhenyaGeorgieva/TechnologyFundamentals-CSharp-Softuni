using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumOddNumbers = 0;
        int number = 1;
        int counter = 1;

        while (counter <= n)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
                sumOddNumbers += number;
                counter += 1;
            }
            number += 1;
        }
        Console.WriteLine($"Sum: {sumOddNumbers}");
    }
}
