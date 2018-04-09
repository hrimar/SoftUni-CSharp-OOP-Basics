using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester :   Unit
{
   // private string id;
    private double oreOutput; // OK - -1.000.000 - уж се побира в float, а иска double!!!
    private double energyRequirement; // OK

    protected Harvester(string id, double oreOutput, double energyRequirement)
       : base(id)
    {
       // this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    //public string Id
    //{
    //    get { return id; }
    //    set { id = value; }
    //}

    public double OreOutput
    {
        get { return oreOutput; }
       protected set
        {
            if(value<0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput"); 
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement 
    {
        get { return energyRequirement ; }
        protected set
        {
            if (value < 0 || value >20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement"); 
            }
            energyRequirement  = value; }
    }


    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Harvester - {this.Id}")
            .AppendLine($"Ore Output: {this.OreOutput}")
            .AppendLine($"Energy Requirement: {this.EnergyRequirement}");
         
        return sb.ToString().Trim();
    }


}

