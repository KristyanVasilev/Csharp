using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const string DoughtExeptionMessage = "Invalid type of dough.";
        private const string WeightExeptionMessage = "Dough weight should be in the range [1..200].";

        private Dictionary<string, double> flourTypeCalories = new Dictionary<string, double>()
        {
            { "white", 1.5 },
            { "wholegrain", 1}          
        };

        private Dictionary<string, double> bakingTechniqueCalories = new Dictionary<string, double>()
        {
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1}
        };

        private string flourType;
        private string bakingTechique;
        private double weight;

        public Dough(string flourType, string bakingTechique, double weight)
        {
           this.FlourType = flourType;
           this.BakingTechique = bakingTechique;
           this.Weight = weight;
        }

        public string FlourType
        {
            get { return flourType; }
            private set 
            {
                if (!flourTypeCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(DoughtExeptionMessage);
                }
                flourType = value; 
            }
        }

        public string BakingTechique
        {
            get { return bakingTechique; }
            private set 
            {
                if (!bakingTechniqueCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(DoughtExeptionMessage);
                }
                bakingTechique = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(WeightExeptionMessage);
                }
                weight = value; 
            }
        }

        public double Calories
            => 2 * Weight * this.flourTypeCalories[this.FlourType.ToLower()]
            * this.bakingTechniqueCalories[this.BakingTechique.ToLower()];
    }
}
