namespace HM.HM3A.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface IHM3AOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Device, Location, INullableValue<bool>>> MachineOperatingRoomAssignments { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgicalSpecialtyOperatingRoomAssignments { get; }

        ImmutableList<Tuple<Organization, Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }
    }
}