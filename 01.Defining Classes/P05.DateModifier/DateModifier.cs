using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public class DateModifier
{


    public double CalcDiference(string startDate, string endDate)
    {
        var startParams = startDate.Split();
        var startYear = int.Parse(startParams[0]);
        var startMonth = int.Parse(startParams[1]);
        var startDay = int.Parse(startParams[2]);

        var endParams = endDate.Split();
        var endYear = int.Parse(endParams[0]);
        var endMonth = int.Parse(endParams[1]);
        var endDay = int.Parse(endParams[2]);

        DateTime start = new DateTime(startYear, startMonth, startDay);
        DateTime end = new DateTime(endYear, endMonth, endDay);

        TimeSpan dif = (end - start);

        return Math.Abs(dif.TotalDays);
    }

}

