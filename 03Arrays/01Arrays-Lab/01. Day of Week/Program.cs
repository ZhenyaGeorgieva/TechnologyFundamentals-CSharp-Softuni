using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(weekDays[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
