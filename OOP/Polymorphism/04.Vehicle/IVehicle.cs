
namespace Vehicle
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }

        void Drive(double km);
        void Refuel(double fuel);

        bool CanDrive(double km);
    }
}
