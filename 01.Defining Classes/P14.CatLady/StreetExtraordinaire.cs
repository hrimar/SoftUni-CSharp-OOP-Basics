using System;
using System.Collections.Generic;
using System.Text;

public class StreetExtraordinaire : Cat
{
    private int decibelsOfMeows;


    public StreetExtraordinaire()
    {
    }
    public StreetExtraordinaire(int decibelsOfMeows)
    {
        this.DecibelsOfMeows = decibelsOfMeows;
    }


    public int DecibelsOfMeows
    {
        get { return decibelsOfMeows; }
        set { decibelsOfMeows = value; }
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.DecibelsOfMeows}";
    }
}

