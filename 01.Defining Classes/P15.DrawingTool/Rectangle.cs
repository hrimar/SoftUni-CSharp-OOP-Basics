using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Draw(int x, int y)
    {
        for (int i = 0; i < y; i++)
        {
            if (i == 0 || i == y - 1)
            {
                Console.WriteLine($"|{new string('-', x)}|");
            }
            else
            {
                Console.WriteLine($"|{new string(' ', x)}|");
            }
        }
    }
}

