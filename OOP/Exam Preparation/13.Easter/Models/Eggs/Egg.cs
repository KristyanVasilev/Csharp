using Easter.Models.Eggs.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;
        public Egg(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Egg name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int EnergyRequired
        {
            get { return energyRequired; }
            private set
            {
                if (energyRequired < 0)
                {
                    energyRequired = 0;
                }
                energyRequired = value;
            }
        }

        public void GetColored()
        {
            if (!IsDone())
            {
                this.EnergyRequired -= 10;
                if (EnergyRequired == 0)
                {
                    this.EnergyRequired = 0;
                }
            }
        }

        public bool IsDone()
        {
            if (EnergyRequired == 0)
            {
                return true;
            }

            return false;
        }
    }
}
