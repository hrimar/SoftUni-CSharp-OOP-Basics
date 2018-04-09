using System;
using System.Collections.Generic;
using System.Text;

public class Human
{
    private string firstName;
    private string lastName;

    private const int MIN_NAME_LENGTH = 4;
    private const int MIN_LAST_NAME_LENGTH = 3;
    private const string LengthERROR = "Expected length at least {0} symbols! Argument: {1}";
    private const string CapitalLetterERROR = "Expected upper case letter! Argument: {0}";

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            //if (!String.IsNullOrWhiteSpace(value)) -  това не се казва и не се иска????!?!!!
           
                //if ( value.Length>1 && !Char.IsUpper(value[0]))
                //{
                //    throw new ArgumentException($"Expected upper case letter! Argument: firstName");
                //}
                //if( value.Length < MIN_NAME_LENGTH)
                //{
                //    throw new ArgumentException($"Expected length at least {MIN_NAME_LENGTH} symbols! Argument: firstName");
                //}
                ValidateName(value, nameof(firstName), MIN_NAME_LENGTH);    // !!!!!!!!!!!!!!!
          
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {            
            //    if (value.Length < MIN_LAST_NAME_LENGTH)
            //    {
            //        throw new ArgumentException($"Expected length at least {MIN_LAST_NAME_LENGTH} symbols! Argument: lastName ");
            //    }
            //    if (!Char.IsUpper(value[0]))
            //    {
            //        throw new ArgumentException($"Expected upper case letter! Argument: lastName");
            //    }
            
            ValidateName(value, nameof(lastName), MIN_LAST_NAME_LENGTH);    // !!!!!!!!!!!!!!!
            lastName = value;
        }
    }

    private static void ValidateName(string value, string type, int minLength)
    {
        if (Char.IsLower(value[0]))
        {
            throw new ArgumentException(string.Format(CapitalLetterERROR, type));
        }
        if (value.Length < minLength)
        {
            throw new ArgumentException(string.Format(LengthERROR , minLength, type)); // !!!!!
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");

        return sb.ToString().TrimEnd();
    }
}

