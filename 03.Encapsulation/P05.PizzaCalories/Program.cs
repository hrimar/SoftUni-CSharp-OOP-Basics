using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()  // 100/100 - Виж и другото решение!!! 
    {
        try
        {
            string pizzaName = Console.ReadLine().Split()[1];
            Pizza pizza = new Pizza(pizzaName);

            string[] doughInput = Console.ReadLine().Split();

            string flourType = doughInput[1];
            string bakingTechnique = doughInput[2];
            double doughWeight = double.Parse(doughInput[3]);

            Dough dough = new Dough(flourType, bakingTechnique, doughWeight);

            pizza.SetDough(dough);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] toppingInput = command.Split();
                string toppingType = toppingInput[1];
                double toppingWeigh = double.Parse(toppingInput[2]);

                Topping topping = new Topping(toppingType, toppingWeigh);
                pizza.AddTopping(topping);
            }

            Console.WriteLine(pizza);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

