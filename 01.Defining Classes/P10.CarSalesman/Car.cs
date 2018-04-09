using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private string weight = "n/a";
    private string color = "n/a";


    public Car()
    {
    }
    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
    }
    public Car(string model, Engine engine, string weight) :this(model, engine)
    {
        this.Weight = weight;
    }
    public Car(string model, Engine engine, string weight, string color) : this(model, engine, weight)
    {
        this.Color = color;
    }


    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }


    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

}

