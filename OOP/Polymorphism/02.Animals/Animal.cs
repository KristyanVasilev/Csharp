using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {

        private string name;
        private string favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string FavouriteFood
        {
            get { return favouriteFood; }
            private set { favouriteFood = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }


        public virtual string ExplainSelf()
            => $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
    }
}
