using System;
using System.Globalization;

class StartUpDateModifier
{
    static void Main()
    {
        // 100/100
        string startDate = Console.ReadLine();
        
        var endDate = Console.ReadLine();
      
        
        var dif = new DateModifier();
        var result =dif.CalcDiference(startDate, endDate);

        Console.WriteLine(result);
    }
}

