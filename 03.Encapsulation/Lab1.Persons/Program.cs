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
            var person = new Person(input[0], input[1], int.Parse(input[2]));
            persons.Add(person);
        }
        persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p));
    }
}

