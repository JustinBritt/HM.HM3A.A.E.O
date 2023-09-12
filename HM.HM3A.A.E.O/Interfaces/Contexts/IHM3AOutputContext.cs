namespace HM.HM3A.A.E.O.Interfaces.Contexts
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IHM3AOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedOperatingRooms { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        RedBlackTree<Device, RedBlackTree<Location, INullableValue<bool>>> MachineOperatingRoomAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgicalSpecialtyOperatingRoomAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }
    }
}