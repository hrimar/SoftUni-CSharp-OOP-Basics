using System;
using System.Collections.Generic;
using System.Text;

public class Tesla : Seat, ICar, IElectricCar
{
    public int Batery { get; private set; }

    //public string Model { get; private set; }

    //public string Color { get; private set; }

    public Tesla(string model, string color, int batery) : base(model, color)
    {
        //this.Model = model;
        //this.Color = color;
        this.Batery = batery;
    }

    //public string Start()
    //{
    //    return "Engine start";
    //}

    //public string Stop()
    //{
    //    return "Breaaak!";
    //}

    public override string ToString()
    {
        return $"{this.Color} {this.GetType()} {this.Model} with {this.Batery} Batteries" + Environment.NewLine +
            Start() + Environment.NewLine + Stop();
    }
}

