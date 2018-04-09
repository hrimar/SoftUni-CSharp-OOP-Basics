using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
    {       
    }

    protected override double WeightIncreaseMultiplier => 0.30;

    protected override Type[] PreferredFoods => new Type[] { typeof(Meat), typeof(Vegetable) };

    public override string AskForFood()
    {
        return "Meow";
    }

    //public override void Eating(int quantity)
    //{
    //    this.FoodEaten += quantity;
    //    this.Weight += quantity*0.3;
    //}

    //public override string ToString()
    //{
    //    return base.ToString() + $"[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    //}
}

