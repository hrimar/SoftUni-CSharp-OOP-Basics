using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : IPerson
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public string IdGroup { get; private set; }

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.IdGroup = group;
    }

    private int food = 0;
    public int Food
    {
        get
        {
            return this.food;
        }
        private set
        {
            this.food = value;
        }
    }
        

    public void BuyFood()
    {
        this.Food += 5;
    }
}

