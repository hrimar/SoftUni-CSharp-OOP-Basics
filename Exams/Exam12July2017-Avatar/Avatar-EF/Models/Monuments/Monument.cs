
public abstract class Monument: INation
{
    public abstract string Type { get; }

    public string Name { get;protected set; }

    protected Monument(string name)
    {
        this.Name = name;

    }

    public abstract int GetBonus();

    public override string ToString()
    {
        return $"###{this.Type} Monument: {this.Name}, ";
    }
}