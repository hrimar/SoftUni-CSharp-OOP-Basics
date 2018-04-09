using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()  // 100/100
    {
        var numbers = Console.ReadLine().Split();
        var webAddresses = Console.ReadLine().Split();


        Smartphone smartphone = new Smartphone();
        foreach (var number in numbers)
        {
            Console.WriteLine(smartphone.Calling(number));
        }

        foreach (var webSite in webAddresses)
        {
            Console.WriteLine(smartphone.Browsing(webSite));
        }

    }
}

