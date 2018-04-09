using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{

    private int engineSpeed; 
    private int enginePower;

    

    public Engine()
    {
    }
    public Engine(int engineSpeed, int enginePower)
    {        
        this.EngineSpeed = engineSpeed;
        this.enginePower = enginePower;
    }


    public int EngineSpeed
    {
        get { return engineSpeed; }
        set { engineSpeed = value; }
    }

    public int Enginepower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }
}

