using System;

namespace _01GoogleSearches
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int users = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());

            double totalMoney = 0;
            for (int i = 1; i <= users; i++)
            {
                double wordsCount = double.Parse(Console.ReadLine());
                double moneyPerThisUser = moneyPerSearch;
                if (wordsCount > 5)
                {
                    continue;
                }
                if (wordsCount == 1)
                {
                    moneyPerThisUser = moneyPerSearch * 2;
                }
                if (i % 3 == 0)
                {
                    moneyPerThisUser *= 3;
                }
                totalMoney += moneyPerThisUser;
            }
            totalMoney *= days;
            Console.WriteLine($"Total money earned for {days} days: {totalMoney:f2}");
        }
    }
}