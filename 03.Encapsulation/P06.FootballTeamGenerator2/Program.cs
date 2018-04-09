using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()  // 100/100
    {
        var teams = new List<Team>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {

            try
            {
                var inputDetails = input.Split(';');

                NewMethod(teams, inputDetails);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

    private static void NewMethod(List<Team> teams, string[] inputDetails)
    {
        switch (inputDetails[0])
        {
            case "Team":
                string teamName = inputDetails[1];
                Team team = new Team(teamName);
                teams.Add(team);
                break;
            case "Add":
                teamName = inputDetails[1];
                string playerName = inputDetails[2];
                double endurance = double.Parse(inputDetails[3]);
                double sprint = double.Parse(inputDetails[4]);
                double dribble = double.Parse(inputDetails[5]);
                double passing = double.Parse(inputDetails[6]);
                double shooting = double.Parse(inputDetails[7]);

                if (teams.Any(t => t.Name == teamName))
                {
                    team = teams.FirstOrDefault(t => t.Name == teamName);
                    var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                    team.AddPlayer(player);
                    teams.Add(team);
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                }
                break;
            case "Remove":
                teamName = inputDetails[1];
                playerName = inputDetails[2];
                if (teams.Any(t => t.Name == teamName))
                {
                    team = teams.FirstOrDefault(t => t.Name == teamName);
                    if (team.IsPlayerFound(playerName))
                    {
                        team.RemovePlayer(playerName);
                    }
                    else
                    {
                        Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                }

                break;
            case "Rating":
                teamName = inputDetails[1];
                if (teams.Any(t => t.Name == teamName))
                {
                    team = teams.FirstOrDefault(t => t.Name == teamName);
                    var skills = team.GetRating();
                    //var skills = team.Players.Sum(p => p.SkillLevel);
                    Console.WriteLine($"{teamName} - {skills:f0}");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                }
                break;
        }
    }
}

