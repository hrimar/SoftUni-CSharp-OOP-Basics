using System;
using System.Collections.Generic;
using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput = energyOutput + (energyOutput * 0.5f);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Presure ");
        sb.AppendLine(base.ToString());

        return sb.ToString().Trim();
    }
}

