using System;
using System.Collections.Generic;
using System.Text;

public class Trainer
{
    private string name;
    private int numberBadges = 0;
    private List<Pokemon> pokemonsList;

    public Trainer()
    {
        this.PokemonsList = new List<Pokemon>();
    }
    public Trainer(string name) :this()
    {
        this.Name = name;
    }
    public Trainer(string name, List<Pokemon> pokemonsList)
    {
        this.Name = name;
        this.NumberBadges = 0;
        this.PokemonsList = pokemonsList;
    }


    public List<Pokemon> PokemonsList
    {
        get { return pokemonsList; }
        set { pokemonsList = value; }
    }

    public int NumberBadges
    {
        get { return numberBadges; }
        set { numberBadges = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

