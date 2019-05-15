namespace _03.Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long beehiveCount = beehives[i];

                long hornetPower = SumHornetsPower(hornets);


                beehives[i] -= hornetPower;

                if (beehiveCount >= hornetPower)
                {
                    hornets.RemoveAt(0);
                }
            }

            PrintWinningSide(beehives, hornets);
        }

        private static long SumHornetsPower(List<long> hornets)
        {
            long sum = 0L;

            foreach (var hornet in hornets)
            {
                sum += hornet;
            }
            return sum;
        }

        private static void PrintWinningSide(long[] beehives, List<long> hornets)
        {
            List<long> aliveBeehives = new List<long>();

            foreach (var beehive in beehives)
            {
                if (beehive > 0)
                {
                    aliveBeehives.Add(beehive);
                }
            }

            if (aliveBeehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}