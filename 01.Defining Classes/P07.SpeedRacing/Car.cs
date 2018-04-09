using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private double fuel=0;
    private double fuelConsumption=0;
    private double distanceTraversed = 0;

    public Car()
    {
    }

    public Car(string model, double fuel, double fuelConsumption)
    {
        this.Model = model;
        this.Fuel = fuel;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTraversed = 0;
    }

    
    public double DistanceTraversed
    {
        get { return distanceTraversed; }
        set { distanceTraversed = value; }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public double Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }


    public bool MoveToDistance(double distance)
    {
        double needeFuel = this.FuelConsumption * distance;

        if ( this.Fuel < needeFuel)
        {
            return false;  // щом има return, няма else
        }
       
            this.Fuel -= needeFuel;
            this.DistanceTraversed += distance;
            return true;      
    }

    public override string ToString()
    {
        return $"{this.Model} {this.Fuel:f2} {this.DistanceTraversed}";
    }
}

