using System;

namespace MidExam10._03._2019Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energyGroup = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());
            bool stopped = false;
            double waterSupply = waterPerDayPerPerson * players * days;
            double foodSupply = foodPerDayPerPerson * players * days;
            for (int i = 1; i <= days; i++)
            {
                double amountOfEnergyLoss = double.Parse(Console.ReadLine());
                energyGroup -= amountOfEnergyLoss;
                if (energyGroup <= 0)
                {
                    stopped = true;
                    break;
                }
                if (i % 2 == 0)
                {
                    energyGroup += 0.05 * energyGroup;
                    waterSupply -= 0.3 * waterSupply;
                }
                if (i % 3 == 0)
                {
                    foodSupply -= foodSupply / (double)players;
                    energyGroup += energyGroup * 0.1;
                }
            }
            if (!stopped)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyGroup:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodSupply:f2} food and {waterSupply:f2} water.");
            }
        }
    }
}
