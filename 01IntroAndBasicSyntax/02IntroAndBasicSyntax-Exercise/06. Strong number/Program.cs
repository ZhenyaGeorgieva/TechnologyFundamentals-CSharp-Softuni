using System;

class Program
{
    static void Main()
    {
        int initialNumber = int.Parse(Console.ReadLine());
        long sumFactoriels = 0;
        int number = initialNumber;
        while (number > 0)
        {

            int digit = number % 10;

            long factorial = 1;

            while (true)
            {
                if (digit <= 1)
                {
                    break;
                }
                factorial *= digit;
                digit--;
            }
            sumFactoriels += factorial;
            number = number / 10;
        }
        if (initialNumber == sumFactoriels)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}