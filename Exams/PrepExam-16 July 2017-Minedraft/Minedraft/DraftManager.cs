using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters; // Disct<Id, class>
    private Dictionary<string, Provider> providers; // по-лесно е с List<Class>!!!

    private double totalStoredEnergy;
    private double totalMinedOre;
    private string modeType;
    private Dictionary<string, double> energyRequirementMode; //Dict<typeMode, modifier>
    private Dictionary<string, double> oreOutputMode;

    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.modeType = "Full";

        energyRequirementMode = new Dictionary<string, double>();
        this.energyRequirementMode["Full"] = 1.0;
        this.energyRequirementMode["Half"] = 0.6;
        this.energyRequirementMode["Energy"] = 0.0;

        oreOutputMode = new Dictionary<string, double>();
        this.oreOutputMode["Full"] = 1.0;
        this.oreOutputMode["Half"] = 0.5;
        this.oreOutputMode["Energy"] = 0.0;

        harvesterFactory = new HarvesterFactory(); // можеше и без да иниц. Factory-то ако беше static!
        providerFactory = new ProviderFactory();  // можеше и без да иниц. Factory-то ако беше static!
    }

    public string RegisterHarvester(List<string> arguments)
    {
        //try// 180/200
        //{
        //    Harvester harvester = harvesterFactory.GetHarvester(arguments); //- BONUS!?!
        //    this.harvesters[harvester.Id] = harvester;
        //    return $"Successfully registered {harvester.GetType()} Harvester - {harvester.Id}";
        //}
        //catch (ArgumentException e)
        //{
        //    return e.Message;
        //}

        try // 200/200
        {
            string result = string.Empty;
            var type = arguments[0];
            var id = arguments[1];
            var oreOutput = double.Parse(arguments[2]);
            var energyRequirement = double.Parse(arguments[3]);
            if (type == "Sonic")
            {
                var sonicFactor = int.Parse(arguments[4]);
                Harvester sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                this.harvesters[id] = sonicHarvester;
                result = $"Successfully registered {type} Harvester - {id}";
            }
            else if (type == "Hammer")
            {
                Harvester hamerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
                this.harvesters[id] = hamerHarvester;
                result = $"Successfully registered {type} Harvester - {id}";
            }
            return result;
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        //try// 180/200
        //{
        //    Provider provider = providerFactory.GetProvider(arguments);
        //    this.providers[provider.Id] = provider;
        //    return $"Successfully registered {provider.GetType().Name} Provider - {provider.Id}";
        //}
        //catch (ArgumentException e)
        //{
        //    return e.Message;
        //}

        try// 200/200
        {
            string result = string.Empty;
            var type = arguments[0];
            var id = arguments[1];
            var energyOutput = double.Parse(arguments[2]);
            if (type == "Solar")
            {
                Provider solarProvider = new SolarProvider(id, energyOutput);
                this.providers[id] = solarProvider;
                result = $"Successfully registered {type} Provider - {id}";
            }
            else if (type == "Pressure")
            {
                Provider pressureProvider = new PressureProvider(id, energyOutput);
                this.providers[id] = pressureProvider;
                result = $"Successfully registered {type} Provider - {id}";
            }
            return result;
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string Day()
    {
        //double summedOreOutput = 0;
        //double energyRequirementModifier = this.energyRequirementMode[this.modeType];
        //double oreOutputModifier = this.oreOutputMode[this.modeType];
        //var summedEnergyOutput = this.providers
        //                          .Values
        //                          .Sum(p => p.EnergyOutput);
        //this.totalStoredEnergy += summedEnergyOutput;

        //var totalEnergyRequired = this.harvesters
        //                              .Values
        //                              .Sum(h => h.EnergyRequirement * energyRequirementModifier); // !!!
        //if ( this.totalStoredEnergy >= totalEnergyRequired )
        //{
        //    summedOreOutput = this.harvesters
        //                          .Values
        //                          .Sum(h => h.OreOutput * oreOutputModifier); // !!!
        //    this.totalMinedOre += summedOreOutput;
        //    this.totalStoredEnergy -= totalEnergyRequired;
        //}
        //var sb = new StringBuilder();
        //sb.AppendLine("A day has passed.")
        //    .AppendLine($"Energy Provided: {summedEnergyOutput}")
        //    .AppendLine($"Plumbus Ore Mined: {summedOreOutput}");
        //return sb.ToString().Trim();

        // or Var.2 - без Dict. с modifiers:
        var dayEnergyProvided = providers.Values.Sum(p => p.EnergyOutput);
        this.totalStoredEnergy += dayEnergyProvided;
        double dayEnergyRequired, dayMinedOre;
        if (modeType == "Full")
        {
            dayEnergyRequired = harvesters.Sum(h => h.Value.EnergyRequirement);
            dayMinedOre = harvesters.Sum(h => h.Value.OreOutput);
        }
        else if (modeType == "Half")
        {
            dayEnergyRequired = harvesters.Sum(h => h.Value.EnergyRequirement) * 0.6;
            dayMinedOre = harvesters.Sum(h => h.Value.OreOutput) * 0.5;
        }
        else
        {
            dayEnergyRequired = 0;
            dayMinedOre = 0;
        }
        double realDayMinedOre = 0;
        if (totalStoredEnergy >= dayEnergyRequired)
        {
            totalMinedOre += dayMinedOre;
            totalStoredEnergy -= dayEnergyRequired;
            realDayMinedOre = dayMinedOre;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.")
            .AppendLine($"Energy Provided: {dayEnergyProvided}")
            .AppendLine($"Plumbus Ore Mined: {realDayMinedOre}");
        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        string modeParam = arguments[0];

        if (modeParam == "Full" || modeParam == "Half" || modeParam == "Energy")
        {
            this.modeType = modeParam;
        }

        return $"Successfully changed working mode to {this.modeType} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        //var surcherPriveder = this.providers.Values.FirstOrDefault(p => p.Id == id);
        //var surcherHarvester = this.harvesters.Values.FirstOrDefault(p => p.Id == id);

        //if (surcherPriveder != null)
        //{
        //    return surcherPriveder.ToString();
        //}
        //else if (surcherHarvester != null)
        //{
        //    return surcherHarvester.ToString();
        //}
        //return $"No element found with id - {id}";

        //or var.2 -  търсим по общото м/у Harv и Prov, друго не ни интересува за тях
        var unit = (Unit)providers.Values.FirstOrDefault(p => p.Id == id) ?? harvesters.Values.FirstOrDefault(p => p.Id == id);
        if (unit == null)
        {
            return $"No element found with id - {id}";
        }
        else
        {
            return unit.ToString();
        }

        //or var.3:
        //if (!this.Harvesters.ContainsKey(id) && !this.Providers.ContainsKey(id))
        //{
        //    return $"No element found with id - {id}";
        //}
        //if (Harvesters.ContainsKey(id))
        //{
        //    return Harvesters[id].ToString(); // !!!!!!
        //}
        //return this.Providers[id].ToString();
    }

    public string ShutDown()
    {
        // var sb = new StringBuilder();
        //sb.AppendLine("System Shutdown");
        //sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        //sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");
        //return sb.ToString().Trim();
        
        //or with string:
        return "System Shutdown" + Environment.NewLine +
         $"Total Energy Stored: {this.totalStoredEnergy}" + Environment.NewLine +
       $"Total Mined Plumbus Ore: {this.totalMinedOre}";

    }
}

