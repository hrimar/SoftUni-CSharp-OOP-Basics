using System;
using System.Collections.Generic;
using System.Text;

public class AddRemoveCollection : AddCollection, ICollection, IAddable, IRemoveble
{
    //public List<string> Collection { get; private set; }

    public AddRemoveCollection() : base()
    {
       // this.Collection = new List<string>();
    }

    public override int Add(string element)
    {
        this.Collection.Insert(0, element);
        return 0;
    }

    public virtual string Remove()
    {
        if (this.Collection.Count == 0)
        {
            throw new ArgumentException("Empty collection!");
        }
        var indexToRemove = this.Collection.Count - 1;
        var elementToRemove = this.Collection[indexToRemove];
        this.Collection.RemoveAt(indexToRemove);
        return elementToRemove;

    }
}

