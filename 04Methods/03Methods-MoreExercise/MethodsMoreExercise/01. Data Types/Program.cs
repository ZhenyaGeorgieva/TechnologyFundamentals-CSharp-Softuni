using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExerciseMore
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int entryInt = int.Parse(Console.ReadLine());
                int resultInt = ModifyInput(entryInt);
                Console.WriteLine(resultInt);
            }
            if (dataType == "real")
            {
                double entryDouble = double.Parse(Console.ReadLine());
                double resultDouble = ModifyInput(entryDouble);
                Console.WriteLine($"{resultDouble:f2}");
            }
            if (dataType == "string")
            {
                string entryString = Console.ReadLine();
                string resultText = ModifyInput(entryString);
                Console.WriteLine($"${resultText}$");
            }
        }

        static int ModifyInput(int entry)
        {
            int result = entry * 2;
            return result;
        }
        static double ModifyInput(double entry)
        {
            double result = 1.5 * entry;
            return result;
        }
        static string ModifyInput(string entry)
        {
            return entry;
        }
    }
}

