using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double pokePowerM = double.Parse(Console.ReadLine());
            double initialPokePowerM = pokePowerM;
            double distanceN = int.Parse(Console.ReadLine());
            int exhaustFactorY = int.Parse(Console.ReadLine());
            int pokeCount = 0;
            while (true)
            {
                if (pokePowerM == 0.5 * initialPokePowerM)
                {
                    if (exhaustFactorY != 0)
                    {
                        pokePowerM = (int)(pokePowerM / exhaustFactorY);
                    }
                }
                if (pokePowerM >= distanceN)
                {
                    pokePowerM -= distanceN;
                    pokeCount++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(pokePowerM);
            Console.WriteLine(pokeCount);
        }
    }
}