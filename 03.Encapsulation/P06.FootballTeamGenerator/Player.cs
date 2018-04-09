using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    private string name;
    private Stat stat;
   

    public Player(string name, Stat stat)
    {
        this.Stat = stat;
        this.Name = name;
    }


    public int SkillLevel => stat.CalcAverageStats(); // private
   
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }
    public Stat Stat
    {
        get { return stat; }
        set
        {
            stat = value;
        }
    }



}

