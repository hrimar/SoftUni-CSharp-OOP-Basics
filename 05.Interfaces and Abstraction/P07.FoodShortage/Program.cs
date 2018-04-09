using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    static void Main()  // Super 100/100
    {
        HashSet<IPerson> peoples = new HashSet<IPerson>();

        int inputLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < inputLines; i++)
        {
            var input = Console.ReadLine().Split();

            IPerson person = null;
            if (input.Length == 4)
            {
                var name = input[0];
                int age = int.Parse(input[1]);
                string id = input[2];
                DateTime birthDay = DateTime.ParseExact(input[3], "d/MM/yyyy", CultureInfo.InvariantCulture);
                person = new Citizen(name, age, id, birthDay);
            }
            else if (input.Length == 3)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string group = input[2];
                person = new Rebel(name, age, group);
            }
            peoples.Add(person);
        }

        string inputName;
        while ((inputName = Console.ReadLine()) != "End")
        {
            var foundedPerson = peoples.Any(p => p.Name == inputName);
            if (foundedPerson)
            {
                var exactPerson = peoples.FirstOrDefault(p => p.Name == inputName);
                exactPerson.BuyFood();
            }
        }

        var totalFood = peoples.Sum(f => f.Food);
        Console.WriteLine(totalFood);
    }
}

