using System;

class OldestFamilyMember
{
    static void Main()  // 100/100
    {
        Family family = new Family();
        int n = int.Parse(Console.ReadLine());

       
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = input[0];
            int age = int.Parse(input[1]);

            var person = new Person(name, age);

            
            family.AddMember(person);
        }

        Console.WriteLine(family.GetOldestMember());
    }
}

