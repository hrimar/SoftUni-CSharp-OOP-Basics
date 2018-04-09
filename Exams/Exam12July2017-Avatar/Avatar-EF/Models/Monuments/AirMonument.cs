using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AirMonument : Monument, INation
{
    public override string Type => "Air";


    public int AirAffinity { get; set; }

    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }


    public override int GetBonus()
    {
        return this.AirAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Air Affinity: {this.AirAffinity}";
    }
}

