namespace HM.HM3A.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Contexts;

    public sealed class HM3AInputContext : IHM3AInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AInputContext(
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            Bundle machines,
            Bundle operatingRooms,
            Bundle surgeons,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            RedBlackTree<Organization, INullableValue<int>> surgicalSpecialtyNumberAssignedTimeBlocks,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberAssignedTimeBlocks,
            RedBlackTree<Device, Money> machineCosts,
            RedBlackTree<Organization, RedBlackTree<Device, INullableValue<bool>>> surgeonMachineRequirements,
            RedBlackTree<FhirDateTime, INullableValue<bool>> dayAvailabilities)
        {
            this.SurgicalSpecialties = surgicalSpecialties;

            this.Machines = machines;

            this.OperatingRooms = operatingRooms;

            this.Surgeons = surgeons;

            this.PlanningHorizon = planningHorizon;

            this.SurgicalSpecialtyNumberAssignedTimeBlocks = surgicalSpecialtyNumberAssignedTimeBlocks;

            this.SurgeonNumberAssignedTimeBlocks = surgeonNumberAssignedTimeBlocks;

            this.MachineCosts = machineCosts;

            this.SurgeonMachineRequirements = surgeonMachineRequirements;

            this.DayAvailabilities = dayAvailabilities;
        }

        public RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        public Bundle Machines { get; }

        public Bundle OperatingRooms { get; }

        public Bundle Surgeons { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberAssignedTimeBlocks { get; }

        public RedBlackTree<Device, Money> MachineCosts { get; }

        public RedBlackTree<Organization, RedBlackTree<Device, INullableValue<bool>>> SurgeonMachineRequirements { get; }

        public RedBlackTree<FhirDateTime, INullableValue<bool>> DayAvailabilities { get; }
    }
}