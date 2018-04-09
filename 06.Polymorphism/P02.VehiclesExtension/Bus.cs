using System;
using System.Collections.Generic;
using System.Text;

public class Bus : Vehicle  // !!!!!!!!!!!
{
    private const double INCREASEMENT = 1.4;

    
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override string Drive(string command, double distance)
    {

        if (this.FuelQuantity < distance * (this.FuelConsumption + INCREASEMENT))
        {
            return $"{GetType()} needs refueling";
        }

        this.FuelQuantity -= distance * (this.FuelConsumption + INCREASEMENT);
        return $"{GetType()} travelled {distance} km";
    }

    public string DriveEmpty(string command, double distance)
    {
        if (this.FuelQuantity < distance * (this.FuelConsumption))
        {
            return $"{GetType()} needs refueling";
        }
        else
        {
            this.FuelQuantity -= distance * (this.FuelConsumption);
            return $"{GetType()} travelled {distance} km";
        }
    }
}
