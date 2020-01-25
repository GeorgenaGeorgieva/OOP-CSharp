namespace Vehicles.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double ConsumptionPerKm { get; }
        string Drive(double distance);
        double Refuel(double fuel); 
    }
}
