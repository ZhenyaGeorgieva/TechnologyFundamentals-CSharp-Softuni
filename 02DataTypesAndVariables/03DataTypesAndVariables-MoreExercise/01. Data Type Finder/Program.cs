using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                bool booleanType = bool.TryParse(command, out bool boolean);
                bool integerType = int.TryParse(command, out int integer);
                bool floatingPoint = double.TryParse(command, out double floating);
                bool characterType = char.TryParse(command, out char character);
                if (booleanType)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else if (integerType)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (floatingPoint)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (characterType)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
                command = Console.ReadLine();
            }
        }
    }
}