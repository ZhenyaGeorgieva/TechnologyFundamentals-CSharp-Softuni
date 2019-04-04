using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                int resultInt = GetMax(firstInt, secondInt);
                Console.WriteLine(resultInt);
            }
            else if (type == "char")
            {
                char letter1 = char.Parse(Console.ReadLine());
                char letter2 = char.Parse(Console.ReadLine());
                char resultChar = GetMax(letter1, letter2);
                Console.WriteLine(resultChar);
            }
            else if (type == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                string resultText = GetMax(text1, text2);
                Console.WriteLine(resultText);
            }

        }
        public static int GetMax(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }
        public static char GetMax(char letter1, char letter2)
        {

            return (char)Math.Max(letter1, letter2);
        }
        public static string GetMax(string text1, string text2)
        {
            int comparison = text1.CompareTo(text2);
            if (comparison > 0)
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }
    }
}