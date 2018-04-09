using System;
using System.Collections.Generic;
using System.Linq;

class CatLady
{
    static void Main()  // 100/100
    {
        var cats = new List<Cat>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputDetails = input.Split();
            var breed = inputDetails[0];
            string name = inputDetails[1];

            switch (breed)
            {
                case "Siamese":                   
                    var earSize = int.Parse(inputDetails[2]);
                    var siamese = new Siamese(earSize);
                    siamese.Name = name;
                    siamese.Breed = breed;
                    cats.Add(siamese); // защото и тя е подклас на Cat

                    break;
                case "Cymric":
                    var furLength = double.Parse(inputDetails[2]);
                    var cymric = new Cymric(furLength);
                    cymric.Name = name;
                    cymric.Breed = breed;
                    cats.Add(cymric);

                    break;
                case "StreetExtraordinaire":
                    var decibel = int.Parse(inputDetails[2]);
                    var street = new StreetExtraordinaire(decibel);
                    street.Name = name;
                    street.Breed = breed;
                    cats.Add(street);
                    break;
            }
        }
        var surchedCat = Console.ReadLine();
         Cat faundedCat = cats.FirstOrDefault(c => c.Name == surchedCat);
        
        Console.WriteLine(faundedCat.ToString());
    }
}

