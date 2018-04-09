using System;
using System.Collections.Generic;
using System.Text;

public interface IListable : ICollection, IAddable, IRemoveble
{
    int Used { get; }
}

