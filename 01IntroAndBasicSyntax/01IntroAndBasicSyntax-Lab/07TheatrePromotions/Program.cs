using System;
class Program
{
    static void Main()
    {
        string dayType = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        if (0 <= age && age <= 18)
        {
            if (dayType == "Weekday")
            {
                Console.WriteLine("12$");
            }
            else if (dayType == "Weekend")
            {
                Console.WriteLine("15$");

            }
            else if (dayType == "Holiday")
            {
                Console.WriteLine("5$");

            }
        }
        else if (18 < age && age <= 64)
        {
            if (dayType == "Weekday")
            {
                Console.WriteLine("18$");

            }
            else if (dayType == "Weekend")
            {
                Console.WriteLine("20$");

            }
            else if (dayType == "Holiday")
            {
                Console.WriteLine("12$");

            }
        }
        else if (64 < age && age <= 122)
        {
            if (dayType == "Weekday")
            {
                Console.WriteLine("12$");

            }
            else if (dayType == "Weekend")
            {
                Console.WriteLine("15$");

            }
            else if (dayType == "Holiday")
            {
                Console.WriteLine("10$");

            }
        }
        else
        {
            Console.WriteLine("Error!");
        }

    }
}
