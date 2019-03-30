using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_04_GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            string command = Console.ReadLine();

            double gamePrice = 0;
            while (command != "Game Time")
            {
                string game = command;
                if (game == "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (game == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (game == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (balance >= gamePrice && gamePrice != 0)
                {
                    balance -= gamePrice;
                    totalSpent += gamePrice;
                    Console.WriteLine($"Bought {game}");

                }
                else if (gamePrice > balance)
                {
                    Console.WriteLine("Too Expensive");
                }
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                gamePrice = 0;
                command = Console.ReadLine();
            }
            if (balance > 0)
            {
                Console.Write($"Total spent: ${totalSpent:f2}. ");
                Console.WriteLine($"Remaining: ${balance:f2}");
            }
        }
    }
}
