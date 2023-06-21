namespace HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iw
    {
        RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> Value { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}