using System;
using System.Collections.Generic;
using System.Text;

public class Hen : Bird
{   
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    protected override double WeightIncreaseMultiplier => 0.35;

    protected override Type[] PreferredFoods => new Type[] { typeof(Meat), typeof(Vegetable), typeof(Fruit), typeof(Seeds) };

    public override string AskForFood()
    {
        return "Cluck";
    }

    //public override void Eating(int quantity)
    //{
    //    this.FoodEaten += quantity;
    //    this.Weight += quantity * 0.35;
    //}


    //public override string ToString()
    //{
    //    return base.ToString() + $"[{this.Name}, {WingSize}, {this.Weight}, {this.FoodEaten}]";
    //}
}
