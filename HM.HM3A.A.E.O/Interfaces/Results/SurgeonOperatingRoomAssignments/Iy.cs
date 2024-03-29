﻿namespace HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.Comparers;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;

    public interface Iy
    {
        RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> Value { get; }

        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> GetValueForOutputContext(
            ILocationComparerFactory locationComparerFactory,
            IOrganizationComparerFactory organizationComparerFactory,
            INullableValueFactory nullableValueFactory,
            IRedBlackTreeFactory redBlackTreeFactory,
            IyInnerVisitorFactory yInnerVisitorFactory,
            IyOuterVisitorFactory yOuterVisitorFactory);
    }
}