using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari : ICar, IPerson
{
    public string Model { get; set; }

    public string Name { get; set; }

    public Ferrari( string name)
    {
        this.Model = "488-Spider";
        this.Name = name;
    }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.Name}";
    }
}

