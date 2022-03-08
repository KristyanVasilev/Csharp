using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IHero> heroes = new List<IHero>();
            IHero hero = null;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                {
                    hero = new Druid(name, 80);
                }
                else if (heroType == "Paladin")
                {
                    hero = new Paladin(name, 100);
                }
                else if (heroType == "Rogue")
                {
                    hero = new Rogue(name, 80);
                }
                else if (heroType == "Warrior")
                {
                    hero = new Warrior(name, 100);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                    continue;
                }
                Console.WriteLine(hero.CastAbility());
                heroes.Add(hero);
            }

            int bossHealth = int.Parse(Console.ReadLine());

            if (heroes.Sum(x => x.Power) >= bossHealth)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
            
        }
    }
}
