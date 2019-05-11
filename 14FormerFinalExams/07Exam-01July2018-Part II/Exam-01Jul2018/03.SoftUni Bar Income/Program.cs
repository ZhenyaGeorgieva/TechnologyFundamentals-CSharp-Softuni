using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^\|\$\%\.]{0,})%(?<customer>[A-Z]{1}[a-z]{1,})%([^\|\$\%\.]{0,})<(?<product>[\w]{1,})>([^\|\$\%\.]{0,})\|(?<count>[0-9]{1,})\|([^0-9\|\$\%\.]{0,})(?<price>[0-9]{1,}[.]{0,}[0-9]{0,})\$([^\|\$\%\.]{0,})$";
            double totalIncome = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of shift")
                {
                    break;
                }
                else
                {
                    if (Regex.IsMatch(command, pattern))
                    {
                        var matchCollection = Regex.Matches(command, pattern);
                        foreach (Match item in matchCollection)
                        {
                            string customer = item.Groups["customer"].Value.ToString();
                            string product = item.Groups["product"].Value.ToString();
                            int count = int.Parse(item.Groups["count"].Value.ToString());
                            double price = double.Parse(item.Groups["price"].Value.ToString());
                            double total = count * price;
                            Console.WriteLine($"{customer}: {product} - {total:f2}");
                            totalIncome += total;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
