using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        List<IBirthDay> population = new List<IBirthDay>();

        // 1. Read Input:
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
           // IBirthDay person = null;
            var inputDetails = input.Split();
            var type = inputDetails[0];
            string name;
            string id;
            DateTime birthDay;

            switch (type)
            {
                case "Citizen":
                    name = inputDetails[1];
                    int age = int.Parse(inputDetails[2]);
                    id = inputDetails[3];
                    birthDay = DateTime.ParseExact(inputDetails[4], "d/MM/yyyy", CultureInfo.InvariantCulture);
                   IBirthDay  person = new Citizen(name, age, id, birthDay);
               population.Add(person);
                    break;
                case "Robot":
                    var model = inputDetails[1];
                     id = inputDetails[2];
                   // person = new Robot(model, id);
                    break;
                case "Pet":
                    name = inputDetails[1];
                    birthDay = DateTime.ParseExact(inputDetails[2], "d/MM/yyyy", CultureInfo.InvariantCulture);
                    person = new Pet(name, birthDay);
                    population.Add(person);
                    break;

            }
                 
            
        }

        // 2. Surch:
        int surchedYear = int.Parse(Console.ReadLine());
        if (population.Any(p=>p.BirthDate.Year == surchedYear))
        {
            foreach (var person in population)
            {
                if (person.BirthDate.Year == surchedYear)
                {
                    Console.WriteLine(person.BirthDate.ToString("dd/MM/yyy", CultureInfo.InvariantCulture));
                }
            }
        }
        //else
        //{
        //    Console.WriteLine("<empty output>");
        //}
        
    }
}

