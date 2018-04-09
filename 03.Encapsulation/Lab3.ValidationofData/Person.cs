using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    const int minLength = 3;
    const decimal minSalary = 460;

    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }

        set
        {
            if (value < minSalary)
            {
                throw new ArgumentException($"Salary cannot be less than {minSalary} leva!");
            }
            this.salary = value;
        }
    }
    public string FirstName
    {
        get { return this.firstName; }

        set
        {
            if (value.Length <= minLength)
            {
                throw new ArgumentException($"First name cannot contain fewer than {minLength} symbols!");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }

        set
        {
            if (value.Length <= minLength)
            {
                throw new ArgumentException($"Last name cannot contain fewer than {minLength} symbols!");
            }
            this.lastName = value;
        }
    }
    public int Age
    {
        get { return this.age; }

        set
        {
            if(value<=0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this.age = value;
        }
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (Age < 30)
        {
            this.salary = this.salary + salary * percentage / 200;
        }
        else
        {
            this.salary = this.salary + salary * percentage / 100;
        }
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} receives {salary:f2} leva.";
    }
}

