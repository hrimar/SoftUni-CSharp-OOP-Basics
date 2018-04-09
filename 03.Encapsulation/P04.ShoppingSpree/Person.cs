using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> productsBag;


    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.ProductsBag = new List<Product>();
    }

    public List<Product> ProductsBag
    {
        get { return productsBag; }
        private set { productsBag = value; }
    }

    public decimal Money
    {
        get { return money; }
      set
        {
            if (value < 0)  // !!!!!!!!!!!!!
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }// private
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public void AddProducts(Product product)
    {
        this.productsBag.Add(product);
    }

    //public Person BuyProduct(Product product)
    //{

    //    return 
    //}

    //public override string ToString()
    //{
    //    return $"{this.Name} - " + string.Join(", ", this.ProductsBag);
    //}
}

