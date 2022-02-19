using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield : IEnumerable<Drone>
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }

        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public int Count => Drones.Count;

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range <= 5 || drone.Range >= 15)
            {
                return "Invalid drone.";
            }
            else if (Count >= Capacity)
            {
                return "Airfield is full.";
            }
            else
            {
                Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";
            }
        }
        public bool RemoveDrone(string name)
        {
            if (Drones.Any(x => x.Name == name))
            {
                var droneToRemove = Drones.FirstOrDefault(x => x.Name == name);
                Drones.Remove(droneToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = 0;
            foreach (var drone in Drones)
            {
                if (drone.Brand == brand)
                {
                    count++;
                }
            }
            Drones = Drones.Where(x => x.Brand != brand).ToList();
            return count;
        }
        public Drone FlyDrone(string name)
        {
            var drone = Drones.Where(x=> x.Available = true).FirstOrDefault(x => x.Name == name);
            drone.Available = false;
            return drone;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> filteredDrones = Drones.Where(x => x.Range >= range).ToList();
            return filteredDrones;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            var availablesDrones = Drones.Where(x => x.Available == true);
            foreach (Drone drone in availablesDrones)
            {
                sb.AppendLine(drone.ToString());
            }

            return sb.ToString().Trim();

        }

        public IEnumerator<Drone> GetEnumerator()
        {
            return this.Drones.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


