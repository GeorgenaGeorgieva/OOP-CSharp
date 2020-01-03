namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];

                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];

                List<Tire> tires = new List<Tire>();

                for (int k = 5; k < parameters.Length; k += 2)
                {
                    double pressure = double.Parse(parameters[k]);
                    int age = int.Parse(parameters[k + 1]);

                    tires.Add(new Tire(pressure, age));
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
            else
            {
                cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }
    }
}
