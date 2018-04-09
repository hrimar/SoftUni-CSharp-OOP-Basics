using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double horizontalTopLeft;
    private double verticalTopLeft;
    

    //public Rectangle(string id, int width, int height, int horizontalTopLeft, int verticalTopLeft)
    //{
    //    this.Id = id;
    //    this.Width = width;
    //    this.Height = height;
    //    this.HorizontalTopLeft = horizontalTopLeft;
    //    this.VerticalTopLeft = verticalTopLeft;
    //}

    public double VerticalTopLeft
    {
        get { return verticalTopLeft; }
        set { verticalTopLeft = value; }
    }

    public double HorizontalTopLeft
    {
        get { return horizontalTopLeft; }
        set { horizontalTopLeft = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public bool CheckIntersect(Rectangle second)
    {
        if (this.horizontalTopLeft > second.horizontalTopLeft + second.width || 
            second.horizontalTopLeft > this.horizontalTopLeft + this.width)
        {
            return false;
        }

        if (this.verticalTopLeft < second.verticalTopLeft - this.height ||
            second.verticalTopLeft < this.verticalTopLeft - this.height)
        {
            return false;
        }
        return true;
    }
}

