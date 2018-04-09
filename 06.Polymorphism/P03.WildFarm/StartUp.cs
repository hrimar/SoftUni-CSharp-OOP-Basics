using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var animals = new List<Animal>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            Animal animal = ParseAnimal(input);
            animals.Add(animal);

            var foodDetails = Console.ReadLine().Split();
            Food food = ParseFood(foodDetails);

            Console.WriteLine(animal.AskForFood());
            try
            {
                animal.TryEatFood(food);// !!!
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var a in animals)
        {
            Console.WriteLine(a.ToString());
        }        
    }

    private static Food ParseFood(string[] foodDetails)
    {
        var foodType = foodDetails[0];
        int foodQuantity = int.Parse(foodDetails[1]);

        Food food = null;

        switch (foodType)
        {
            case "Vegetable":
                food = new Vegetable(foodQuantity);
                break;
            case "Meat":
                food = new Meat(foodQuantity);
                break;
            case "Fruit":
                food = new Fruit(foodQuantity);
                break;
            case "Seeds":
                food = new Seeds(foodQuantity);
                break;
            default:
                throw new ArgumentException("Invalid food type!");
                // така ако с еподаде несъщ животно ще върне null, а това не добре да го вкарваме в кол-я
        }
        return food;
    }

    private static Animal ParseAnimal(string input)
    {
        var inputDetails = input.Split();
        var animalType = inputDetails[0];
        var animalName = inputDetails[1];
        double weight = double.Parse(inputDetails[2]);
        string region = inputDetails[3];

        Animal animal = null;

        switch (animalType)
        {
            case "Mouse":
                region = inputDetails[3];
                animal = new Mouse(animalName, weight, region);
                break;
            case "Dog":
                animal = new Dog(animalName, weight, region);
                break;
            case "Cat":
                string breed = inputDetails[4];
                animal = new Cat(animalName, weight, region, breed);
                break;
            case "Tiger":
                breed = inputDetails[4];
                animal = new Tiger(animalName, weight, region, breed);
                break;
            case "Owl":
                var owlWingSize = double.Parse(region);
                animal = new Owl(animalName, weight, owlWingSize);
                break;
            case "Hen":
                var wingSize = double.Parse(region);
                animal = new Hen(animalName, weight, wingSize);
                break;
            default:
                throw new ArgumentException("Invalid animal type!");
                // така ако с еподаде несъщ животно ще върне null, а това не добре да го вкарваме в кол-я
        }
        return animal;
    }
}

