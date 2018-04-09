using System;
using System.Collections.Generic;
using System.Text;

public abstract class Bird : Animal
{
    public Bird(string name, double weight, double wingSize) : base(name, weight)
    {    
        this.WingSize = wingSize;       
    }

    public double WingSize { get; set; }

    public override string ToString()
    {
        string fromBase = base.ToString();
        string result = string.Format(fromBase, $"{this.WingSize}, ", string.Empty); // string.Format намира в този стринг къде има холдъри и слага подадените неща;

        return result;
    }
}

