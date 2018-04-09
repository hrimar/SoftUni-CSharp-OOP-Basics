using System;
using System.Collections.Generic;
using System.Text;

public class Tire
{
    public int tireAge { get; set; }
    public double tirePressure { get; set; }



    public Tire(double tirePressure, int tireAge)
    {
        this.tirePressure = tirePressure;
        this.tireAge = tireAge;
    }
}

