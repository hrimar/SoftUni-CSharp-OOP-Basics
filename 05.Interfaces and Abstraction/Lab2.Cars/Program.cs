using System;

public class Program
{
    static void Main()
    {
        // 100/100 - и за двата варианта, но по-добре с наледяване и на класа и на интерфейсите1

        ICar seat = new Seat("Leon", "Grey");
        ICar tesla = new Tesla("Model 3", "Red", 2);

        Console.WriteLine(seat.ToString());
        Console.WriteLine(tesla.ToString());

    }
}

