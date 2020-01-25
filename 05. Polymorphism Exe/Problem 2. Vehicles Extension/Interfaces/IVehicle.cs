namespace VehiclesExtension.Interfaces
{
    public interface IVehicle
    {
        double TankCapacity { get; }
        double FuelQuantity { get; }
        double ConsumptionPerKm { get; }
        string Drive(double distance);
        double Refuel(double fuel); 
    }
}
