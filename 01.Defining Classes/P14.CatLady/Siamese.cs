using System;
using System.Collections.Generic;
using System.Text;

public class Siamese : Cat
{
  // заради наследяването получаваме и проп-та на класа Cat!!!

    private int earSize;
    
    public Siamese()
    {
    }
    public Siamese(int earSize)
    {      
        this.EarSize = earSize;
    }

    public int EarSize
    {
        get { return earSize; }
        set { earSize = value; }
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.EarSize}";
    }
}


