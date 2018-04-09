using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput * 3, energyRequirement * 2)
    {
        //this.OreOutput = oreOutput + (oreOutput * 2);   // може и така
        //this.EnergyRequirement = energyRequirement + (energyRequirement * 1);   // може и така
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Hammer ");
        sb.AppendLine(base.ToString());

        return sb.ToString().Trim();
    }
}

