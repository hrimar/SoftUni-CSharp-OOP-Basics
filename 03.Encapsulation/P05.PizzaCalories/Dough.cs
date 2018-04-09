using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dough
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 200;
    private const int DEFAULT_MULTIPLIER = 2;


    // може и с Enum за всеки тип тесто и техника или вместо enum - Dictionaries<тип, ст-ст>:
    private Dictionary<string, double> validFlourTypes = new Dictionary<string, double>()
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0
    };


    private Dictionary<string, double> validBakingTechniques = new Dictionary<string, double>()
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0
    };

    private double weight;
    private string flourType;
    private string bakingTechnique;


    private double FlourMultiplier => validFlourTypes[this.FlourType];  //

    private double BackingTechniqueMultiplier => validBakingTechniques[this.bakingTechnique];   //

    public double Calories => DEFAULT_MULTIPLIER * this.Weight * FlourMultiplier * BackingTechniqueMultiplier;  // !!!



    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BackingTechnique = bakingTechnique;
        this.Weight = weight;
    }


    public double Weight
    {
        get { return weight; }
        set
        {
            if (value <MIN_WEIGHT || value>MAX_WEIGHT)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }
    public string FlourType
    {
        get { return flourType; }
        set
        {
            ValidateTypes(value, validFlourTypes);
            // or
            //if (!this.validFlourTypes.Any(f => f.Key == value.ToLower()))
            //{
            //    throw new ArgumentException("Invalid type of dough.");
            //}
            flourType = value.ToLower();
        }
    }
    public string BackingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            ValidateTypes(value, validBakingTechniques);
            // or
            //if (!this.validBakingTechniques.Any(f => f.Key == value.ToLower()))
            //{
            //    throw new ArgumentException("Invalid type of dough.");
            //}
            bakingTechnique = value.ToLower();
        }
    }



    private static void ValidateTypes(string type, Dictionary<string, double> dictionary)
    {
       // type = type.ToLower();
        if (!dictionary.Any(f => f.Key == type.ToLower()))
        {
            throw new ArgumentException("Invalid type of dough.");
        }
    }




    public void CalcCalories()
    {

    }
}

