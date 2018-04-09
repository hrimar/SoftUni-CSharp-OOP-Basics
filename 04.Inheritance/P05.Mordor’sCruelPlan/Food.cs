using System;

public abstract class Food  // ABSTRACT !!!
{
    private int pointsOfHappiness;

    protected Food(int pointsOfHappiness)
    {
        this.PointsOfHappines = pointsOfHappiness;
    }

    public virtual int PointsOfHappines
    {
        get { return this.pointsOfHappiness; }
        set { this.pointsOfHappiness = value; }
    }
}