using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }

        public List<Fish> Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count => Fish.Count;
        public string AddFish(Fish fish)
        {
            if (string.IsNullOrEmpty(fish.FishType)|| fish.Length < 0 || fish.Weight <0)
            {
                return "Invalid fish.";
            }
            else if (Count >= Capacity)
            {
                return "Fishing net is full.";
            }
            else
            {
                Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }
        public bool ReleaseFish(double weight)
        {
            var currFish = Fish.FirstOrDefault(x => x.Weight == weight);
            if (currFish != null)
            {
                Fish.Remove(currFish);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Fish GetFish(string fishType)
        {
            return Fish.FirstOrDefault(x => x.FishType == fishType);
        }
        public Fish GetBiggestFish()
        {
            return Fish.OrderByDescending(x => x.Length).FirstOrDefault();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            var sortedFishes = Fish.OrderByDescending(x => x.Length);

            sb.AppendLine($"Into the {Material}:");
            foreach (var fish in sortedFishes)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
