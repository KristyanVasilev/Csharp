using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _09._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\+\-\*\/\.\,0-9 ]";
            string damagePattern = @"-?\d+\.?\d*";
            string multyplyDividePattern = @"[\*\/]";
            string splittingPattern = @"[,\s]+";
            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splittingPattern).OrderBy(x => x).ToArray();
            for (int i = 0; i < demons.Length; i++)
            {
                string currDemon = demons[i];
                long health = 0;
                MatchCollection healthMatched = Regex.Matches(currDemon, healthPattern);
                foreach (Match match in healthMatched)
                {
                    char curChar = char.Parse(match.ToString());
                    health += curChar;
                }

                double damage = 0;
                MatchCollection damageMatched = Regex.Matches(currDemon, damagePattern);
                foreach (Match match in damageMatched)
                {
                    double currDamage = double.Parse(match.ToString());
                    damage += currDamage;
                }

                MatchCollection multyplyAndDivide = Regex.Matches(currDemon, multyplyDividePattern);
                foreach (Match match in multyplyAndDivide)
                {
                    char cureOperator = char.Parse(match.ToString());
                    if (cureOperator == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                Console.WriteLine($"{currDemon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
