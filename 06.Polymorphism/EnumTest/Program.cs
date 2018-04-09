using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumTest
{
public class Fisherman
{
    public string Name { get; set; }
    public FishingType FishingType { get; set; }
    public List<string> Lures { get; set; }

        public Fisherman(string name)
        {
            this.Name = name;           
            this.Lures = new List<string>();
        }
        //public Fisherman(string name, string fishingType)
        //{
        //    this.Name = name;
        //    ParseEnum(fishingType);
        //    this.Lures = new List<string>();
        //}

        private void ParseEnum(string type)
    {
        bool isValidType = Enum.TryParse(typeof(FishingType), type, out object outType);
        if (!isValidType)
        {
            throw new ArgumentException("Invalid fishing type!");
        }
        this.FishingType = (FishingType)outType;
    }

    public override string ToString()
    {
        return $"I am: {this.Name}. I prefer {this.FishingType} fishing and has: {string.Join(", ", this.Lures)}";
    }
}

public enum FishingType
{
    spinning, fly, traditional
}

class Program
{
    static void Main()
    {
        var inputType = Console.ReadLine().Split();
        var name = inputType[0];
        string fishingType = inputType[1];

            //FishingType enumCommand = Enum.Parse<FishingType>(fishingType); // var 2 - Parse

            var enumCommand = Enum.TryParse<FishingType>(fishingType, out var type) ? type : FishingType.traditional;  // var 3 - TryParse

            Fisherman fisherman = new Fisherman(name);
            fisherman.FishingType = type;
            List<string> lures = inputType.Skip(2).Take(3).ToList();
            fisherman.Lures.AddRange(lures);
            Console.WriteLine(fisherman);
            try
            {
                // var 1 - TryParse директно с констр на класа!
                //Fisherman fisherman = new Fisherman(name, fishingType);
                //List<string> lures = inputType.Skip(2).Take(3).ToList();
                //fisherman.Lures.AddRange(lures);

                //Console.WriteLine(fisherman);
            }
            catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
            
        // Hristo fy vobler spinner waspFly -> Invalid fishing type!
        // Hristo fly vobler spinner waspFly -> I am: Hristo. I prefer fly fishing and has: vobler, spinner, waspFly
    }
}
}
