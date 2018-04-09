using System;
using System.Collections.Generic;
using System.Text;

public class Worker : Human
{
    private const int WORKING_DAYS = 5;
    private const string ERROR = "Expected value mismatch! Argument: {0}";

    private decimal weekSalary;
    private double workHoursPerDay;

    public decimal MoneyPerHour => (this.WeekSalary / (decimal)(WORKING_DAYS * WorkHoursPerDay));

    public Worker(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
        : this(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException(string.Format(ERROR, nameof(weekSalary)));  // !!
            }
            weekSalary = value;
        }
    }
    public double WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException(string.Format(ERROR, nameof(workHoursPerDay)));
            }
            workHoursPerDay = value;
        }
    }



    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");       // ?
        sb.AppendLine($"Salary per hour: {this.MoneyPerHour:f2}");
        return sb.ToString().TrimEnd();
    }
}

