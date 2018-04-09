using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{

    private bool isRunning = true;
    private NationsBuilder builder;

    public Engine()
    {
        this.builder = new NationsBuilder();

    }

    public void Run()
    {
        
        while (isRunning)
        {
            var cmdArgs = Console.ReadLine().Split(' ').ToList();
            var command = cmdArgs[0];
            cmdArgs.RemoveAt(0);

            switch (command)
            {
                case "Bender":
                    builder.AssignBender(cmdArgs);
                    break;
                case "Monument":
                    builder.AssignMonument(cmdArgs);
                    break;
                case "Status":
                    Console.WriteLine(builder.GetStatus(cmdArgs[0]));
                    break;
                case "War":
                    builder.IssueWar(cmdArgs[0]);
                    break;
                case "Quit":
                    Console.WriteLine(builder.GetWarsRecord());
                    isRunning = false;
                    break;
            }
        }

        
    }
}

