using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
    private string name;
    private decimal salary;
    private int age;
    private string email;
    private string position;

    public string Position
    {
        get { return this.position; }
        set { this.position = value; }
    }


    //public Employee()
    //{
    //    this.Age = -1;
    //    this.Email = "n/a";
    //}
    //public Employee(string name, decimal salary, string position) : this()
    //{
    //    this.Name = name;
    //    this.Salary = salary;
    //    this.Position = position;
    //}
    // or направо един к-тор с деф ст-сти в него:
    public Employee(string name, decimal salary, string position, int age = -1, string email = "n/a")
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Age = age;
        this.Email = email;
    }


    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public decimal Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

}
