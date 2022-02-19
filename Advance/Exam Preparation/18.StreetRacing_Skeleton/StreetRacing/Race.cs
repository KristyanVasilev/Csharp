using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }

        public List<Car> Participants { get; set; } = new List<Car>();
        public int Count => Participants.Count;

        public string Name { get; set; }

        public string Type { get; set; }
        public int Laps { get; set; }

        public int Capacity { get; set; }
        //the maximum allowed number of participants in the race

        public int MaxHorsePower { get; set; }
        //the maximum allowed Horse Power of a Car in the Race

        public void Add(Car car)
        {
            if (!Participants.Any(x => x.LicensePlate == car.LicensePlate)
                && Participants.Count + 1 <= Capacity
                && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            var carToRemove = Participants.FirstOrDefault(x => x.LicensePlate == licensePlate);
            if (carToRemove == null)
            {
                return false;
            }
            else
            {
                Participants.Remove(carToRemove);
                return true;
            }
        }

        public Car FindParticipant(string licensePlate)
        {
            return Participants.FirstOrDefault(x => x.LicensePlate == licensePlate);    
        }

        public Car GetMostPowerfulCar()
        {
            return Participants.OrderByDescending(x => x.HorsePower).FirstOrDefault();
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in Participants)
            {
                sb.AppendLine(car.ToString().TrimEnd());
            }

            return sb.ToString();
        }
    }
}
