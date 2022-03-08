
namespace Vehicle
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }
        public bool IsEmpty { get; set; }
        void Drive(double km);
        void Refuel(double fuel);
        bool CanDrive(double km);
    }
}
