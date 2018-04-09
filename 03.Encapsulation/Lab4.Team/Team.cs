using System;
using System.Collections.Generic;
using System.Text;

public class Team
{
    const int MinAge = 40;

    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

   
    public Team(string name)
    {
        this.Name = name;           // !!!!
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public IReadOnlyCollection<Person> ReserveTeam //  за да не можем да казваме от вън firstTeam.Clear()
    {
        get { return reserveTeam.AsReadOnly(); }
        // private set { reserveTeam = value; }
    }

    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return firstTeam.AsReadOnly(); }
        //private set { firstTeam = value; } - махане го зада не може  team.FirstTeam.Add(person);
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }


    public void AddPlayer(Person person)
    {
        if (person.Age < MinAge)
        {            
            this.firstTeam.Add(person);
        }
        else
        {
            this.reserveTeam.Add(person);
        }
    }

    public override string ToString()
    {
        return $"First team has {this.firstTeam.Count} players." + Environment.NewLine +
            $"Reserve team has {this.reserveTeam.Count} players.";
    }
}

