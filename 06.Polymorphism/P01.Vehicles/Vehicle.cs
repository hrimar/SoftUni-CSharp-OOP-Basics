using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
   public double FuelQuantity { get; set; }

   public double FuelConsumption { get; set; }


    public  abstract  string Drive(double distance);
    // Var2. - да увеличавам проп FuelConsumption за всеки вид, а метода да е тук:
    // public  string Drive(double distance)
    //{
    //if (this.FuelQuantity < distance * this.FuelConsumption)
    //{
    //      return $"{GetType()} needs refueling";
    //}
    //else
    //{
    //    this.FuelQuantity -= distance * this.FuelConsumption+distance*0.9;
    //    return $"{GetType()} travelled {distance} km";
    //}
    //}

    public virtual void Refilling(double fuel)
    {
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType()}: {FuelQuantity:f2}";
    }
}

