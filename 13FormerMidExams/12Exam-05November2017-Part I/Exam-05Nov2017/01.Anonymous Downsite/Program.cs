using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01AnonimousDownside
{
    class Program
    {
        static void Main(string[] args)
        {
            int websitesCount = int.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            List<string> websiteList = new List<string>();
            for (int i = 0; i < websitesCount; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string websiteName = tokens[0];
                long visits = long.Parse(tokens[1]);
                decimal price = decimal.Parse(tokens[2]);

                decimal siteLoss = visits * price;
                totalLoss += siteLoss;
                websiteList.Add(websiteName);
            }
            foreach (var x in websiteList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($"Total Loss: { totalLoss:f20}");
            BigInteger securityPrint = BigInteger.Pow(securityKey, websitesCount);
            Console.WriteLine($"Security Token: {securityPrint}");
        }
    }
}