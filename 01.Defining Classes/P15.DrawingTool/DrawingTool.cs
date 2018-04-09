using System;
using System.Collections.Generic;
using System.Text;

public class DrawingTool
{
    private string figure;

    public string Figure
    {
        get { return figure; }
        set { figure = value; }
    }

    public DrawingTool(string figure)
    {
        switch (figure)
        {
            case "Square":          
                var size = int.Parse(Console.ReadLine());
                var square = new Square();
                square.Draw(size);
                break;

            case "Rectangle":
                var horizontal = int.Parse(Console.ReadLine());
                var vertical = int.Parse(Console.ReadLine());
                var rectangle = new Rectangle();
                rectangle.Draw(horizontal, vertical);
                break;
        }
    }


}

