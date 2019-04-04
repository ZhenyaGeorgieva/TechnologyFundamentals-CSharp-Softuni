using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            string result = PrintMultipleText(text, counter);
            Console.WriteLine(result);
        }
        public static string PrintMultipleText(string text, int count)
        {
            string resultToPrint = string.Empty;
            for (int i = 0; i < count; i++)
            {
                resultToPrint += text;
            }
            return resultToPrint;
        }
    }
}