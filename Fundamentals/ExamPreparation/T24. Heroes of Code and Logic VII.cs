using System;
using System.Collections.Generic;
using System.Linq;

namespace T24._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public int hitPoints { get; set; }
        public int manaPoints { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                //"{hero name} {HP} {MP}"
                string[] input = Console.ReadLine().Split(" ");
                string hero = input[0];
                if (!heroes.ContainsKey(hero))
                {
                    Hero currHero = new Hero();
                    currHero.hitPoints = int.Parse(input[1]);
                    currHero.manaPoints = int.Parse(input[2]);
                    heroes.Add(hero, currHero);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currCmd = command.Split(" - ");
                //"CastSpell – {hero name} – {MP needed} – {spell name}"
                if (currCmd[0] == "CastSpell")
                {
                    string heroName = currCmd[1];
                    int mpNeeded = int.Parse(currCmd[2]);
                    string spellName = currCmd[3];
                    if (heroes.ContainsKey(heroName) && heroes[heroName].manaPoints >= mpNeeded)
                    {
                        heroes[heroName].manaPoints -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].manaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                //"TakeDamage – {hero name} – {damage} – {attacker}"
                else if (currCmd[0] == "TakeDamage")
                {
                    string heroName = currCmd[1];
                    int damage = int.Parse(currCmd[2]);
                    string attacker = currCmd[3];
                    heroes[heroName].hitPoints -= damage;
                    if (heroes[heroName].hitPoints > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].hitPoints} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                //"Recharge – {hero name} – {amount}"
                else if (currCmd[0] == "Recharge")
                {
                    string heroName = currCmd[1];
                    int amount = int.Parse(currCmd[2]);
                    int oldMP = heroes[heroName].manaPoints;
                    heroes[heroName].manaPoints += amount;
                    if (heroes[heroName].manaPoints > 200)
                    {
                        heroes[heroName].manaPoints = 200;
                        int newMP = 200 - oldMP;
                        Console.WriteLine($"{heroName} recharged for {newMP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                //"Heal – {hero name} – {amount}"
                else if (currCmd[0] == "Heal")
                {
                    string heroName = currCmd[1];
                    int amount = int.Parse(currCmd[2]);
                    int oldHealth = heroes[heroName].hitPoints;
                    heroes[heroName].hitPoints += amount;
                    if (heroes[heroName].hitPoints > 100)
                    {
                        heroes[heroName].hitPoints = 100;
                        int newHealth = 100 - oldHealth;
                        Console.WriteLine($"{heroName} healed for {newHealth} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
                command = Console.ReadLine();
            }

            heroes = heroes.OrderByDescending(x => x.Value.hitPoints).ThenBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value.hitPoints}");
                Console.WriteLine($"MP: {hero.Value.manaPoints}");
            }
        }
    }
}
