using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var vehicles = new List<Vehicle>();

        var carDetails = Console.ReadLine().Split();
        double carFuelQuantity = double.Parse(carDetails[1]);
        double carFuelConsumption = double.Parse(carDetails[2]);
        Vehicle car = new Car(carFuelQuantity, carFuelConsumption);
        vehicles.Add(car);

        var truckDetails = Console.ReadLine().Split();
        double fuelQuantity = double.Parse(truckDetails[1]);
        double fuelConsumption = double.Parse(truckDetails[2]);
        Vehicle truck = new Truck(fuelQuantity, fuelConsumption);
        vehicles.Add(truck);

        var numberInputs = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberInputs; i++)
        {
            var input = Console.ReadLine().Split();
            var command = input[0];
            var typeVehicle = input[1];
            double distance =double.Parse(input[2]);
            switch (command)
            {
             case "Drive":
                    if (typeVehicle=="Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (typeVehicle == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                    break;
                case "Refuel":
                    if (typeVehicle == "Car")
                    {
                        car.Refilling(distance);
                    }
                    else if (typeVehicle == "Truck")
                    {
                        truck.Refilling(distance);
                    }
                    break;
            }
        }

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }

    }
}

