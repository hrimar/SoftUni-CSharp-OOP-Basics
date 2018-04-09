using System;
using System.Collections.Generic;
using System.Text;

public class Cat
{
    private string name;
    private string breed;

    public Cat()
    {
    }
    public Cat(string name, string breed)
    {
        this.Name = name;
        this.Breed = breed;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

   
}



