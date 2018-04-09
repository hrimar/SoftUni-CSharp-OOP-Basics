using System;
using System.Collections.Generic;
using System.Text;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {       
    }

    protected override double WeightIncreaseMultiplier => base.WeightIncreaseMultiplier;

    protected override Type[] PreferredFoods => new Type[] { typeof(Meat) };

    public override string AskForFood()
    {
        return "ROAR!!!";
    }

    //public override void Eating(int quantity)
    //{
    //    this.FoodEaten += quantity;
    //    this.Weight += quantity * 1.0;
    //}

    
}

