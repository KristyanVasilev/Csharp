using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new Dictionary<string, Trainers>();

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);
                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                var trainer = new Trainers(trainerName);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, trainer);
                }
                trainers[trainerName].CollectionsOfPokemons.Add(pokemon);

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {

                foreach (var trainer in trainers)
                {
                    if (trainer.Value.CollectionsOfPokemons.Any(x => x.Element == command))
                    {
                        trainer.Value.NumberOfBadges++;
                        trainer.Value.AppearancesInBattles++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.CollectionsOfPokemons)
                        {
                            pokemon.health -= 10;
                        }
                        trainer.Value.CollectionsOfPokemons.RemoveAll(x => x.health <= 0);
                    }
                }
                command = Console.ReadLine();
            }

            var sortedTrainers = trainers.OrderByDescending(x => x.Value.NumberOfBadges).ThenBy(x => x.Value.AppearancesInBattles);
            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine(trainer.Value);
            }
        }
    }
}


