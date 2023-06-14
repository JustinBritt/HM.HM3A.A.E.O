namespace HM.HM3A.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;
    using NGenerics.DataStructures.Trees;

    public interface IHM3AInputContext
    {
        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        Bundle Machines { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberAssignedTimeBlocks { get; }

        ImmutableList<KeyValuePair<Device, Money>> MachineCosts { get; }

        ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> SurgeonMachineRequirements { get; }

        RedBlackTree<FhirDateTime, INullableValue<bool>> DayAvailabilities { get; }
    }
}