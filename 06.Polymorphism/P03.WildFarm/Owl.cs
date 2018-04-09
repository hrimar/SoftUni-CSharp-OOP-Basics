using System;
using System.Collections.Generic;
using System.Text;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize)
               : base(name, weight, wingSize)
    {
    }

    protected override double WeightIncreaseMultiplier => 0.25;

    protected override Type[] PreferredFoods => new Type[] { typeof(Meat) };

    public override string AskForFood()
    {
        return "Hoot Hoot";
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    //public override void Eating(int quantity)
    //{
    //    this.FoodEaten += quantity;
    //    this.Weight += quantity* 0.25;
    //}

    //public override string ToString()
    //{
    //    return base.ToString()+$"[{this.Name}, {WingSize}, {this.Weight}, {this.FoodEaten}]";
    //}
}

