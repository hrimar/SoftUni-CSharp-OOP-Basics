using System;
using System.Collections.Generic;
using System.Text;

public class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        private set
        {
            //if (value<=0)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(radius), "Radius can not be negativ ot zero");
            //}
            radius = value;
        }
    }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2.0 * Math.PI * this.Radius;
    }

    public override string Draw()
    {
        return base.Draw() + $"{this.GetType()}";    //!!!
    }
}

