﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;


    public Person()   { }

    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;
        this.accounts = new List<BankAccount>();
    }

    public Person(string name, int age, List<BankAccount> accounts) : this(name, age)
    {
        this.accounts = accounts;
    }

    //public string Name
    //{
    //    get { return this.name; }
    //    set { this.name = value; }
    //}

    //public int Age
    //{
    //    get { return this.age; }
    //    set { this.age = value; }
    //}

    //public List<BankAccount> Accounts
    //{
    //    get { return this.accounts; }
    //    set { this.accounts = value; }
    //}

    public decimal GetBalance()
    {
        return this.accounts.Sum(a => a.Balance);
    }

}

