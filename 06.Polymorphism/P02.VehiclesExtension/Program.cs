using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main() // 100/100
    {
       // var vehicles = new List<Vehicle>();

        var carDetails = Console.ReadLine().Split();
        double carFuelQuantity = double.Parse(carDetails[1]);
        double carFuelConsumption = double.Parse(carDetails[2]);
        double carTankCapacity = double.Parse(carDetails[3]);
        var car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
       // vehicles.Add(car);

        var truckDetails = Console.ReadLine().Split();
        double fuelQuantity = double.Parse(truckDetails[1]);
        double fuelConsumption = double.Parse(truckDetails[2]);
        double tankCapacity = double.Parse(truckDetails[3]);
        var truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
       // vehicles.Add(truck);

        var details = Console.ReadLine().Split();
        double quantity = double.Parse(details[1]);
        double consumption = double.Parse(details[2]);
        double capacity = double.Parse(details[3]);
        var bus = new Bus(quantity, consumption, capacity);
       // vehicles.Add(bus);

        var numberInputs = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberInputs; i++)
        {
            var input = Console.ReadLine().Split();
            var command = input[0];
            var typeVehicle = input[1];
            double distanceORFuel = double.Parse(input[2]);
            try
            {
                switch (command)
                {
                    case "Drive":
                        if (typeVehicle == "Car")
                        {
                            Console.WriteLine(car.Drive(command, distanceORFuel));
                        }
                        else if (typeVehicle == "Truck")
                        {
                            Console.WriteLine(truck.Drive(command, distanceORFuel));
                        }
                        else if (typeVehicle == "Bus")
                        {
                            Console.WriteLine(bus.Drive(command, distanceORFuel));
                        }
                        break;
                    case "Refuel":
                        if (typeVehicle == "Car")
                        {
                            car.Refilling(distanceORFuel);
                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.Refilling(distanceORFuel);
                        }
                        else if (typeVehicle == "Bus")
                        {
                            bus.Refilling(distanceORFuel);
                        }
                        break;
                    case "DriveEmpty":
                        Console.WriteLine(bus.DriveEmpty(command, distanceORFuel));
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);

        //foreach (var vehicle in vehicles)
        //{
        //    Console.WriteLine(vehicle);
        //}

    }
}

