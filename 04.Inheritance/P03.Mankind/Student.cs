using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    private const string FacultyNubberPattern = @"^[a-zA-Z\d]{5,10}$"; // !!!

    private string facultyNumber;

    
    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            //var regex = new Regex(@"^[a-zA-Z0-9]{5,10}$");
            //var match = regex.Match(value);
            //if(!match.Success)
            if(!Regex.IsMatch(value, FacultyNubberPattern))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine($"Faculty number: {this.FacultyNumber}");

        return sb.ToString().TrimEnd();
    }
}

