using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() // 100/100
    {
        //var persons = new List<Person>(); // var 2
        var team = new Team("Team");

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split();
            try
            {
                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                //persons.Add(person);
                team.AddPlayer(person);
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

       // var team = new Team("Team");      //  var 2.
        //foreach (var person in persons)
        //{
        //    team.AddPlayer(person);
        //}             

      Console.WriteLine(team);
    }
}

