using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Mission;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private PlanetRepository planets;
        private int exploredPlanets;
        public Controller()
        {
            astronauts = new AstronautRepository();
            planets = new PlanetRepository();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;
            if (type == nameof(Biologist))
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == nameof(Geodesist))
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == nameof(Meteorologist))
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            astronauts.Add(astronaut);
            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }
            planets.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            IMission misson = new Mission();
            IPlanet planet = planets.FindByName(planetName);
            List<IAstronaut> astronautsWithOxygenAboveSixty = astronauts.Models.Where(x => x.Oxygen > 60).ToList();

            this.exploredPlanets++;

            if (!astronautsWithOxygenAboveSixty.Any())
            {
                return $"You need at least one astronaut to explore the planet";
            }

            misson.Explore(planet, astronautsWithOxygenAboveSixty);

            //int deadAstronauts = 0;
            //foreach (var astronaut in astronautsWithOxygenAboveSixty)
            //{
            //    if (!astronaut.CanBreath)
            //    {
            //        deadAstronauts++;
            //    }
            //}

            int deadAstronauts = astronautsWithOxygenAboveSixty.Count(x => !x.CanBreath);

            return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts} dead astronauts!";
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{exploredPlanets} planets were explored!");
            stringBuilder.AppendLine("Astronauts info:");

            foreach (var astronaut in this.astronauts.Models)
            {
                stringBuilder.AppendLine($"Name: {astronaut.Name}");
                stringBuilder.AppendLine($"Oxygen: {astronaut.Oxygen}");

                string itemsInfo = astronaut.Bag.Items.Any() ?
                    string.Join(", ", astronaut.Bag.Items) : // Select(x => x.Name)
                    "none";

                stringBuilder.AppendLine($"Bag items: {itemsInfo}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = astronauts.FindByName(astronautName);
            if (astronaut == null)
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }

            astronauts.Remove(astronaut);
            return $"Astronaut {astronautName} was retired!";
        }
    }
}
