using System;
using System.Collections.Generic;
using System.Linq;

class Program   // 100/100
{
    private static void Main()
    {
        string input;
        var trainers = new Dictionary<string, Trainer>();
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var info = input.Split();
            var trainerName = info[0];
            var pokemonName = info[1];
            var pokemonElement = info[2];
            var pokemonHealth = int.Parse(info[3]);

            if (!trainers.ContainsKey(trainerName))
            {
                trainers.Add(trainerName, new Trainer(trainerName, new List<Pokemon>()));
            }

            var pokemonList = trainers[trainerName].PokemonsList;
            var currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            pokemonList.Add(currentPokemon);
        }
        while ((input = Console.ReadLine()) != "End")
        {
            CheckPokemons(trainers, input);
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Value.NumberBadges))
        {
            Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberBadges} {trainer.Value.PokemonsList.Count}");
        }
    }

    private static void CheckPokemons(Dictionary<string, Trainer> trainers, string input)
    {
        foreach (var trainer in trainers)
        {
            var trainerPokemonList = trainer.Value.PokemonsList;
            if (trainerPokemonList.Count == 0)
            {
                continue;
            }
            if (trainerPokemonList.Exists(p => p.Element == input))
            {
                trainer.Value.NumberBadges++;
            }
            else
            {
                var pokemonsToDelete = new List<Pokemon>();
                foreach (var pokemon in trainerPokemonList)
                {
                    pokemon.Health -= 10;
                    if (pokemon.Health <= 0)
                    {
                        pokemonsToDelete.Add(pokemon);
                    }
                }
                if (pokemonsToDelete.Count != 0)
                {
                    foreach (var pokemon in pokemonsToDelete)
                    {
                        trainerPokemonList.Remove(pokemon);
                    }
                }
            }
        }
    }
}

