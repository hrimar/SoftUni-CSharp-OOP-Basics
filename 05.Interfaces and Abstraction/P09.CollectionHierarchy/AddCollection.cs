using System;
using System.Collections.Generic;
using System.Text;

public class AddCollection : ICollection, IAddable
{
    public List<string> Collection { get; private set; }

    public AddCollection()
    {
        this.Collection =new List<string>();        
    }
   
    public virtual int Add(string item)
    {
        this.Collection.Add(item);
        return this.Collection.Count - 1;
    }
}

