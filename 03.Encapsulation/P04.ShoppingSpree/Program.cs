using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()      // 100/100
    {
        var persons = new List<Person>();
        var products = new List<Product>();

        var separators = ",.; \t".ToCharArray();
        var inputPerson = Console.ReadLine().Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        AddPerson(persons, inputPerson);

        var inputProduct = Console.ReadLine().Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        AddProduct(products, inputProduct);

        string inputProducts;
        while ((inputProducts = Console.ReadLine()) != "END")
        {
            var nameProduct = inputProducts.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = nameProduct[0];
            string product = nameProduct[1];

            Person targetPerson = persons.FirstOrDefault(p => p.Name == name);
            Product targetProduct = products.FirstOrDefault(p => p.Name == product);

            if (targetPerson.Money >= targetProduct.Cost)
            {
                targetPerson.ProductsBag.Add(targetProduct);
                targetPerson.Money -= targetProduct.Cost;
                Console.WriteLine($"{targetPerson.Name} bought {targetProduct.Name}");
            }
            else
            {
                Console.WriteLine($"{targetPerson.Name} can't afford {targetProduct.Name}");
            }
        }

        foreach (var person in persons)
        {
            var sb = new StringBuilder();
            Console.Write(person.Name);
            Console.Write(" - ");//+string.Join(", ", person.ProductsBag)

            if (person.ProductsBag.Count() == 0)
            {
                Console.WriteLine("Nothing bought");
            }
            else
            {
                foreach (var bag in person.ProductsBag)
                {
                    //Console.Write(string.Join(", ", bag.Name));
                    // Console.Write($"{bag.Name}, ");

                    sb.Append(bag.Name);
                    sb.Append(", ");
                }
                string res = sb.ToString().TrimEnd(' ').TrimEnd(',');

                Console.WriteLine(res);
            }

        }
    }

    private static void AddPerson(List<Person> persons, string[] input)
    {
        for (int j = 0; j < input.Length; j++)
        {
            if (string.IsNullOrWhiteSpace(input[j]))
            {
                continue;
            }
            var nameMoney = input[j].Split('=');
            string name = nameMoney[0];
            decimal money = decimal.Parse(nameMoney[1]);
            try
            {
                var person = new Person(name, money);
                persons.Add(person);
            }
            catch (ArgumentException e) // да е само един try-catch!!! и с тази грешка, която сме дали в класа
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }
    private static void AddProduct(List<Product> products, string[] input)
    {
        for (int j = 0; j < input.Length; j++)
        {
            if (string.IsNullOrWhiteSpace(input[j]))
            {
                continue;
            }
            var nameMoney = input[j].Split('=');
            string name = nameMoney[0];
            decimal cost = decimal.Parse(nameMoney[1]);
            try
            {
                var product = new Product(name, cost);
                products.Add(product);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
    }
}

