using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private int capacity;
        private List<IEquipment> equipments;
        private List<IAthlete> athletes;

        public Gym(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            equipments = new List<IEquipment>();
            athletes = new List<IAthlete>();
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            private set
            {
                capacity = value;
            }
        }

        public double EquipmentWeight
            => equipments.Sum(x => x.Weight);

        public ICollection<IEquipment> Equipment => equipments;

        public ICollection<IAthlete> Athletes => athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if (athletes.Count >= Capacity)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }

            athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            equipments.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Name} is a {this.GetType().Name}:");

            string result;
            if (athletes.Count <= 0)
            {
               result="No athletes";
            }
            else
            {
                result = String.Join(", ", Athletes.Select(x => x.FullName));
            }
            sb.AppendLine($"Athletes: {result}");
            sb.AppendLine($"Equipment total count: {equipments.Count()}");
            sb.AppendLine($"Equipment total weight: {this.EquipmentWeight:f2} grams");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return athletes.Remove(athlete);
        }
    }
}
