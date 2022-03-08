using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
           => base.FuelConsumption + 1.6;

        public override void Refuel(double litres)
        {
            VlidateLitres(litres);
            ValidateQuantity(litres);

            litres *= 0.95;
            base.Refuel(litres);
        }
    }
}
