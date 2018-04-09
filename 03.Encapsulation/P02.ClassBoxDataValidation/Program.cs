using System;

public class Program
{
    static void Main()  // 100/100
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
                var box = new Box(length, width, height);
         
            Console.WriteLine($"Surface Area - {box.CalcSurface(length, width, height):f2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalcLiyteralSurface(length, width, height):f2}");
            Console.WriteLine($"Volume - {box.CalcVolume(length, width, height):f2}");
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
   

    }
}

