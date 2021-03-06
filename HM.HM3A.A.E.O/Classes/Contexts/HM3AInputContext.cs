namespace HM.HM3A.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Interfaces.Contexts;

    public sealed class HM3AInputContext : IHM3AInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AInputContext(
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> surgicalSpecialties,
            Bundle machines,
            Bundle operatingRooms,
            Bundle surgeons,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgicalSpecialtyNumberAssignedTimeBlocks,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberAssignedTimeBlocks,
            ImmutableList<KeyValuePair<Device, Money>> machineCosts,
            ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> surgeonMachineRequirements,
            ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> dayAvailabilities)
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

        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        public Bundle Machines { get; }

        public Bundle OperatingRooms { get; }

        public Bundle Surgeons { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> PlanningHorizon { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedTimeBlocks { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonNumberAssignedTimeBlocks { get; }

        public ImmutableList<KeyValuePair<Device, Money>> MachineCosts { get; }

        public ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> SurgeonMachineRequirements { get; }

        public ImmutableList<KeyValuePair<FhirDateTime, INullableValue<bool>>> DayAvailabilities { get; }
    }
}