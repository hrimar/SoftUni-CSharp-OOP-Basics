using System;
using System.Collections.Generic;
using System.Text;

public class Team
{
    private List<Player> players;
    private string name;
    public double Raiting { get; set; } // calc and INT


    public Team(string name)
    {
        this.Players = new List<Player>();
        this.Name = name;
    }
    public string Name  
    {
        get { return  name; }
        set
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }
    public List<Player> Players
    {
        get { return players; }
        private set { players = value; }
    }


    public void AddPlayer(Player player)
    {
        if(player!=null)
        {
            this.players.Add(player);
        }
    }

    public void RemovePlayer(Player player)
    {
        if (players.Count > 0)
        {            
            this.players.Remove(player);
        }
    }

}

