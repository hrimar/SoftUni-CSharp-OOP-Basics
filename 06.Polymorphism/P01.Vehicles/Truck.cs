using System;
using System.Collections.Generic;
using System.Text;

public class Truck : Vehicle
{
    private const double INCREASEMENT= 1.6;

    public Truck(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public override string Drive(double distance)
    {
        if (this.FuelQuantity < distance * (this.FuelConsumption + INCREASEMENT))
        {
            return $"{GetType()} needs refueling";
        }
        else
        {
            this.FuelQuantity -= distance * (this.FuelConsumption + INCREASEMENT);
            return $"{GetType()} travelled {distance} km";

        }
    }

    public override void Refilling(double fuel)
    {
        this.FuelQuantity += fuel*0.95;
    }
}

