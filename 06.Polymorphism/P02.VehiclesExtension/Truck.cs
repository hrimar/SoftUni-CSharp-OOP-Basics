using System;
using System.Collections.Generic;
using System.Text;

public class Truck : Vehicle
{
    private const double INCREASEMENT = 1.6;
        
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
        this.FuelConsumption += INCREASEMENT;
    }
   
    //public override string Drive(double distance)
    //{
    //    if (this.FuelQuantity < distance * (this.FuelConsumption + INCREASEMENT))
    //    {
    //        return $"{GetType()} needs refueling";
    //    }
    //    else
    //    {
    //        this.FuelQuantity -= distance * (this.FuelConsumption + INCREASEMENT);
    //        return $"{GetType()} travelled {distance} km";
    //    }
    //}

    public override void Refilling(double fuel)
    {
        if (fuel + this.FuelQuantity > this.TankCapacity)
        {
            // Console.WriteLine($"Cannot fit {fuel} fuel in the tank"); ;
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        if (fuel <= 0)
        {
            // Console.WriteLine("Fuel must be a positive number");
            throw new ArgumentException("Fuel must be a positive number");
        }
       
            this.FuelQuantity += fuel*0.95;
    }
}

