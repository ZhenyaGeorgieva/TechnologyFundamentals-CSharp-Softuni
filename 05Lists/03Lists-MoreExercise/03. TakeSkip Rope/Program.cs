using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string hiddenMessage = Console.ReadLine();
            List<char> listOfLetters = new List<char>();
            List<char> listOfDigits = new List<char>();
            for (int i = 0; i < hiddenMessage.Length; i++)
            {
                if (char.IsDigit(hiddenMessage[i]))
                {
                    char digitToAdd = (char)hiddenMessage[i];
                    listOfDigits.Add(digitToAdd);
                }
                else
                {
                    listOfLetters.Add(hiddenMessage[i]);
                }
            }

            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            for (int i = 0; i < listOfDigits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    int digitToAdd = int.Parse(listOfDigits[i].ToString());
                    take.Add(digitToAdd);
                }
                else
                {
                    int digitToAdd = int.Parse(listOfDigits[i].ToString());
                    skip.Add(digitToAdd);
                }
            }
            List<char> result = new List<char>();
            for (int i = 0; i < take.Count; i++)
            {
                int takeCount = take[i];
                int skipCount = skip[i];
                for (int g = 0; g < takeCount; g++) ///take
                {
                    if (g < listOfLetters.Count)
                    {
                        result.Add(listOfLetters[g]);
                    }
                }
                if (takeCount + skipCount < listOfLetters.Count)
                {
                    listOfLetters.RemoveRange(0, takeCount + skipCount);
                }
                else
                {
                    listOfLetters.RemoveRange(0, listOfLetters.Count);

                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}

