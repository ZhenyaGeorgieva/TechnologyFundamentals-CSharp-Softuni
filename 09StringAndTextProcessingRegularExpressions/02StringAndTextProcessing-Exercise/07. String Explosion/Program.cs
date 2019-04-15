using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> result = text.ToList();
            int strength = 0;

            for (int j = 0; j < result.Count; j++)
            {
                if (result[j] == '>')
                {
                    strength += int.Parse(result[j + 1].ToString());
                    result.RemoveAt(j + 1);
                    strength--;
                    continue;
                }
                if (strength > 0)
                {
                    strength--;
                    result.RemoveAt(j);
                    j--;
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
