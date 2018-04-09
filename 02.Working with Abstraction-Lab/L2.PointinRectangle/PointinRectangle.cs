using System;
using System.Linq;

class PointinRectangle
{
    static void Main()
    {
        // Разгледай пак двете решения!!!:

        //var coords = Console.ReadLine().Split().Select(int.Parse).ToList();
        //var rectangle = new Rectangle(coords[0], coords[1], coords[2], coords[3]);
        // or       
        var rectangle = new Rectangle(Console.ReadLine()); 

        var pointsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < pointsCount; i++)
        {
            //var pointCoords = Console.ReadLine().Split().Select(int.Parse).ToList();
            //var point = new Point(pointCoords[0], pointCoords[1]);
            // or
            var point = new Point(Console.ReadLine);

            var containsPoint = rectangle.Contains(point);
            Console.WriteLine(containsPoint);
        }

    }
}

