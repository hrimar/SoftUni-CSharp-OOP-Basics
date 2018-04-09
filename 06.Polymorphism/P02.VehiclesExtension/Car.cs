using System;
using System.Collections.Generic;
using System.Text;

public class Car : Vehicle
{
    private const double INCREASEMENT = 0.9;


    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
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
}

