using System;
using System.Linq;

namespace Т04._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int[] warShip = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int shipsMaxHealth = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "Retire")
            {
                if (commands[0] == "Fire")
                {
                    int index = int.Parse(commands[1]);
                    int damage = int.Parse(commands[2]);
                    if (index >= 0 && index < warShip.Length)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (commands[0] == "Defend")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    int damage = int.Parse(commands[3]);
                    if (startIndex >= 0 && startIndex < pirateShip.Length && endIndex >= 0 && endIndex < pirateShip.Length)
                    {
                        for (int sections = startIndex; sections <= endIndex; sections++)
                        {
                            pirateShip[sections] -= damage;
                            if (pirateShip[sections] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (commands[0] == "Repair")
                {
                    int index = int.Parse(commands[1]);
                    int health = int.Parse(commands[2]);
                    if (index >= 0 && index < pirateShip.Length)
                    {
                        if (pirateShip[index] + health >= shipsMaxHealth)
                        {
                            pirateShip[index] = shipsMaxHealth;
                        }
                        else
                        {
                            pirateShip[index] += health;
                        }
                    }
                }
                else if (commands[0] == "Status")
                {
                    int countOfSections = pirateShip.Count(sections => sections / (double)shipsMaxHealth * 100 < 20);
                    Console.WriteLine($"{countOfSections} sections need repair.");
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
