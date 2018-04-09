using System;
using System.Collections.Generic;
using System.Text;

public class Stat
{
    private const int MAX_STATVALUE=100;

    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;


    public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }

    public int Endurance
    {
        get { return endurance; }
        set
        {
            ValidateStats("Endurance", value);
            endurance = value;
        }
    }
    public int Sprint
    {
        get { return sprint; }
        set
        {
            ValidateStats("Sprint", value);
            sprint = value;
        }
    }
    public int Dribble
    {
        get { return dribble; }
        set
        {
            ValidateStats("Dribble", value);
            dribble = value;
        }
    }
    public int Passing
    {
        get { return passing; }
        set
        {
            ValidateStats("Passing", value);
            passing = value;
        }
    }
    public int Shooting
    {
        get { return shooting; }
        set
        {
            ValidateStats("Shooting", value);
            shooting = value;
        }
    }


    private static void ValidateStats(string statName, int statValue)
    {
        if(statValue<0 || statValue>100)
        {
            throw new ArgumentException($"{statName} should be between 0 and {MAX_STATVALUE}.");
        }
    }

    public int CalcAverageStats()
    {
        var result = (int)Math.Round((this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint) / (double)5); 

        return result;
    }
}

