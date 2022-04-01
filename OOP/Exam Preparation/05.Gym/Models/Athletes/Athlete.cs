using Gym.Models.Athletes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public abstract class Athlete : IAthlete
    {
        private string fullName;
        private string motivation;
        private int numberOfMedals;
        private int stamina;
        public Athlete(string fullName, string motivation, int numberOfMedals, int stamina)
        {
            this.FullName = fullName;
            this.Motivation = motivation;
            this.NumberOfMedals = numberOfMedals;
            this.Stamina = stamina;
        }

        public string FullName
        {
            get { return fullName; }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Athlete name cannot be null or empty.");
                }
                fullName = value; 
            }
        }

        public string Motivation
        {
            get { return motivation; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The motivation cannot be null or empty.");
                }
                motivation = value;
            }
        }

        public int Stamina
        {
            get { return stamina; }
            protected set
            {
                stamina = value;
            }
        }

        public int NumberOfMedals
        {
            get { return numberOfMedals; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Athlete's number of medals cannot be below 0.");
                }
                 numberOfMedals = value;
            }
        }

        public virtual void Exercise()
        {
        }
    }
}
