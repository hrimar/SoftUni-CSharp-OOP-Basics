using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private bool isRunning;
    public DraftManager Manager { get; set; }

    public Engine()
    {
        this.Manager = new DraftManager();
    }
    public void Run()
    {
        while (this.isRunning)
        {
            string input = Console.ReadLine();
            var inputArgs = input.Split().ToList();
            var command = inputArgs[0];
            var arguments = inputArgs.Skip(1).ToList();

            switch (command)
            {
                // махни типа на командата като я подавам на методите!!!!!!!!!!!!!!!!!!
                case "RegisterHarvester":
                    Console.WriteLine(this.Manager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(this.Manager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(this.Manager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(this.Manager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(this.Manager.Check(arguments));
                    break;
                case "Shutdown":
                    isRunning = false;
                    break;
            }

        }


    }
}

