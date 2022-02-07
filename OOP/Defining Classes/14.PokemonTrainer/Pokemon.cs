using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            this.health = health;
        }

        public string Name { get; set; }
        public string Element { get; set; }
        public int health { get; set; }

    }
}
