using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }
    public string Author
    {
        get { return author; }
        set 
        {
            string[] names = value.Split();
         
           if(names.Length==2 && Char.IsDigit(names[1][0]))   // if (!IsCorectSecondName(value))
            {
                throw new ArgumentException("Author not valid!");
            }
            author = value;
        }
    }
    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }


    private bool IsCorectSecondName(string fullName)
    {
        if (!string.IsNullOrWhiteSpace(fullName))
        {
            var names = fullName.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (names.Length == 2)
            {
                string secondName = names[1];
                var firstLetter = secondName[0];

                return !(char.IsDigit(firstLetter));
            }
            return true;
        }
        else
        {
            return true;// ама то било ок if ISNULL и да няма име, а не го пишат...
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type: {this.GetType().Name}");   // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($"Author: {this.Author}");
        sb.AppendLine($"Price: {this.Price:f2}");

        return sb.ToString().TrimEnd();
    }

}

