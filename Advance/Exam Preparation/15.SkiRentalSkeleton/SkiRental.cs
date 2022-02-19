using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
            Data = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        public List<Ski> Data { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => Data.Count;
        public void Add(Ski ski)
        {
            if (Data.Count < Capacity)
            {
                Data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            var currSki = Data.FirstOrDefault(x => x.Manufacturer == manufacturer);
            if (currSki.Model == model)
            {
                //currSki != null && 
                return true;
            }
            return false;
        }

        public Ski GetNewestSki()
        {
            return Data.OrderByDescending(x => x.Year).FirstOrDefault();
        }

        public Ski GetSki(string manufacturer, string model)
        {
            var currSki = Data.FirstOrDefault(x => x.Manufacturer == manufacturer);
            if (currSki.Model == model)
            {
                //currSki != null && 
                return currSki;
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var ski in Data)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
