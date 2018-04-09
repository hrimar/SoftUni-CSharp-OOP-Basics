using System;
using System.Collections.Generic;
using System.Text;

public abstract class Mammal : Animal
{
    public Mammal(string name, double weight, string livingRegion) : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion { get; set; }
    

    public override string ToString()
    {
        string fromBase = base.ToString();
        string result = string.Format(fromBase, "{0}", $"{this.LivingRegion}, "); // string.Format намира в този стринг къде има холдъри и слага подадените неща;

        return result;
    }
}

