using Gym.Models.Equipment.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public abstract class Equipment : IEquipment
    {
        private double weight;
        private decimal price;
        public Equipment(double weight, decimal price)
        {
            this.Weight = weight;
            this.Price = price;
        }

        public double Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }

        public decimal Price
        {
            get { return price; }
            protected set { price = value; }
        }
    }
}
