using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()      //  100/100
    {
        var persons = new List<Person>();
        var products = new List<Product>();

        var separators = ",.; \t".ToCharArray();
        var inputPerson = Console.ReadLine().Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var inputProduct = Console.ReadLine().Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        try
        {
            AddPerson(persons, inputPerson);

            AddProduct(products, inputProduct);

            BuyProducts(persons, products);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }

        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }
    }

    private static void BuyProducts(List<Person> persons, List<Product> products)
    {
        string inputProducts;
        while ((inputProducts = Console.ReadLine()) != "END")
        {
            var nameProduct = inputProducts.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = nameProduct[0];
            string product = nameProduct[1];

            Person targetPerson = persons.FirstOrDefault(p => p.Name == name);
            Product targetProduct = products.FirstOrDefault(p => p.Name == product);

            string output = targetPerson.TryByProduct(targetProduct);
            Console.WriteLine(output);
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

            var person = new Person(name, money);
            persons.Add(person);
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

            var product = new Product(name, cost);
            products.Add(product);
        }
    }
}

