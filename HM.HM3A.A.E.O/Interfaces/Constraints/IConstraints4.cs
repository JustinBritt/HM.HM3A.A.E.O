﻿namespace HM.HM3A.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints4
    {
        ImmutableList<IConstraints4ConstraintElement> Value { get; }
    }
}