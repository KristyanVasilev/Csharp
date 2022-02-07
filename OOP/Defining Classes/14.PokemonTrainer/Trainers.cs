using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainers
    {

        public Trainers(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; } = 0;
        public List<Pokemon> CollectionsOfPokemons { get; set; } = new List<Pokemon>();
        public int AppearancesInBattles{ get; set; } = 0;

        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {CollectionsOfPokemons.Count}";
        }
    }
}
