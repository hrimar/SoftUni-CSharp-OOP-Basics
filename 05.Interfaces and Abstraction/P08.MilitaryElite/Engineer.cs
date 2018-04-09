using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private ICollection<IRepair> repairs;

    public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new List<IRepair>();
    }

    public IReadOnlyCollection<IRepair> Repairs => (IReadOnlyCollection<IRepair>)repairs;

    public void AddRepair(IRepair repair)
    {
        repairs.Add(repair);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine($"{nameof(this.Corps)}: {this.Corps.ToString()}") // щот е enum!
            .AppendLine($"{nameof(this.Repairs)}:");

        foreach (var repair in this.Repairs)
        {
            builder.AppendLine($"  {repair.ToString()}");
        }
        string result = builder.ToString().TrimEnd();
        return result;
    }
}

