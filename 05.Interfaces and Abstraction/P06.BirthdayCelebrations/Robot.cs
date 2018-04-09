using System;
using System.Collections.Generic;
using System.Text;

public class Robot : IRobot, IBase
{
    public string Name { get; private set; }

    public string Id { get; private set; }

   
    public Robot(string model, string id)
    {
        this.Name = model;
        this.Id = id;
    }
}

