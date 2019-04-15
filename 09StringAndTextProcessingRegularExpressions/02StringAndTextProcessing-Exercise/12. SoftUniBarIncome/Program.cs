using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double total = 0;
            while (command != "end of shift")
            {
                string text = command;
                string regex = @"%(?<customer>[A-Z]{1}[a-z]{1,})%[^|$%.]*<(?<product>[\w]{1,})>[^|$%.]*\|(?<count>[\d]{1,})\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]+)\$";
                bool isValid = Regex.IsMatch(text, regex);
                if (isValid)
                {
                    var validLine = Regex.Matches(text, regex);
                    foreach (Match x in validLine)
                    {
                        string customer = x.Groups["customer"].Value;
                        string product = x.Groups["product"].Value;
                        double count = double.Parse(x.Groups["count"].Value);
                        double price = double.Parse(x.Groups["price"].Value);
                        double totalPrice = count * price;
                        total += totalPrice;
                        Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }

    }
}
