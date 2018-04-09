using System;
using System.Collections.Generic;
using System.Text;

public class Tire
{
    private double preasure;
    private int age;

    public Tire()
    {
    }
    public Tire(double preasure, int age)
    {
        this.age = age;
        this.Preasure = preasure;
    }


    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    public double Preasure
    {
        get { return preasure; }
        set { preasure = value; }
    }

}

