using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private string birthday;
    private List<Person> children;
    private List<Person> parents;

    public Person()
    {
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }

    public Person(string name) : this()
    {
        this.Name = name;
    }


    public List<Person> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Person> Children
    {
        get { return children; }
        set { children = value; }
    }

    public string Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Birthday}";
    }
}

