using System;

namespace Vehicle
{
    public abstract class Vehicle : IVehicle
    {
        private const string FuelConsumptionException = "Fuel consumption can't be negative or null!";

        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            private set
            {
                if (value > this.TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
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

        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }

        public bool IsEmpty { get; set; }

        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.fuelQuantity -= km * this.FuelConsumption;
            }
        }

        public bool CanDrive(double km)
           => this.fuelQuantity - km * this.FuelConsumption >= 0;

        public virtual void Refuel(double litres)
        {
            VlidateLitres(litres);
            ValidateQuantity(litres);

            this.FuelQuantity += litres;
        }

        protected void ValidateQuantity(double litres)
        {
            if (this.FuelQuantity + litres > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {litres} fuel in the tank");
            }
        }

        protected static void VlidateLitres(double litres)
        {
            if (litres <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
        }
    }
}
