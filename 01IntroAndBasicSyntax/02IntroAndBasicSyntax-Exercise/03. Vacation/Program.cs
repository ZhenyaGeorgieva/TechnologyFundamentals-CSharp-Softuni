using System;
class Program
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();
        double singlePrice = 0;
        double total = 0;
        if (groupType == "Students")
        {
            if (day == "Friday")
            {
                singlePrice = 8.45;
            }
            else if (day == "Saturday")
            {
                singlePrice = 9.8;
            }
            else if (day == "Sunday")
            {
                singlePrice = 10.46;
            }
            total = groupSize * singlePrice;
            if (groupSize >= 30)
            {
                total = 0.85 * total;
            }
        }
        if (groupType == "Business")
        {
            if (day == "Friday")
            {
                singlePrice = 10.9;
            }
            else if (day == "Saturday")
            {
                singlePrice = 15.6;
            }
            else if (day == "Sunday")
            {
                singlePrice = 16;
            }
            total = groupSize * singlePrice;
            if (groupSize >= 100)
            {
                total = total - (singlePrice * 10);
            }
        }
        if (groupType == "Regular")
        {
            if (day == "Friday")
            {
                singlePrice = 15;
            }
            else if (day == "Saturday")
            {
                singlePrice = 20;
            }
            else if (day == "Sunday")
            {
                singlePrice = 22.5;
            }
            total = groupSize * singlePrice;
            if (groupSize >= 10 && groupSize <= 20)
            {
                total = total * 0.95;
            }
        }
        Console.WriteLine($"Total price: {total:f2}");
    }
}