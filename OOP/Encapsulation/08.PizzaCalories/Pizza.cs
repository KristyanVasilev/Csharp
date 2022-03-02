using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public IReadOnlyCollection<Topping> Toppings => toppings;

        public Dough Dough
        {
            get { return dough; }
            private set { dough = value; }
        }

        public double CalculateTotalCalories()
        {
            return this.Dough.Calories + this.toppings.Sum(x => x.Calories);
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }
    }
}
