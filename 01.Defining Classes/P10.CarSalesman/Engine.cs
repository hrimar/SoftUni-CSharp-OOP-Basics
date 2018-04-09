﻿using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private string model;
    private double power;
    private string displacement = "n/a";
    private string efficiency ="n/a";

    public Engine()
    {
    }
    public Engine(string model, double power)
    {
        this.Model = model;
        this.Power = power;
    }
    public Engine(string model, double power, string displacement) 
        : this(model, power)
    {
        this.Displacement = displacement;
    }
    public Engine(string model, double power, string displacement, string efficiency)
        : this(model, power, displacement)
    {
        this.Efficiency = efficiency;
    }


    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }

    public string Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public double Power
    {
        get { return power; }
        set { power = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

}

