﻿namespace HM.HM3A.A.E.O.Interfaces.Contexts
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;
    using NGenerics.DataStructures.Trees;

    public interface IHM3AInputContext
    {
        RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        Bundle Machines { get; }

        Bundle OperatingRooms { get; }

        Bundle Surgeons { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonNumberAssignedTimeBlocks { get; }

        RedBlackTree<Device, Money> MachineCosts { get; }

        RedBlackTree<Organization, RedBlackTree<Device, INullableValue<bool>>> SurgeonMachineRequirements { get; }

        RedBlackTree<FhirDateTime, INullableValue<bool>> DayAvailabilities { get; }
    }
}