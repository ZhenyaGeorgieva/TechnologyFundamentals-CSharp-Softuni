using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        if (multiplier <= 10)
        {
            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
        }
    }
}
