﻿namespace HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    public interface Iw
    {
        RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> Value { get; }

        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory);
    }
}