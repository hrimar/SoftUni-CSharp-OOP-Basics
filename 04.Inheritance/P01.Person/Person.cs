﻿using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private const int MIN_NAMELENGTH = 3;

    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException($"Name's length should not be less than {MIN_NAMELENGTH} symbols!");
            }
            name = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

        return sb.ToString();
    }
}

