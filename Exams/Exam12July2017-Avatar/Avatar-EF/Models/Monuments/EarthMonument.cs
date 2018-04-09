using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EarthMonument : Monument, INation
{
    public override string Type => "Earth";

    public int EarthAffinity { get; set; }

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public override int GetBonus()
    {
        return this.EarthAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Earth Affinity: {this.EarthAffinity}";
    }
}

