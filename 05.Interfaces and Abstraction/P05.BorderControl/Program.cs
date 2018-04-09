using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IPerson> population = new List<IPerson>();

        // 1. Read Input:
        string input;
        while ((input = Console.ReadLine()) !="End")
        {
            var inputDetails = input.Split();
            IPerson person = null;
            if (inputDetails.Length==3)
            {
                var name = inputDetails[0];
                int age = int.Parse(inputDetails[1]);
                string id = inputDetails[2];
                person = new Citizen(name, age, id);
            }
            else if (inputDetails.Length == 2)
            {
                var model = inputDetails[0];               
                string id = inputDetails[1];
                person = new Robot(model, id);
            }
            population.Add(person);
        }

        // 2. Surch:
        string surchedNumber = Console.ReadLine();
        foreach (var person in population)
        {
            if(person.Id.EndsWith(surchedNumber))
            {
                Console.WriteLine(person.Id);
            }
        }
    }
}

