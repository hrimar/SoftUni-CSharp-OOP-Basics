using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)//
    {
        this.Name = name;
        this.Price = price;
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            Validator.ValidateMoney(value);
            price = value;
        }// private
    }

    public string Name
    {
        get { return name; }
        set
        {
            Validator.ValidateName(value);
            name = value;
        }
    }


    public override string ToString()
    {
        return this.Name; // Smart!!!
    }
}

