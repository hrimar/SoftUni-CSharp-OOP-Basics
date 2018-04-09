using System;


class DefineClassPerson
{
    static void Main()
    {
        // 100/100

        var person = new Person()
        {
            Age = 20,
            Name = "Pesho"
        };

        var personGosho = new Person();
        personGosho.Name = "Gosho";
        personGosho.Age = 18;

        var personStamat = new Person("Stamat", 43);
    }
}

