using System;
using System.Collections.Generic;
using System.Text;

public class MyList : AddRemoveCollection, IListable, ICollection, IAddable, IRemoveble
{


    public MyList() : base()
    {
    }
    public int Used
    {
        get { return this.Collection.Count; }
    }

    public override string Remove()
    {
        if (this.Used == 0)
        {
            throw new ArgumentException("Empty collection!");
        }
        var indexToRemove = 0;
        var elementToRemove = this.Collection[indexToRemove];
        this.Collection.RemoveAt(indexToRemove);
        return elementToRemove;
    }
}

