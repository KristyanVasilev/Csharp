using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelConsumption 
            => base.FuelConsumption + 0.9;
    }
}
