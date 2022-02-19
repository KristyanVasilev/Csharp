using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public Clinic(int capacity)
        {
            Capacity = capacity;
            Data = new List<Pet>();
        }

        private readonly List<Pet> data;
        public List<Pet>  Data { get; set; }
        public int Capacity { get; set; }
        public int Count => Data.Count;

        public void Add(Pet pet)
        {
            if (Data.Count <= Capacity && !Data.Contains(pet))
            {
                Data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            if (Data.Any(x => x.Name == name))
            {
                var petToRemove = Data.FirstOrDefault(x => x.Name == name);
                Data.Remove(petToRemove);
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            return Data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return Data.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in Data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
