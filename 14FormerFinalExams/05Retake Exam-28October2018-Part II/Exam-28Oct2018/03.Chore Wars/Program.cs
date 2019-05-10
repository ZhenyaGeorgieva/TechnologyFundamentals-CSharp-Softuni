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
            string patternDishes = @"<(?<dishes>[a-z0-9]{1,})>";
            string patternHouse = @"\[(?<house>[A-Z0-9]{1,})\]";
            string patternLaundry = @"\{(?<laundry>[\S]{1,})\}";
            int dishesTime = 0;
            int laundryTime = 0;
            int houseTime = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "wife is happy")
                {
                    break;
                }
                else
                {
                    if (Regex.IsMatch(command, patternDishes))
                    {
                        var dishesCollection = Regex.Matches(command, patternDishes);
                        foreach (Match x in dishesCollection)
                        {
                            string dishesScrypt = x.Groups["dishes"].Value.ToString();
                            for (int i = 0; i < dishesScrypt.Length; i++)
                            {
                                char symbol = dishesScrypt[i];
                                if (char.IsDigit(symbol))
                                {
                                    int number = int.Parse(dishesScrypt[i].ToString());
                                    dishesTime += number;
                                }
                            }
                        }
                    }
                    if (Regex.IsMatch(command, patternHouse))
                    {
                        var houseCollection = Regex.Matches(command, patternHouse);
                        foreach (Match x in houseCollection)
                        {
                            string houseScrypt = x.Groups["house"].Value.ToString();
                            for (int i = 0; i < houseScrypt.Length; i++)
                            {
                                char symbol = houseScrypt[i];
                                if (char.IsDigit(symbol))
                                {
                                    int number = int.Parse(houseScrypt[i].ToString());
                                    houseTime += number;
                                }
                            }
                        }
                    }
                    if (Regex.IsMatch(command, patternLaundry))
                    {
                        var laundryCollection = Regex.Matches(command, patternLaundry);
                        foreach (Match x in laundryCollection)
                        {
                            string laundryScrypt = x.Groups["laundry"].Value.ToString();
                            for (int i = 0; i < laundryScrypt.Length; i++)
                            {
                                char symbol = laundryScrypt[i];
                                if (char.IsDigit(symbol))
                                {
                                    int number = int.Parse(laundryScrypt[i].ToString());
                                    laundryTime += number;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {houseTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine($"Total - {dishesTime + laundryTime + houseTime} min.");
        }
    }
}
