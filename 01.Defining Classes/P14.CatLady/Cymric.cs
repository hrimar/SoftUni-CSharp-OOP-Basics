using System;
using System.Collections.Generic;
using System.Text;

public class Cymric :Cat
{
    
    private double furLength;


    public Cymric()
    {
    }
    public Cymric(double earSize)
    {

        this.FurLength = earSize;

    }


    public double FurLength
    {
        get { return furLength; }
        set { furLength = value; }
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.FurLength:f2}";
    }

}
