using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06BalancedBrackets_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int opening = 0;
            int closing = 0;
            int balanced = 0;
            int totalClosing = 0;
            int totalOpening = 0;
            string temp = string.Empty;
            for (int i = 0; i < numberOfRows; i++)
            {
                string input = Console.ReadLine();
                if (input == ")" && temp != ")")
                {
                    opening += 1;
                }
                if (input == "(" && temp != "(")
                {
                    closing += 1;
                }
                if (opening == 1 && closing == 1)
                {
                    balanced += 1;
                    opening = 0;
                    closing = 0;
                }
                if (input == ")" || input == "(")
                {
                    temp = input;
                    if (input == ")")
                    {
                        totalClosing++;
                    }
                    if (input == "(")
                    {
                        totalOpening++;
                    }
                }
            }
            if (balanced > 0 && opening == 0 && closing == 0 && totalOpening == totalClosing)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
