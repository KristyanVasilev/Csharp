
namespace Vehicle
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
            => this.IsEmpty ? base.FuelConsumption : base.FuelConsumption + 1.4;
    }
}
