namespace HM.HM3A.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3A.A.E.O.Classes.Contexts;
    using HM.HM3A.A.E.O.Interfaces.Contexts;
    using HM.HM3A.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM3AInputContextFactory : IHM3AInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3AInputContextFactory()
        {
        }

        public IHM3AInputContext Create(
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
            IHM3AInputContext context = null;

            try
            {
                context = new HM3AInputContext(
                    surgicalSpecialties,
                    machines,
                    operatingRooms,
                    surgeons,
                    planningHorizon,
                    surgicalSpecialtyNumberAssignedTimeBlocks,
                    surgeonNumberAssignedTimeBlocks,
                    machineCosts,
                    surgeonMachineRequirements,
                    dayAvailabilities);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return context;
        }
    }
}