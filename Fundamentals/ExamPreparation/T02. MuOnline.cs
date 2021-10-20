using System;
using System.Linq;

namespace T02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split('|').ToArray();
            int health = 100;
            double bitcoins = 0;

            for (int room = 0; room < commands.Length; room++)
            {
                string[] currCommand = commands[room].Split().ToArray();

                if (currCommand[0] == "potion")
                {
                    int potionHealth = int.Parse(currCommand[1]);
                    int currHealth = health;
                    health += potionHealth;
                    if (health > 100) health = 100;
                    int gainedHealth = potionHealth;
                    if (health == 100) gainedHealth = health - currHealth;
                    Console.WriteLine($"You healed for {gainedHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (currCommand[0] == "chest")
                {
                    double foundedBTC = int.Parse(currCommand[1]);
                    bitcoins += foundedBTC;
                    Console.WriteLine($"You found {foundedBTC} bitcoins.");
                }
                else
                {
                    string monsterName = currCommand[0];
                    int monsterPower = int.Parse(currCommand[1]);
                    health -= monsterPower;
                    if (health > 0) Console.WriteLine($"You slayed {monsterName}.");
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {room + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
