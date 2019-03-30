using System;
class Program
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int brokenHeadsets = lostGames / 2;
        int brokenMouses = lostGames / 3;
        int brokenKeyboards = brokenHeadsets / 3;
        int brokenDisplays = brokenKeyboards / 2;

        double total = headsetPrice * brokenHeadsets + mousePrice * brokenMouses + keyboardPrice * brokenKeyboards + displayPrice * brokenDisplays;
        Console.WriteLine($"Rage expenses: {total:f2} lv.");
    }
}