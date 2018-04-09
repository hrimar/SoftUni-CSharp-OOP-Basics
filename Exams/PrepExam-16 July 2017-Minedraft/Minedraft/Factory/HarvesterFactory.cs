using System;
using System.Collections.Generic;
using System.Text;

public class HarvesterFactory
{
    //public List<string> Arguments { get; set; } - излишно

    //public HarvesterFactory(List<string> arguments)
    //{
    //    this.Arguments = new List<string>();
    //}

    public Harvester GetHarvester(List<string> arguments) //(params string[] arguments)
    {        
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);
        switch (type)
        {
            case "Sonic":
                var sonicFactor = int.Parse(arguments[4]);
                Harvester sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                return sonicHarvester;

            case "Hammer":
                Harvester hamerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
                //this.Harvesters[id] = hamerHarvester;
                // result = $"Successfully registered {type} Harvester - {id}";
                return hamerHarvester;
            default:
                throw new ArgumentException("Harvester is not registered, because of it's Type");
        }
    }
}

