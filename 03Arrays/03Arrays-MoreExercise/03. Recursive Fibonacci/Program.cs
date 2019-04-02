using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedFibNumber = int.Parse(Console.ReadLine());

            BigInteger[] fibArray = new BigInteger[wantedFibNumber];

            for (int i = 0; i < fibArray.Length; i++)
            {
                fibArray[0] = 1;
                if (fibArray.Length > 1)
                {
                    fibArray[1] = 1;
                }

                if (i > 1)
                {
                    fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
                }
            }
            Console.WriteLine(fibArray[fibArray.Length - 1]);
        }
    }
}
