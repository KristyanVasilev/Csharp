using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository carRepository;

        public Controller()
        {
            this.pilotRepository = new PilotRepository();
            this.raceRepository = new RaceRepository();
            this.carRepository = new FormulaOneCarRepository();
        }
        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot pilot = pilotRepository.FindByName(pilotName);
            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException($"Pilot {pilotName} does not exist or has a car.");
            }

            IFormulaOneCar car = carRepository.FindByName(carModel);
            if (car == null)
            {
                throw new NullReferenceException($"Car {carModel} does not exist.");
            }

            pilot.AddCar(car);
            return $"Pilot {pilotName} will drive a {car.GetType().Name} {carModel} car.";
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IRace race = raceRepository.FindByName(raceName);
            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }

            IPilot pilot = pilotRepository.FindByName(pilotFullName);
            if (pilot == null || pilot.CanRace == false)
            {
                throw new InvalidOperationException($"Can not add pilot {pilotFullName} to the race.");
            }
            if (race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException($"Can not add pilot {pilotFullName} to the race.");
            }

            race.AddPilot(pilot);
            return $"Pilot {pilotFullName} is added to the {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            IFormulaOneCar car;
            if (type == nameof(Ferrari))
            {
                car = new Ferrari(model, horsepower, engineDisplacement);
            }
            else if (type == nameof(Williams))
            {
                car = new Williams(model, horsepower, engineDisplacement);
            }
            else
            {
                throw new InvalidOperationException($"Formula one car type {type} is not valid.");
            }

            var IsContains = carRepository.FindByName(model);
            if (IsContains != null)
            {
                throw new InvalidOperationException($"Formula one car {model} is already created.");
            }

            this.carRepository.Add(car);
            return $"Car {type}, model {model} is created.";
        }

        public string CreatePilot(string fullName)
        {
            IPilot pilot = new Pilot(fullName);

            var IsContains = pilotRepository.FindByName(fullName);
            if (IsContains != null)
            {
                throw new InvalidOperationException($"Pilot {fullName} is already created.");
            }

            this.pilotRepository.Add(pilot);
            return $"Pilot {fullName} is created.";
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            IRace race = new Race(raceName, numberOfLaps);

            var IsContains = raceRepository.FindByName(raceName);
            if (IsContains != null)
            {
                throw new InvalidOperationException($"Race {raceName} is already created.");
            }

            this.raceRepository.Add(race);
            return $"Race {raceName} is created.";
        }

        public string PilotReport()
        {
            var sb = new StringBuilder();

            var sortedPilots = pilotRepository.Models.OrderByDescending(x => x.NumberOfWins);
            foreach (var pilot in sortedPilots)
            {
                sb.AppendLine(pilot.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            var sb = new StringBuilder();

            foreach (var race in raceRepository.Models)
            {
                if (race.TookPlace == true)
                {
                    sb.AppendLine(race.RaceInfo());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException($"Race {raceName} does not exist.");
            }
            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than three participants.");
            }
            if (race.TookPlace == true)
            {
                throw new InvalidOperationException($"Can not execute race {raceName}.");
            }

            race.TookPlace = true;
            var sortedpilots = race.Pilots.OrderByDescending(x => x.Car.RaceScoreCalculator(race.NumberOfLaps)).ToList();

            var winner = sortedpilots.First();
            winner.WinRace();

            var sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    sb.AppendLine($"Pilot {sortedpilots[i].FullName} wins the {raceName} race.");
                }
                if (i == 1)
                {
                    sb.AppendLine($"Pilot {sortedpilots[i].FullName} is second in the {raceName} race.");
                }
                if (i == 2)
                {
                    sb.AppendLine($"Pilot {sortedpilots[i].FullName} is third in the {raceName} race.");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
