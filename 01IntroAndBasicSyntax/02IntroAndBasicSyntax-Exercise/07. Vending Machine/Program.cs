using System;
class Program
{
    static void Main()
    {
        string command1 = Console.ReadLine();
        decimal sumCoins = 0;

        while (command1 != "Start")
        {
            decimal coins = decimal.Parse(command1);
            if (coins != 0.1m && coins != 0.2m && coins != 0.5m && coins != 1m && coins != 2m)
            {
                Console.WriteLine($"Cannot accept {coins}");
            }
            else
            {
                sumCoins += coins;
            }
            command1 = Console.ReadLine();
        }
        string command2 = Console.ReadLine();
        while (command2 != "End")
        {
            string product = command2;
            decimal singleProductPrice = 0;
            if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
            {
                Console.WriteLine("Invalid product");

            }
            else if (product == "Nuts")
            {
                singleProductPrice = 2m;
            }
            else if (product == "Water")
            {
                singleProductPrice = 0.7m;
            }
            else if (product == "Crisps")
            {
                singleProductPrice = 1.5m;
            }
            else if (product == "Soda")
            {
                singleProductPrice = 0.8m;
            }
            else if (product == "Coke")
            {
                singleProductPrice = 1m;
            }

            if (singleProductPrice > sumCoins && (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke"))
            {
                Console.WriteLine("Sorry, not enough money");
            }
            else if (singleProductPrice <= sumCoins && (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke"))
            {
                sumCoins -= singleProductPrice;
                Console.WriteLine($"Purchased {product.ToLowerInvariant()}");
            }

            command2 = Console.ReadLine();

        }


        Console.WriteLine($"Change: {sumCoins:f2}");
    }
}