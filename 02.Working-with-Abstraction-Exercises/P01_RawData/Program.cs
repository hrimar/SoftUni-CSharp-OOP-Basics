using System;
using System.Collections.Generic;
using System.Linq;

class RawData   // 100/100
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            GetCar(cars, parameters);
        }

        string command = Console.ReadLine();

        PrintResult(cars, command);
    }

    private static void PrintResult(List<Car> cars, string command)
    {
        if (command == "fragile")
        {
            List<string> fragile = cars
                .Where(x => x.cargo.cargoType == "fragile" && x.tires.Any(y => y.tirePressure < 1))
                .Select(x => x.model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
        else
        {
            List<string> flamable = cars
                .Where(x => x.cargo.cargoType == "flamable" && x.engine.enginePower > 250)
                .Select(x => x.model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }
    }

    private static void GetCar(List<Car> cars, string[] parameters)
    {
        string model = parameters[0];
        int engineSpeed = int.Parse(parameters[1]);
        int enginePower = int.Parse(parameters[2]);
        int cargoWeight = int.Parse(parameters[3]);
        string cargoType = parameters[4];
        double tire1Pressure = double.Parse(parameters[5]);
        int tire1age = int.Parse(parameters[6]);
        double tire2Pressure = double.Parse(parameters[7]);
        int tire2age = int.Parse(parameters[8]);
        double tire3Pressure = double.Parse(parameters[9]);
        int tire3age = int.Parse(parameters[10]);
        double tire4Pressure = double.Parse(parameters[11]);
        int tire4age = int.Parse(parameters[12]);

        var engine = new Engine(engineSpeed, enginePower);
        var cargo = new Cargo(cargoWeight, cargoType);

        var tire1 = new Tire(tire1Pressure, tire1age);
        var tire2 = new Tire(tire2Pressure, tire2age);
        var tire3 = new Tire(tire3Pressure, tire3age);
        var tire4 = new Tire(tire4Pressure, tire4age);
        var tires = new List<Tire>();
        tires.Add(tire1);
        tires.Add(tire2);
        tires.Add(tire3);
        tires.Add(tire4);

        cars.Add(new Car(model, engine, cargo, tires));
    }
}

