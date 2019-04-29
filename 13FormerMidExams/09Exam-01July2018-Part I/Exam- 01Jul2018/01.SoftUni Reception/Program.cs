using System;

namespace _01SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiencyFirstEmp = int.Parse(Console.ReadLine());
            int efficiencySecondEmp = int.Parse(Console.ReadLine());
            int efficiencyThirdEmp = int.Parse(Console.ReadLine());
            int totalEfficiency = efficiencyFirstEmp + efficiencySecondEmp + efficiencyThirdEmp;

            int studentsCount = int.Parse(Console.ReadLine());
            int hours = 0;

            while (studentsCount > 0)
            {
                hours++;
                if (hours % 4 != 0)
                {
                    studentsCount -= totalEfficiency;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}