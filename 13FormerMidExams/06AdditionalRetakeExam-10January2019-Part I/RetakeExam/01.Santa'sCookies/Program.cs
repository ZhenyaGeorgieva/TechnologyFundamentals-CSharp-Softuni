using System;

namespace _01Santa_sCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchesCount = int.Parse(Console.ReadLine());
            int totalBoxes = 0;
            for (int i = 0; i < batchesCount; i++)
            {
                double flourGr = double.Parse(Console.ReadLine());
                double sugarGr = double.Parse(Console.ReadLine());
                double cocoaGr = double.Parse(Console.ReadLine());


                int flourCups = (int)Math.Floor(flourGr / 140.0);
                int sugarSpoons = (int)Math.Floor(sugarGr / 20.0);
                int cocoaSpoons = (int)Math.Floor(cocoaGr / 10.0);

                if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }
                else
                {
                    int minTemp = int.MaxValue;
                    if (flourCups <= sugarSpoons)
                    {
                        minTemp = flourCups;
                    }
                    else
                    {
                        minTemp = sugarSpoons;
                    }
                    double dozi = Math.Min(minTemp, cocoaSpoons);
                    double totalCookies = dozi * (170 / 25.0);

                    double boxesPerBatch = Math.Floor(totalCookies / 5.0);

                    totalBoxes += (int)boxesPerBatch;
                    Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                }
            }
            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
