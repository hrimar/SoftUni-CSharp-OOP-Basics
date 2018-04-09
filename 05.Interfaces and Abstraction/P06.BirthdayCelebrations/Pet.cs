using System;
using System.Collections.Generic;
using System.Text;

public class Pet : IPet, IBase, IBirthDay
{
    public string Name { get; private set; }

    public DateTime BirthDate { get; private set; }

    public Pet(string name, DateTime birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }
}

