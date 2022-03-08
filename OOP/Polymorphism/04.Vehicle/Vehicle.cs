using System;

namespace Vehicle
{
    public abstract class Vehicle : IVehicle
    {
        private const string FuelConsumptionException = "Fuel consumption can't be negative or null!";

        private const string FuelQuantityException = "Fuel quantity can't be negative!";

        private double fuelQuantity;

        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException(FuelQuantityException);
                }
                fuelQuantity = value; 
            }
        }

        public virtual double FuelConsumption
        {
            get { return fuelConsumption; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(FuelConsumptionException);
                }
                fuelConsumption = value; 
            }
        }

        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.fuelQuantity -= km * FuelConsumption;
            }
        }

        public bool CanDrive(double km)
           => this.fuelQuantity - km * FuelConsumption >= 0;

        public virtual void Refuel(double fuelLitres)
            => this.FuelQuantity += fuelLitres;
    }
}
