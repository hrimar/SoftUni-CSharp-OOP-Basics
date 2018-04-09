using System;
using System.Collections.Generic;
using System.Text;

public class ProviderFactory
{
    
    public  Provider GetProvider(List<string> arguments)   //(params string[] arguments)
    {
        string result = string.Empty;

        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);
        switch (type)
        {
            case "Solar":
                Provider solarProvider = new SolarProvider(id, energyOutput);
                return solarProvider;
            //this.Providers[id] = solarProvider;
            //result = $"Successfully registered {type} Provider - {id}";
            case "Pressure":
                Provider pressureProvider = new PressureProvider(id, energyOutput);
                return pressureProvider;
            //this.Providers[id] = pressureProvider;
            //result = $"Successfully registered {type} Provider - {id}";
            default:
                throw new ArgumentException("Harvester is not registered, because of it's Type");
        }
    }
}

