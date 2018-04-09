using System;
using System.Collections.Generic;
using System.Linq;


class RawData
{
    static void Main()  // 100/100 
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = input[0];
            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            int cargoWeight = int.Parse(input[3]);
           string cargoType = input[4];
            double preasureTire1 = double.Parse(input[5]);
            int tireAge1 = int.Parse(input[6]);
            double preasureTire2 = double.Parse(input[7]);
            int tireAge2 = int.Parse(input[8]);
            double preasureTire3 = double.Parse(input[9]);
            int tireAge3 = int.Parse(input[10]);
            double preasureTire4 = double.Parse(input[11]);
            int tireAge4 = int.Parse(input[12]);

            Engine engine = new Engine( engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire tire1 = new Tire(preasureTire1, tireAge1);
            Tire tire2 = new Tire(preasureTire2, tireAge2);
            Tire tire3 = new Tire(preasureTire3, tireAge3);
            Tire tire4 = new Tire(preasureTire4, tireAge4);

            var tires = new Tire[4];
            tires[0] = tire1;
            tires[1] = tire2;
            tires[2] = tire3;
            tires[3] = tire4;
            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }

        var commnad = Console.ReadLine();
        switch (commnad)
        {
          case "fragile":
                var filteredCars = cars.Where(c => c.Cargo.CargoType == "fragile").Where(c => c.Tires.Any(t => t.Preasure < 1));

                foreach (var c in filteredCars)
                {
                    Console.WriteLine(c);
                }
                break;

            case "flamable":
               filteredCars = cars.Where(c => c.Cargo.CargoType == "flamable").Where(c => c.Engine.Enginepower>250);

                foreach (var c in filteredCars)
                {
                    Console.WriteLine(c);
                }
                break;
        }

    }
}

