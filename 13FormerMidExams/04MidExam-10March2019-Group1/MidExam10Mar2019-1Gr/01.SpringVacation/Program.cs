using System;

namespace midExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal budgetTotal = decimal.Parse(Console.ReadLine());
            decimal peopleCount = decimal.Parse(Console.ReadLine());
            decimal fuelPerKm = decimal.Parse(Console.ReadLine());
            decimal foodPricePerPerson = decimal.Parse(Console.ReadLine());
            decimal roomPricePerPerson = decimal.Parse(Console.ReadLine());

            decimal totalExpensesFood = peopleCount * foodPricePerPerson * days;
            decimal totalExpensesHotel = peopleCount * roomPricePerPerson * days;
            if (peopleCount > 10)
            {
                totalExpensesHotel = totalExpensesHotel * 0.75m;
            }
            decimal currentExpensesFoodHotel = totalExpensesFood + totalExpensesHotel;

            decimal total = currentExpensesFoodHotel;
            bool notEnough = false;
            for (int i = 1; i <= days; i++)
            {
                if (total > budgetTotal)
                {
                    notEnough = true;
                    break;
                }
                decimal distanceKmForTheDay = decimal.Parse(Console.ReadLine());
                decimal consumedFuel = distanceKmForTheDay * fuelPerKm;
                total += consumedFuel;
                decimal sumToAdd = 0;
                decimal sumToDeduct = 0;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumToAdd = total * 0.4m;
                }
                if (i % 7 == 0)
                {
                    sumToDeduct = total / peopleCount;
                }
                total -= sumToDeduct;
                total += sumToAdd;
                if (total > budgetTotal)
                {
                    notEnough = true;
                    break;
                }
            }
            if (!notEnough)
            {
                Console.WriteLine($"You have reached the destination. You have {(budgetTotal - total):f2}$ budget left.");
            }
            else
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {(total - budgetTotal):f2}$ more.");
            }
        }
    }
}
