namespace HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Iv
    {
        RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> Value { get; }

        ImmutableList<Tuple<Device, Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}