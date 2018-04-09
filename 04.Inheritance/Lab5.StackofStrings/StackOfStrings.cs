using System;
using System.Collections.Generic;
using System.Text;

public class StackOfStrings
{
    // ?!?
    private List<string> data = new List<string>();

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        if (this.IsEmpty())
        {
            string result = data[data.Count - 1];
            this.data.RemoveAt(data.Count - 1);
            return result;
        }
        else
        {
            return "";
        }
    }

    public string PeeK()
    {
        if (!this.IsEmpty())
        {
            string result = data[data.Count - 1];
            return result;
        }
        else
        {
            return "";
        }
    }

    public bool IsEmpty()
    {
        return this.data.Count == 0;

    }
}

