using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FamilyTreeBuilder
{
    public List<Person> FamilyTree { get; set; }

    public Person MainPerson { get; set; }

    public FamilyTreeBuilder(string mainPerson)
    {
        FamilyTree = new List<Person>();
        MainPerson = Person.CreatePerson(mainPerson);
        FamilyTree.Add(MainPerson);
    }


    public string Build()
    {
        StringBuilder resultBuilder = new StringBuilder();

        resultBuilder.AppendLine(this.MainPerson.ToString());

        resultBuilder.AppendLine("Parents:");
        foreach (var parent in this.MainPerson.Parents)
        {
            resultBuilder.AppendLine(parent.ToString());
        }
        resultBuilder.AppendLine("Children:");
        foreach (var child in this.MainPerson.Children)
        {
            resultBuilder.AppendLine(child.ToString());
        }

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }



    public  void SetParentChildRepation(string parentInput, string childInput)
    {
        Person currentPerson = this.FamilyTree
            .FirstOrDefault(p => p.Birthday == parentInput || p.Name == parentInput);

        if (currentPerson == null)
        {
            currentPerson = Person.CreatePerson(parentInput);
            this.FamilyTree.Add(currentPerson);
        }

        SetChild(currentPerson, childInput);
    }

    private  void SetChild(Person parent, string childInput)
    {
        var child = this.FamilyTree.FirstOrDefault(c => c.Name == childInput || c.Birthday == childInput);

        if (child == null)
        {
            child = Person.CreatePerson(childInput);
            this.FamilyTree.Add(child);
        }

        parent.Children.Add(child);
        child.Parents.Add(parent);
    }

    public  void SetFullInfo( string name, string birthday)
    {
        var person = this.FamilyTree.FirstOrDefault(p => p.Name == name || p.Birthday == birthday);
        if (person == null)
        {
            person = new Person();
            this.FamilyTree.Add(person);
        }
        person.Name = name;
        person.Birthday = birthday;

        this.CheckForDuplicate(person);
    }

    private  void CheckForDuplicate( Person person)
    {
        string name = person.Name;
        string birthday = person.Birthday;

        Person duplicate = this.FamilyTree
             .Where(p => p.Name == name || p.Birthday == birthday)
             .Skip(1)
             .FirstOrDefault();

        if (duplicate != null)
        {
            this.RemoveDuplicate(person, duplicate);
        }
    }

    private  void RemoveDuplicate(Person person, Person duplicate)
    { 
        this.FamilyTree.Remove(duplicate);

        person.Parents.AddRange(duplicate.Parents);
        // person.Parents = person.Parents.Distinct().ToList();

        foreach (var parent in duplicate.Parents)
        {
            ReplaceDuplicate(person, duplicate, parent.Children);
        }

        person.Children.AddRange(duplicate.Children);
        // person.Children = person.Children.Distinct().ToList();
        foreach (var child in duplicate.Children)
        {
            ReplaceDuplicate(person, duplicate, child.Parents);
        }
    }

    private static void ReplaceDuplicate(Person original, Person duplicate, List<Person> collection)
    {
        int duplicateIndex = collection.IndexOf(duplicate);
        if (duplicateIndex > -1)
        {
            collection[duplicateIndex] = original;
        }
        else
        {
            collection.Add(original);
        }
    }
}

