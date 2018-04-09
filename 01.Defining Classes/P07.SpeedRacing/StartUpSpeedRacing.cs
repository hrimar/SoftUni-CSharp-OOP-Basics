using System;
using System.Collections.Generic;
using System.Linq;

class StartUpSpeedRacing
{
    static void Main()  // 100/100
    {
        var cars = new List<Car>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var inputCars = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = inputCars[0];
            var fuel = double.Parse(inputCars[1]);
            var fuelConsumption = double.Parse(inputCars[2]);

            // Unique cars!!!
            if (!cars.Any(c => c.Model == model))
            {
                var car = new Car(model, fuel, fuelConsumption);
                cars.Add(car);
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputDetails = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var comand = inputDetails[0];
            var model = inputDetails[1];
            var distance = double.Parse(inputDetails[2]); 

            var targetCar = cars.FirstOrDefault(c => c.Model == model); 
            bool canMove = targetCar.MoveToDistance(distance);
            if (targetCar != null)
            {
                if (!canMove)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
