using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = 0;
    }

    public string Name { get; set; }
    public double Weight { get; set; }
    public int FoodEaten { get; set; }

    public abstract string AskForFood();
    // public abstract void Eating(int quantity);

    protected virtual double WeightIncreaseMultiplier => 1;

    protected virtual Type[] PreferredFoods => new Type[] { typeof(Food) };
    // или
    //protected override Type[] PreferredFoods => new Type[] { typeof(Meat), typeof(Vegetable), typeof(Fruit), typeof(Seeds) };
    
    public void TryEatFood(Food food)
    {
        Type typeOfFood = food.GetType();
        if (!this.PreferredFoods.Contains(typeOfFood))
        {
            throw new InvalidOperationException($"{this.GetType().Name} does not eat {typeOfFood.Name}!");
        }

        this.FoodEaten += food.Quantity;
        this.Weight += food.Quantity * this.WeightIncreaseMultiplier;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, " + "{0}" + $"{this.Weight}, " + "{1}" + $"{this.FoodEaten}]";
    }
}

