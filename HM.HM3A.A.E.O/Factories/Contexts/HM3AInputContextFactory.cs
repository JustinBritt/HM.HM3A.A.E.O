namespace HM.HM3A.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

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
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}