﻿namespace HM.HM3A.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using HM.HM3A.A.E.O.Interfaces.Comparers;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.Indices;

    public interface IjFactory
    {
        Ij Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IjIndexElement> value);
    }
}