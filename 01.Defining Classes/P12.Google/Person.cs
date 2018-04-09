using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private Car car;
    private List<Parent> parents;
    private List<Child> children;
    private List<Pokemon> pokemons;

    // !!!
    public Person(string name)
    {
        this.Name = name;
        this.Parents = new List<Parent>();
        this.Children = new List<Child>();
        this.Pokemons = new List<Pokemon>();
    }
    //public Person(string name, Company company, Car car, List<Parent> parents, List<Child> children, List<Pokemon> pokemons)
    //{
    //    this.Name = name;
    //    this.CompanyOwned = company;
    //    this.CarOwned = car;
    //    this.Parents = parents;
    //    this.Children = children;
    //    this.Pokemons = pokemons;
    //}

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public List<Parent> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Child> Children
    {
        get { return children; }
        set { children = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{Name}");
        sb.AppendLine($"Company: ");
        if(Company!=null)
        sb.AppendLine($"{Company.Name} {Company.Department} {Company.Salary:f2}");
        sb.AppendLine($"Car: ");
        if(Car!=null)
        sb.AppendLine($"{Car.Model} {Car.Speed}");
        sb.AppendLine($"Pokemon: ");
        if (Pokemons != null)
        {
            foreach (var item in Pokemons)
            {
                sb.AppendLine($"{item.Name} {item.Type}");
            }
        }
        sb.AppendLine($"Parents: ");
        if (Parents != null)
        {
            foreach (var item in Parents)
            {
                sb.AppendLine($"{item.Name} {item.Birthday}");
            }
        }
        sb.AppendLine($"Children: ");
        if (Children != null)
        {
            foreach (var item in Children)
            {
                sb.AppendLine($"{item.Name} {item.Birthday}");
            }
        }
        string result = sb.ToString();
        return result;
    }
}

