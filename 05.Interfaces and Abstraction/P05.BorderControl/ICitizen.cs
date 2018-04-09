using System;
using System.Collections.Generic;
using System.Text;

public interface ICitizen : IPerson
{
    string Name { get; }
    int Age { get; }

}

