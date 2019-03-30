using System;
class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int number = 1;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {

                Console.Write($"{number} ");
            }
            number++;
            Console.WriteLine();
        }
    }
}