using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pizza
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 15;
    private const int MIN_TOPPINGS = 0;
    private const int MAX_TOPPINGS = 10;


    private string name;
    private Dough dough;
    private List<Topping> toppings;


    public Pizza()
    {
        this.Toppings = new List<Topping>();
    }
    public Pizza(string name) : this()
    {
        this.Name = name;
    }


    private double ToppingCalories      // какл проп за смятане на калориите!
    {
        get
        {
            if (this.Toppings.Count == 0)
            {
                return 0;
            }
            return this.Toppings.Select(t => t.Calories).Sum();
        }
    }
    private double Calories => this.Dough.Calories + this.ToppingCalories;


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > MAX_WEIGHT)
            {
                throw new ArgumentException($"Pizza name should be between {MIN_WEIGHT} and {MAX_WEIGHT} symbols.");
            }
            name = value;
        }
    }
    private Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }
    private List<Topping> Toppings
    {
        get { return toppings; }
        set { toppings = value; }
    }


    public void SetDough(Dough dough)
    {
        if (this.Dough != null)
        {
            throw new InvalidOperationException("Dough alreasy set!");
        }
        this.Dough = dough;
    }

    public void AddTopping(Topping topping)
    {
        this.Toppings.Add(topping);
        if (this.toppings.Count > MAX_TOPPINGS)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS}..{MAX_TOPPINGS}].");
        }
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Calories:f2} Calories.";
    }
}

