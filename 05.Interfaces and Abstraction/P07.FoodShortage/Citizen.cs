using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : ICitizen, IPerson, IBirthDay
{

    public string Name { get; private set; }

    public int Age { get; private set; }

    public string IdGroup { get; private set; }

    public DateTime BirthDate { get; private set; }

    public Citizen(string name, int age, string id, DateTime birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.IdGroup = id;
        this.BirthDate = birthDate;
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
        this.Food += 10;
    }
}

