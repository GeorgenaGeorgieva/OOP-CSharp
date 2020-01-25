namespace VehiclesExtension
{
    using System;
    using Clases;

    public class StartUp
    {
        public static void Main(string[] args)
        {

            string[] information = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantityCar = double.Parse(information[1]);
            double consumptionCar = double.Parse(information[2]);
            double capacityTankCar = double.Parse(information[3]);
            Vehicle car = new Car(fuelQuantityCar, consumptionCar, capacityTankCar);

            information = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantityTruck = double.Parse(information[1]);
            double consumptionTruck = double.Parse(information[2]);
            double capacityTankTruck = double.Parse(information[3]);
            Vehicle truck = new Truck(fuelQuantityTruck, consumptionTruck, capacityTankTruck);

            information = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantityBus = double.Parse(information[1]);
            double consumptionBus = double.Parse(information[2]);
            double capacityTankBus = double.Parse(information[3]);
            Vehicle bus = new Bus(fuelQuantityBus, consumptionBus, capacityTankBus);

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];
                string type = command[1];
                double value = double.Parse(command[2]);

                try
                {
                    if (type == "Car")
                    {
                        ImplementationCommand(car, action, value);
                    }
                    else if (type == "Truck")
                    {
                        ImplementationCommand(truck, action, value);
                    }
                    else if (type == "Bus")
                    {
                        if (action.EndsWith("Empty"))
                        {
                            ((Bus)bus).DriveEmpty();
                        }

                        ImplementationCommand(bus, action, value);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        public static void ImplementationCommand(Vehicle vehicle, string action, double value)
        {
            if (action.StartsWith("Drive"))
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
