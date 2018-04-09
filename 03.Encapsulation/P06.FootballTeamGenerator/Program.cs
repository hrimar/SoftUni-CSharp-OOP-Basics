using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()      // doobre 83/100
    {
        var teams = new List<Team>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {

            try
            {
                var inputDetails = input.Split(';');
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
                        int endurance = int.Parse(inputDetails[3]);
                        int sprint = int.Parse(inputDetails[4]);
                        int dribble = int.Parse(inputDetails[5]);
                        int passing = int.Parse(inputDetails[6]);
                        int shooting = int.Parse(inputDetails[7]);

                        var stat = new Stat(endurance, sprint, dribble, passing, shooting);
                        if (teams.Any(t => t.Name == teamName))
                        {
                            team = teams.FirstOrDefault(t => t.Name == teamName);
                            var player = new Player(playerName, stat);
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
                            if (team.Players.Any(p => p.Name == playerName))
                            {
                                var player = team.Players.FirstOrDefault(p => p.Name == playerName);
                                team.RemovePlayer(player);
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
                            var skills = team.Players.Sum(p => p.SkillLevel);
                            Console.WriteLine($"{teamName} - {skills}");
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}

