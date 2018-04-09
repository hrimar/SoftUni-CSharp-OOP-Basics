using System;
using System.Collections.Generic;
using System.Text;

public class StudentSystem
{
    private Dictionary<string, Student> repo;

    public StudentSystem()
    {
        this.repo = new Dictionary<string, Student>();
    }

    //public Dictionary<string, Student> Repo
    //{
    //    get { return repo; }
    //    private set { repo = value; }
    //}

    public void ParseCommand(string command, Action<string> printFunction)
    {
        string[] args =command.Split();

        if (args[0] == "Create")
        {
            Create(args[1], args[2], args[3]);
        }
        else if (args[0] == "Show")
        {
           var studentName=args[1];
            if (repo.ContainsKey(studentName))
            {
                //Console.WriteLine(repo[studentName]); //  не е добре да се принти тук!!
                printFunction(repo[studentName].ToString());
            }
        }
    }      

    private void Create(string name, string ageString, string gradeString)
    {        
        var age = int.Parse(ageString);
        var grade = double.Parse(gradeString);
        if (!repo.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            repo[name] = student;
        }
    }
}
