using System;

namespace P10.ExplicitInterfaces
{
    class Program
    {
        static void Main()  // 100/100
        {
            string input;
            while ((input=Console.ReadLine()) != "End")
            {
                var inputDetails = input.Split();
                var personName = inputDetails[0];
                var country = inputDetails[1];
                var age = int.Parse(inputDetails[2]);
                var citizen = new Citizen(personName, country, age);
                var citizenPerson = (IPerson)citizen;
                var citizenResident = (IResident)citizen;
                Console.WriteLine(citizenPerson.Name);
                Console.WriteLine(citizenPerson.GetName() +' '+citizenResident.GetName());
            }
        }
    }
}
