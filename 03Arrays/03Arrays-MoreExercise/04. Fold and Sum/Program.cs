using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                  Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();
            int k = numbers.Length / 4;
            int[] foldedFront = new int[k];
            int[] foldedBack = new int[k];

            int[] central = new int[numbers.Length - 2 * k];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < k)
                {
                    foldedFront[i] = numbers[i];
                }
                if (i >= k && i <= numbers.Length - 1 - k)
                {
                    central[i - k] = numbers[i];
                }
            }
            for (int i = numbers.Length - 1; i >= numbers.Length - k; i--)
            {
                foldedBack[numbers.Length - 1 - i] = numbers[i];
            }

            Array.Reverse(foldedFront);

            int[] combined = foldedFront.Concat(foldedBack).ToArray();

            int[] ToPrint = new int[central.Length];

            for (int i = 0; i < ToPrint.Length; i++)
            {
                ToPrint[i] = central[i] + combined[i];
            }
            Console.WriteLine(string.Join(" ", ToPrint));
        }
    }
}