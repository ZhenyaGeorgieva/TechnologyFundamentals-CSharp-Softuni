using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int originalValueN = powerN;
            decimal halfOfOriginal = originalValueN / 2.0m;
            int distanceM = int.Parse(Console.ReadLine());
            int exhauseFactorY = int.Parse(Console.ReadLine());
            int targets = 0;

            while (powerN >= distanceM)
            {
                powerN -= distanceM;
                targets++;
                if (powerN == halfOfOriginal)
                {
                    if (exhauseFactorY != 0)
                    {
                        powerN /= exhauseFactorY;
                    }
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(targets);
        }
    }
}
