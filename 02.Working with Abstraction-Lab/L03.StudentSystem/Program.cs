using System;


class Program
{
    static void Main()
    {
        // 100/100 - полезен пример!!!

        // Стар вариант за рефакториране:
        //StudentSystem studentSystem = new StudentSystem();
        //while (true)
        //{
        //    studentSystem.ParseCommand();
        //}

        // Нов вариант:
        var studentSystem = new StudentSystem();
        string command; 
        while ((command = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(command, Console.WriteLine); // !!!!
        }
    }
}

