using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IPerson, IResident
{
    public Citizen(string name, string country, int age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }

     string IResident.Name { get; }

    public string Country { get; private set; }

    public string Name { get; private set; }

    public int Age { get; private set; }

     string IResident.GetName()
    {
        return this.Name;
    }

    string IPerson.GetName()
    {
       return "Mr/Ms/Mrs";
    }
}

