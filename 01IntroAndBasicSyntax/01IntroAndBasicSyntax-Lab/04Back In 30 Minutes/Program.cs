using System;
class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes = minutes + 30;
        if (minutes > 59)
        {
            hours += 1;
            minutes = minutes - 60;
            if (hours < 24)
            {
                Console.WriteLine($"{hours}:{(minutes):D2}");
            }
            else
            {
                hours = hours - 24;
                Console.WriteLine($"{hours}:{(minutes):D2}");
            }
        }
        else
        {

            if (hours < 24)
            {
                Console.WriteLine($"{hours}:{(minutes):D2}");
            }
            else
            {
                hours = hours - 24;
                Console.WriteLine($"{hours}:{(minutes):D2}");
            }
        }
    }
}
