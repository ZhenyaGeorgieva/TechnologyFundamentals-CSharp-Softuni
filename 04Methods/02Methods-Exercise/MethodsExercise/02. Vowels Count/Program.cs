using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int result = CountingVowels(text);
            Console.WriteLine(result);
        }

        public static int CountingVowels(string text)
        {
            int counterOfVowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a'
                    || text[i] == 'o'
                    || text[i] == 'i'
                    || text[i] == 'e'
                    || text[i] == 'u'
                    || text[i] == 'A'
                    || text[i] == 'O'
                    || text[i] == 'I'
                    || text[i] == 'E'
                    || text[i] == 'U')
                {
                    counterOfVowels += 1;
                }
            }
            return counterOfVowels;
        }
    }
}