using System;
using System.Collections.Generic;
using System.Text;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string author, string title, decimal price) 
        :base(author, title, price)
    {

    }

    //public override decimal Price //=> this.Price = base.Price * 1.3m;
    //{
    //    get
    //    {
    //        return base.Price * 1.3m;
    //    }
    //}
    // or - може и да увеличим и в set, не непременно в get!
    public override decimal Price
    {
        get => base.Price;
        set => base.Price = value *1.3m;
    }

    //public override string ToString()
    //{
    //    StringBuilder sb = new StringBuilder();
    //    sb.AppendLine($"Type: GoldenEditionBook");
    //    sb.AppendLine($"Title: {this.Title}");
    //    sb.AppendLine($"Author: {this.Author}");
    //    sb.AppendLine($"Price: {this.Price:f2}");

    //    return sb.ToString().TrimEnd();
    //}
}

