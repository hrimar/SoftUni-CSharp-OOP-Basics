using System;
using System.Collections.Generic;
using System.Linq;

class Google
{
    static void Main()  // Doobre 100/100 
        // Значи може родителите и децата да са си отделен клас, а не Person!!!
    {
        var result = new Dictionary<string, Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var info = input.Split();
            var name = info[0];


            if (!result.ContainsKey(name))
            {
                //Person person = new Person(name);- NO!
                result[name] = new Person(name);
            }
           

            if (info.Length == 5)
            {
                var companyName = info[2];
                var department = info[3];
                var salary = decimal.Parse(info[4]);
                var company = new Company(companyName, department, salary);
                result[name].Company = company;
            }
            else
            {
                switch (info[1])
                {
                    
                    case "car":
                        var model = info[2];
                        var speed = double.Parse(info[3]);
                        var car = new Car(model, speed);
                        result[name].Car = car;
                        break;

                    case "pokemon":
                        var pokemonName = info[2];
                        var type = info[3];
                        var pokemon = new Pokemon(pokemonName, type);
                        result[name].Pokemons.Add(pokemon);
                        break;

                    case "parents":
                        var parentName = info[2];
                        var parentBirthday = info[3];
                        var parent = new Parent(parentName, parentBirthday);
                        result[name].Parents.Add(parent);

                        break;
                    case "children":
                        var childrentName = info[2];
                        var childrentBirthday = info[3];
                        var childrent = new Child(childrentName, childrentBirthday);
                        result[name].Children.Add(childrent);

                        break;
                }
            }
          

        }
        var targetPerson = Console.ReadLine();
        
        Console.WriteLine(result[targetPerson]);
    }
}

