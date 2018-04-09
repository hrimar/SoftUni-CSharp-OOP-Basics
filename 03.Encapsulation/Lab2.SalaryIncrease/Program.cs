using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        var persons = new List<Person>();

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
            persons.Add(person);
        }
        var persentage = decimal.Parse(Console.ReadLine());

        persons.ToList()
            .ForEach(p =>
            {
                p.IncreaseSalary(persentage);
                Console.WriteLine(p);
            });

    }
}

