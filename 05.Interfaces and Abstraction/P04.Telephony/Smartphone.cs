using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : ICalling, IBrowsable
{
  
    public string Number { get; private set; }

    public string WebSite { get; private set; }


    public string Browsing(string webSite)
    {
        if (webSite.Any(n => char.IsDigit(n)))
        {
            return ("Invalid URL!");
        }

        return $"Browsing: {webSite}!";
    }

    public string Calling(string number)
    {
        if (number.All(n => char.IsDigit(n)))
        {
            return $"Calling... {number}";
        }

        return ("Invalid number!");
    }
}

