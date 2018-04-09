using System;
using System.Collections.Generic;
using System.Linq;

class OpinionPoll
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        var persons = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = input[0];
            int age = int.Parse(input[1]);

            var person = new Person(name, age);

            persons.Add(person);           
        }

        var sorderdPersons = persons.Where(p => p.Age > 30).OrderBy(p => p.Name);
        foreach (var item in sorderdPersons)
        {
            Console.WriteLine(item);
        }
    }
}
