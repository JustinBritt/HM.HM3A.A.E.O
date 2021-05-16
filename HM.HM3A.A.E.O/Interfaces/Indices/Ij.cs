﻿namespace HM.HM3A.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface Ij
    {
        ImmutableList<IjIndexElement> Value { get; }

        IjIndexElement GetElementAt(
            Organization value);
    }
}