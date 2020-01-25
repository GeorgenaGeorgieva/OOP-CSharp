namespace Vehicles
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                var Information = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var fuelQuantityCar = double.Parse(Information[1]);
                var consumptionCar = double.Parse(Information[2]);
                var car = new Car(fuelQuantityCar, consumptionCar);

                Information = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var fuelQuantityTruck = double.Parse(Information[1]);
                var consumptionTruck = double.Parse(Information[2]);
                var truck = new Truck(fuelQuantityTruck, consumptionTruck);

                var numberOfLines = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfLines; i++)
                {
                    var command = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var action = command[0];
                    var type = command[1];
                    var value = double.Parse(command[2]);

                    if (type == "Car")
                    {
                        ImplementationCommand(car, action, value);
                    }
                    else if (type == "Truck")
                    {
                        ImplementationCommand(truck, action, value);
                    }
                }

                Console.WriteLine(car);
                Console.WriteLine(truck);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }

        public static void ImplementationCommand(Vehicle vehicle, string action, double value)
        {
            if (action == "Drive")
            {
                Console.WriteLine(vehicle.Drive(value));
            }
            else if (action == "Refuel")
            {
                vehicle.Refuel(value);
            }
        }
    }
}
