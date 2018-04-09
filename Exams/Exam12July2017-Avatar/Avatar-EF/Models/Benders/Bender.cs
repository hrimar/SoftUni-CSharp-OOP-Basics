using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Bender : INation
{
    public string Name { get; protected set; } // 
    public int Power { get; protected set; }

    public abstract string Type { get; }

    public Bender()
    {

    }
    protected Bender(string name, int power)   // protected
    {
        this.Name = name;
        this.Power = power;
    }

    public abstract double GetPower();

    public override string ToString()
    {
        return $"###{this.Type} Bender: {this.Name}, Power: {this.Power:f0}";
    }
}

