using System;

class Program
{
    static void Main()  // 100/100
    {      
        // Виж и старото решение от 01.Def Classes - P13!
        string mainPersonInput = Console.ReadLine();

        FamilyTreeBuilder familyTreeBuilder = new FamilyTreeBuilder(mainPersonInput);

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            ParseInput(input, familyTreeBuilder);
        }

        string familiTree = familyTreeBuilder.Build();
        Console.WriteLine(familiTree);
    }

   
    private static void ParseInput(string input, FamilyTreeBuilder familyTreeBuilder)
    {
        string[] tokens = input.Split(" - ");
        if (tokens.Length > 1)
        {
            string parentInput = tokens[0];
            string childInput = tokens[1];
           familyTreeBuilder.SetParentChildRepation(parentInput, childInput);
        }
        else
        {
            tokens = tokens[0].Split();
            string name = $"{tokens[0]} {tokens[1]}";
            string birthday = tokens[2];

            familyTreeBuilder.SetFullInfo(name, birthday);
        }
    }
    
}

