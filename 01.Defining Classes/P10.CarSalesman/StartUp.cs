using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()  // 100/100 Големо парсване
    {
        var engines = new List<Engine>();
        var cars = new List<Car>();

        var countEngines = int.Parse(Console.ReadLine());
        for (int i = 0; i < countEngines; i++)
        {
            var inputEngine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var engine = GetEngine(inputEngine);
            engines.Add(engine);
        }

        var countCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < countCars; i++)
        {
            var inputCar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = inputCar[0];
            var exactEngine = engines.FirstOrDefault(e => e.Model == inputCar[1]);
            var car = new Car(model, exactEngine);

            string weight = null;
            string color = null;
            if (inputCar.Length == 3)
            {
                //var color = inputCar[2];
                //car.Color = color;
                int parsedWeight;
                bool isNumber = int.TryParse(inputCar[2], out parsedWeight);
                if (isNumber)
                {
                    weight = parsedWeight.ToString();
                    car.Weight = weight;
                }
                else
                {
                    color = inputCar[2];
                    car.Color = color;
                }
            }
            else if (inputCar.Length == 4)
            {
                weight =inputCar[2];
                car.Weight = weight;
               color = inputCar[3];
                car.Color = color;
            }
            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");            
            Console.WriteLine($"  Weight: {car.Weight}");
            Console.WriteLine($"  Color: {car.Color}");
        }
    }

    private static Engine GetEngine(string[] inputEngine)
    {
        var model = inputEngine[0];
        double power = double.Parse(inputEngine[1]);
        var engine = new Engine( model, power);

        string displacement= "n/a";
        string efficiency="n/a";

        if (inputEngine.Length==3)
        {
            //    double displacement = double.Parse(inputEngine[2]);
            //    engine.Displacement = displacement;
            int parsedDisplacement;
            bool isNumber = int.TryParse(inputEngine[2], out parsedDisplacement);
            if (isNumber)
            {
                displacement = parsedDisplacement.ToString();
                engine.Displacement = displacement;
            }
            else
            {
                efficiency = inputEngine[2];
                engine.Efficiency = efficiency;
            }
        }
        else if (inputEngine.Length == 4)
        {
            displacement = inputEngine[2];
            engine.Displacement = displacement;

            efficiency = inputEngine[3];
            engine.Efficiency = efficiency;
        }

        return engine;
    }
}

