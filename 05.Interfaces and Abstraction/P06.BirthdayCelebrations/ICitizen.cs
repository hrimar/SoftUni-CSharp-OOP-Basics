using System;
using System.Collections.Generic;
using System.Text;

public interface ICitizen : IBase, IBirthDay
{
    string Id { get; }
    int Age { get; }    
}

