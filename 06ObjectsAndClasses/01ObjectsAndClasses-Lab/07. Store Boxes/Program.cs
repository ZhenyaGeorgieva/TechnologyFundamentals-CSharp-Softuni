using System;
using System.Collections.Generic;
using System.Linq;

namespace _06StoreBoxes_my
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceForABox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> listOfBoxes = new List<Box>();
            while (command != "end")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);
                double priceBox = quantity * itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.Quantity = quantity;
                box.PriceForABox = priceBox;
                listOfBoxes.Add(box);
                command = Console.ReadLine();
            }
            List<Box> sortedBoxesByPrice = listOfBoxes.OrderBy(x => x.PriceForABox).Reverse().ToList();
            foreach (var x in sortedBoxesByPrice)
            {
                Console.WriteLine($"{x.SerialNumber}");
                Console.WriteLine($"-- {x.Item.Name} - ${x.Item.Price:f2}: {x.Quantity}");
                Console.WriteLine($"-- ${x.PriceForABox:f2}");
            }
        }
    }
}
