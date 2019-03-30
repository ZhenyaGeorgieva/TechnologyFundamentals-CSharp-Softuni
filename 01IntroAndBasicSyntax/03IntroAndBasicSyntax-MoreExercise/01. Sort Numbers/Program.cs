using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_01_SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = 0;
            int bigger = 0;
            int smallest = 0;
            if (a >= b && a >= c)
            {
                max = a;
                if (b >= c)
                {
                    bigger = b;
                    smallest = c;

                }
                else if (c >= b)
                {
                    bigger = c;
                    smallest = b;
                }
            }
            else if (b >= a && b >= c)
            {
                max = b;
                if (a >= c)
                {
                    bigger = a;
                    smallest = c;

                }
                else
                {
                    bigger = c;
                    smallest = a;
                }
            }
            else if (c > b && c > a)
            {
                max = c;
                if (a >= b)
                {
                    bigger = a;
                    smallest = b;
                }
                else
                {
                    smallest = b;
                    bigger = a;

                }
            }
            Console.WriteLine(max);
            Console.WriteLine(bigger);
            Console.WriteLine(smallest);
        }
    }
}