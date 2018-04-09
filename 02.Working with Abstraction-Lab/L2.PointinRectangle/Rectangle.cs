using System;
using System.Collections.Generic;
using System.Linq;

public class Rectangle
{
    public Point TopLeft { get; set; }

    public Point BottomRight { get; set; }

    public Rectangle(int topX, int topY, int botomX, int bottomY)
    {
        TopLeft = new Point(topX, topY);
        BottomRight = new Point(botomX, bottomY);
    }
    public Rectangle(int[] coords) : this(coords[0], coords[1], coords[2], coords[3])
    {

    }
    public Rectangle(string coordsLine) : this(coordsLine.Split().Select(int.Parse).ToArray())
    {

    }
    // or
    //public Rectangle(string coordsLine)
    //{
    //    var coords = coordsLine.Split().Select(int.Parse).ToList();
    //    TopLeft = new Point(coords[0], coords[1]);
    //    BottomRight = new Point(coords[2], coords[3]);
    //}


    public bool Contains(Point point)
    {
        bool contains =
            point.X >= TopLeft.X && point.X <= BottomRight.X &&
            point.Y >= TopLeft.Y && point.Y <= BottomRight.Y;

        return contains;
    }
}

