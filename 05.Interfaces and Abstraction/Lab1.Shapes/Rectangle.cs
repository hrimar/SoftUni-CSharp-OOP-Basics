using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : IDrawable
{   
    public int Width { get; private set; }  // !!!

    public int Height { get; private set; }   // !!!

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public void Draw()
    {
        //Console.WriteLine(new string('*', 4));
        //for (int i = 0; i < 5 - 2; i++)
        //{
        //    Console.Write('*');
        //    Console.Write(new string(' ', 4 - 2));
        //    Console.WriteLine('*');
        //}
        //Console.WriteLine(new string('*', 4));

        // Var.2:
        DrawLine(this.Width, '*', '*');
        for (int i = 1; i < this.Height - 1; i++)
        {
            DrawLine(this.Width, '*', ' ');
        }
        DrawLine(this.Width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < width-1; i++)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
}

