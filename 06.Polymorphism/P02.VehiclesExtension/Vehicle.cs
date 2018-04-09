using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    private double tankCapacity;
    private double fuelQuantity;
    private double fuelConsumption;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;   // !!!
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;

    }

    public double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Fuel must be a positive number", nameof(fuelQuantity));
            }

            if (value > this.TankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value;
            }
        }
    }

    public double FuelConsumption
    {
        get
        {
            return this.fuelConsumption;
        }
        protected set
        {
            fuelConsumption = value;
        }
    }

    public double TankCapacity
    {
        get
        {
            return this.tankCapacity;
        }
        protected set
        {
            tankCapacity = value;
        }
    }

    //// var1.
    //public abstract string Drive(double distance);
    // Var2. - с ctor и да подавам разл ст-ст за FuelConsumption за всеки вид, а метода да е тук:
    public virtual string Drive(string command, double distance)
    {
        //if (distance <= 0)
        //{
        //    return "Distance must be a positive number";
        //}
        if (this.FuelQuantity < distance * this.FuelConsumption)
        {
            return $"{GetType()} needs refueling";
        }

        this.FuelQuantity -= distance * this.FuelConsumption;
        return $"{GetType()} travelled {distance} km";

    }


    public virtual void Refilling(double fuel)
    {
        if (fuel + this.FuelQuantity > this.TankCapacity)
        {
            //Console.WriteLine($"Cannot fit {fuel} fuel in the tank"); 
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        if (fuel <= 0)
        {
            //   Console.WriteLine("Fuel must be a positive number");
            throw new ArgumentException("Fuel must be a positive number");
        }
        else
        {
            this.FuelQuantity += fuel;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType()}: {FuelQuantity:f2}";
    }
}

