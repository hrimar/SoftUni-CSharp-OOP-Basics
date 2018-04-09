using System;
using System.Collections.Generic;
using System.Linq;

class RectangleIntersection
{
    static void Main()  //   100/100
    {
        var rectangles = new List<Rectangle>();
        
        var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var countOfRectangulers = input[0];
        var countOfChecks = input[1];

        for (int i = 0; i < countOfRectangulers; i++)
        {
            var rectangleDetails = Console.ReadLine().Split();
            var id = rectangleDetails[0];
            double width = double.Parse(rectangleDetails[1]);
            double height = double.Parse(rectangleDetails[2]);
            double horizontalTopLeft = double.Parse(rectangleDetails[3]);
            double verticalTopLeft = double.Parse(rectangleDetails[4]);

            var rectangle = new Rectangle()
            {
                Id = id,
                Width = width,
                Height = height,
                HorizontalTopLeft = horizontalTopLeft,
                VerticalTopLeft = verticalTopLeft
            };
            rectangles.Add(rectangle);
        }

        
        for (int i = 0; i < countOfChecks; i++)
        {
            var checks = Console.ReadLine().Split();

            var firstName = checks[0];
            var first = rectangles.FirstOrDefault(r => r.Id == firstName);
            var secondName = checks[1];
            var second = rectangles.FirstOrDefault(r => r.Id == secondName);

            Console.WriteLine(first.CheckIntersect(second).ToString().ToLower());
        }
    }
}

