﻿using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private int age;
    private string name;


    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }

    public Person(int age) : this()
    {
        this.Age = age;
    }

    public Person(string name, int age)
    {
        this.Age = age;
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Age}";
    }
}

