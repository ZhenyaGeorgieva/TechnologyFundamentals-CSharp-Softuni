using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());
            int[] valuesOfNames = new int[numberOfNames];

            for (int i = 0; i < numberOfNames; i++)
            {
                int sum = 0;
                string name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    int letterValue = 0;

                    char letter = (char)name[j];
                    if (letter == 'a'
                        || letter == 'e'
                        || letter == 'u'
                        || letter == 'i'
                        || letter == 'o'
                        || letter == 'A'
                        || letter == 'E'
                        || letter == 'U'
                        || letter == 'I'
                        || letter == 'O')
                    {
                        letterValue = (int)letter * name.Length;
                    }
                    else
                    {
                        letterValue = (int)letter / name.Length;
                    }
                    sum += letterValue;
                }
                valuesOfNames[i] = sum;
            }
            Array.Sort(valuesOfNames);
            for (int i = 0; i < valuesOfNames.Length; i++)
            {
                Console.WriteLine(valuesOfNames[i]);
            }
        }
    }
}