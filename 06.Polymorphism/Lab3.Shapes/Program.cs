using System;

class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(3.0, 4.0);
        Shape circle = new Circle(4.0);

        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(circle.CalculateArea());

        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(circle.CalculatePerimeter());

        Console.WriteLine(rectangle.Draw());
        Console.WriteLine(circle.Draw());
    }
}

