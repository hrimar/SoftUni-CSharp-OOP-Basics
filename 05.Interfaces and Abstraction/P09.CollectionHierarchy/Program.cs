using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program // баси шугавата задача... 100/100
{
    static void Main()
    {
        var elementsToAdd = Console.ReadLine().Split();
        var numberOfRemoveOperations = int.Parse(Console.ReadLine());

        var addCollection = new AddCollection();
        var addRemoveCollection = new AddRemoveCollection();
        var myCollection = new MyList();

        var builder = new StringBuilder();

        AddElementsToCollection(builder, elementsToAdd, addCollection);
        AddElementsToCollection(builder, elementsToAdd, addRemoveCollection);
        AddElementsToCollection(builder, elementsToAdd, myCollection);

        RemoveElementsFromCollection(builder, numberOfRemoveOperations, addRemoveCollection);
        RemoveElementsFromCollection(builder, numberOfRemoveOperations, myCollection);

        Console.WriteLine(builder.ToString().Trim());
    }

    private static void RemoveElementsFromCollection(StringBuilder builder, int numberOfRemoveOperations, IRemoveble collection)
    {
        for (int i = 0; i < numberOfRemoveOperations; i++)
        {
            builder.Append(collection.Remove())
                   .Append(' ');
        }
        builder.AppendLine();
    }

    private static void AddElementsToCollection(StringBuilder builder, string[] elementsToAdd, IAddable collection)
    {
        foreach (var element in elementsToAdd)
        {
            builder.Append(collection.Add(element))
                   .Append(' ');
        }
        builder.AppendLine();
    }
}

