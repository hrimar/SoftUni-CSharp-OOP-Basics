using System;
using System.Collections.Generic;
using System.Text;

public interface IRebel : IPerson, IBuyer
{
    string Group { get; }
}

