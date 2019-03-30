using System;
class Program
{
    static void Main()
    {
        double amountMoney = double.Parse(Console.ReadLine());
        double studentsCount = double.Parse(Console.ReadLine());
        double lightsabersSinglePrice = double.Parse(Console.ReadLine());
        double robesSinglePrice = double.Parse(Console.ReadLine());
        double beltsSinglePrice = double.Parse(Console.ReadLine());

        double totalPriceLightsabers = (Math.Ceiling(1.1 * studentsCount)) * lightsabersSinglePrice;

        double beltsAmountNeeded = studentsCount;
        int freeBeltsCount = 0;
        while (beltsAmountNeeded >= 6)
        {
            freeBeltsCount += 1;
            beltsAmountNeeded -= 6;
        }
        double totalPriceBelts = (studentsCount * beltsSinglePrice) - (freeBeltsCount * beltsSinglePrice);

        double totalPriceRobes = studentsCount * robesSinglePrice;

        double totalPriceEquipment = totalPriceLightsabers + totalPriceBelts + totalPriceRobes;
        if (totalPriceEquipment <= amountMoney)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPriceEquipment:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {(totalPriceEquipment - amountMoney):f2}lv more.");
        }
    }
}