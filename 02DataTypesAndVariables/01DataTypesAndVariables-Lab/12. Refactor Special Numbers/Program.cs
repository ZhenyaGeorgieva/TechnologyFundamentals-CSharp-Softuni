using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int counter = 1; counter <= number; counter++)
        {
            int numberForDividing = counter;
            int sumOfDigits = 0;
            while (numberForDividing > 0)
            {
                sumOfDigits += numberForDividing % 10;
                numberForDividing = numberForDividing / 10;
            }
            bool isSpecial = false;
            isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            Console.WriteLine($"{counter} -> {isSpecial}");
        }
    }
}