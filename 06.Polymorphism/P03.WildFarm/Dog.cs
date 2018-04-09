using System;
using System.Collections.Generic;
using System.Text;

public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) 
        : base(name, weight, livingRegion)
    {
    }

    protected override double WeightIncreaseMultiplier => 0.4;

    protected override Type[] PreferredFoods => new Type[] { typeof(Meat)};

    public override string AskForFood()
    {
        return "Woof!";
    }

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

