using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double Height
    {
        get { return height; }       
    }

    public double Width
    {
        get { return width; }
      
    }

    public double Length
    {
        get { return length; }
     
    }

    public double CalcLiyteralSurface(double length, double width, double height )
    {
        return (2 * length * height) + (2 * width * height);
    }

    public double CalcVolume(double length, double width, double height)
    {
        return length * width * height;
    }

    public double CalcSurface(double length, double width, double height)
    {
        return (2 * length * width) + (2 * length * height) + (2 * width * height);
    }
}

