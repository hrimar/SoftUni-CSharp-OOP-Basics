using BashSoft;
using System;

public class InputReader
{
    private const string endCommand = "quit";
    private CommandInterpreter interpreter;

    public InputReader(CommandInterpreter interpreter)
    {
        this.interpreter = interpreter;
    }

    public void StartReadingCommands()
    {
        OutputWriter.WriteMessage($"{SessionsData.currentPath}> ");
        string input = Console.ReadLine();
        input = input.Trim();

        while (input != endCommand)
        {
            this.interpreter.InterpredCommand(input);
            OutputWriter.WriteMessage($"{SessionsData.currentPath}> ");
            input = Console.ReadLine();
            input = input.Trim();
        }
    }
}
