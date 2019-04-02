using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sequenceLength = 0;
            int maxSequence = 0;
            int maxNumber = 0;
            int lastNumbers = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1])
                {
                    if (lastNumbers == array[i])
                    {
                        sequenceLength += 1;
                    }
                    else
                    {
                        sequenceLength = 1;
                    }

                }
                if (sequenceLength > maxSequence)
                {
                    maxSequence = sequenceLength;
                    maxNumber = array[i];
                }
                lastNumbers = array[i];
            }

            for (int i = 0; i <= maxSequence; i++)
            {
                Console.Write(maxNumber + " ");
            }

        }
    }
}
