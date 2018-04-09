using System;
using System.Collections.Generic;
using System.Text;

public abstract class Unit
    {
    private string id;

    protected Unit(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get { return id; }
        protected set { id = value; }
    }
}

