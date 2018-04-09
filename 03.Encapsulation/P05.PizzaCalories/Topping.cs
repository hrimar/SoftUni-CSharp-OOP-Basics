using System;
using System.Collections.Generic;
using System.Linq;

public class Topping
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 50;
    private const int DEFAULT_MULTIPLIER = 2;

    private Dictionary<string, double> validTypes = new Dictionary<string, double>()
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9
    };

    private string type;
    private double weight;



    private double TypeMutiplier => validTypes[type];

    public double Calories => DEFAULT_MULTIPLIER * this.Weight *  TypeMutiplier;  // !!!
    // т.е не правим метод за смятане на калории а публ. проп.!


    public Topping(string type, double weight)
    {
        this.Type = type;
        ValidateWeight(type, weight); // т.е. и в коструктора може да се валидира и имаме достъп до всички проп-та
        this.Weight = weight;

    }

   
    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Type
    {
        get { return type; }
        set
        {
            if(!this.validTypes.Any(t=>t.Key==value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value.ToLower();
        }
    }

    private void ValidateWeight(string type, double weight)
    {
        if (weight < MIN_WEIGHT || weight > MAX_WEIGHT)
        {
            throw new ArgumentException($"{type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
        }
    }
}