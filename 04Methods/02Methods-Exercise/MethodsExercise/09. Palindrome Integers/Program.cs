using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {

                bool result = CheckPolindromeNumber(command);
                Console.WriteLine(result.ToString().ToLower());
                command = Console.ReadLine();
            }
        }
        public static bool CheckPolindromeNumber(string number)
        {
            bool isItPolindrome = true;
            int[] arrayOfNumber = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                arrayOfNumber[i] = number[i];
            }
            for (int i = 0; i < arrayOfNumber.Length / 2; i++)
            {
                if (arrayOfNumber[i] != arrayOfNumber[arrayOfNumber.Length - 1 - i])
                {
                    isItPolindrome = false;
                }
            }
            return isItPolindrome;
        }
    }
}