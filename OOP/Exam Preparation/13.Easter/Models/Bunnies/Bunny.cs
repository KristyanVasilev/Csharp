using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Models.Bunnies
{
    public abstract class Bunny : IBunny
    {
        private ICollection<IDye> dyes;
        private string name;
        private int energy;

        public Bunny(string name, int energy)
        {
            this.dyes = new List<IDye>();
            this.name = name;
            this.energy = energy;
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Bunny name cannot be null or empty.");
                }
                name = value; 
            }
        }

        public int Energy
        {
            get { return energy; }
            protected set
            {
                if (energy < 0)
                {
                    energy = 0;
                }
                energy = value;
            }
        }

        public ICollection<IDye> Dyes => dyes;

        public void AddDye(IDye dye)
        {
            dyes.Add(dye);
        }

        public virtual void Work()
        {
            this.Energy -= 10;
        }
    }
}
