using System;
using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> family;

    // ctor
    public Family()
    {
        this.family = new List<Person>();
    }

    //// prop:
    //public List<Person> Faminy
    //{
    //    get { return this.family; }
    //    set { this.family = new List<Person>(); }
    //}

    public void AddMember(Person member)
    {
        this.family.Add(member);
    }

    public Person GetOldestMember()
    {
        var oldesMember = family.OrderByDescending(a => a.Age).FirstOrDefault();

        return oldesMember;
    }

    public override string ToString()
    {
        return $"{this.family}";
    }
}

