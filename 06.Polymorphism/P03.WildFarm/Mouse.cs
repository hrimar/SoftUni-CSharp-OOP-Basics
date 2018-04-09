using System;
using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
               : base(name, weight, livingRegion)
    {
    }

    public override string AskForFood()
    {
        return "Squeak";
    }

    //public override void Eating(int quantity)
    //{
    //    this.FoodEaten += quantity;
    //    this.Weight += quantity * 0.1;
    //}

    //public override string ToString()
    //{
    //    return base.ToString() + $"[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    //}


    protected override double WeightIncreaseMultiplier => 0.10;

    protected override Type[] PreferredFoods => new Type[] { typeof(Fruit), typeof(Vegetable) };
       
    //public override void Eating(int quantity)
    //{
    //    this.FoodEaten += quantity;
    //    this.Weight += quantity * 0.4;
    //}

    public override string ToString()
    {
        // return base.ToString() + $"[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        string fromBase = base.ToString();
        string result = string.Format(fromBase, string.Empty); // string.Format намира в този стринг къде има холдъри и слага подадените неща;

        return result;
    }
}

