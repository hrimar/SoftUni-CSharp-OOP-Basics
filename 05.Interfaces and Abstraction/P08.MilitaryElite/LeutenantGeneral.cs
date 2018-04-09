﻿using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private ICollection<ISoldier> privates;

    public LeutenantGeneral(int id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName, salary)
    {
        privates = new List<ISoldier>();
    }

    public IReadOnlyCollection<ISoldier> Privates => (IReadOnlyCollection<ISoldier>)this.privates;

    public void AddPrivate(ISoldier soldier)
    {
        this.privates.Add(soldier);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine($"{nameof(this.Privates)}:");

        foreach (var @private in this.Privates)
        {
            builder.AppendLine($"  {@private.ToString()}");
        }
        string result = builder.ToString().TrimEnd();
        return result;
    }
}

