using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> wars;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            { "Air", new Nation() },
            { "Earth", new Nation() },
            { "Fire", new Nation() },
            { "Water", new Nation() },
        };
        this.wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        string type = benderArgs[0];
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double parameter = double.Parse(benderArgs[3]);
        switch (type)
        {
            case "Air":
                AirBender airBender = new AirBender(name, power, parameter);
                this.nations[type].AddBender(airBender);
                break;
            case "Water":
                WaterBender waterBender = new WaterBender(name, power, parameter);
                this.nations[type].AddBender(waterBender);
                break;
            case "Fire":
                FireBender fireBender = new FireBender(name, power, parameter);
                this.nations[type].AddBender(fireBender);
                break;
            case "Earth":
                EarthBender earthBender = new EarthBender(name, power, parameter);
                this.nations[type].AddBender(earthBender);
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[0];
        string name = monumentArgs[1];
        int power = int.Parse(monumentArgs[2]);

        switch (type)
        {
            case "Air":
                AirMonument airMonument = new AirMonument(name, power);
                this.nations[type].AddMonument(airMonument);
                break;
            case "Water":
                WaterMonument waterMonument = new WaterMonument(name, power);
                this.nations[type].AddMonument(waterMonument);
                break;
            case "Fire":
                FireMonument fireMonument = new FireMonument(name, power);
                this.nations[type].AddMonument(fireMonument);
                break;
            case "Earth":
                EarthMonument earthMonument = new EarthMonument(name, power);
                this.nations[type].AddMonument(earthMonument);
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        var exactNation = this.nations[nationsType];
        string result = $"{nationsType} Nation" + Environment.NewLine + exactNation.ToString();
        return result;
    }

    public void IssueWar(string nationsType)
    {
        var winner = nations.Max(n => n.Value.GetTotalPower()); // 

        foreach (var nation in nations)
        {
            if(nation.Value.GetTotalPower() != winner)
            {
                nation.Value.KillYourself();
            }
        }
        
        this.wars.Add(nationsType);
    }
    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        int counter = 1;
        foreach (var war in wars)
        {
            sb.AppendLine($"War {counter} issued by {war}");
            counter++;
        }

        return sb.ToString().Trim();
    }


}

