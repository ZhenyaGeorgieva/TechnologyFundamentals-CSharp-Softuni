using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _27NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> demonHealth = new Dictionary<string, int>();
            Dictionary<string, double> demonDamage = new Dictionary<string, double>();

            string patternHealth = @"([^0-9\+\-\*\/\.]{1})";
            string patternDamage = @"([\+|\-]{0,1}[0-9]{1,}[\.]{0,1}[0-9]{0,})";
            string patternActions = @"([\*|\/]{1})";

            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; i++)
            {
                string name = tokens[i];
                int health = 0;
                if (Regex.IsMatch(name, patternHealth))
                {
                    var symbolsHealthCollection = Regex.Matches(name, patternHealth);
                    foreach (Match item in symbolsHealthCollection)
                    {
                        char symbol = char.Parse(item.Value.ToString());
                        int symbolValue = (int)symbol;
                        health += symbolValue;
                    }
                }
                double damage = 0;
                if (Regex.IsMatch(name, patternDamage))
                {
                    var symbolsDamageCollection = Regex.Matches(name, patternDamage);
                    foreach (Match item in symbolsDamageCollection)
                    {
                        double symbol = double.Parse(item.Value.ToString());
                        damage += symbol;
                    }
                }
                if (Regex.IsMatch(name, patternActions))
                {
                    var actionsCollection = Regex.Matches(name, patternActions);
                    foreach (Match x in actionsCollection)
                    {
                        if (x.Value.ToString() == "*")
                        {
                            damage *= 2;
                        }
                        if (x.Value.ToString() == "/")
                        {
                            damage /= 2;
                        }
                    }
                }
                demonDamage[name] = damage;
                demonHealth[name] = health;
            }
            foreach (var kvp in demonHealth.OrderBy(x => x.Key))
            {
                string name = kvp.Key;
                int health = kvp.Value;
                double damage = demonDamage[name];
                Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
            }
        }
    }
}