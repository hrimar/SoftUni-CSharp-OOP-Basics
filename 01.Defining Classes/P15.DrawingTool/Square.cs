using System;
using System.Collections.Generic;
using System.Text;

public class Square
{
    public int Size { get; set; }
    

    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            if (i == 0 || i == size - 1)
            {
                Console.WriteLine($"|{new string('-', size)}|");
            }
            else
            {
                Console.WriteLine($"|{new string(' ', size)}|");
            }
        }
        // Ама нали уж не беше добре да се принтира с cw ot tuk ?!?!
    }

}

