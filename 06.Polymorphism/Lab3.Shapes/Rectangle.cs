using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width), "Width can not be negativ ot zero");
            }
            width = value;
        }
    }

    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "Height can not be negativ ot zero");
            }
            height = value;
        }
    }
    

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public override double CalculateArea()
    {
        var result = this.Width * this.Height;
        return result;
    }

    public override double CalculatePerimeter()
    {
        var result = (this.Width + this.Height) * 2;
        return result;
    }

    public override string Draw()
    {
        return base.Draw() + $"{this.GetType().Name}";  // !!!
    }
}

