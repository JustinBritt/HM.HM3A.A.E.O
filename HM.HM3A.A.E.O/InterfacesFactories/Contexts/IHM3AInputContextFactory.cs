namespace HM.HM3A.A.E.O.InterfacesFactories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.Contexts;
    
    public interface IHM3AInputContextFactory
    {
        IHM3AInputContext Create(
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            Bundle machines,
            Bundle operatingRooms,
            Bundle surgeons,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> planningHorizon,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgicalSpecialtyNumberAssignedTimeBlocks,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonNumberAssignedTimeBlocks,
            RedBlackTree<Device, Money> machineCosts,
            ImmutableList<Tuple<Organization, Device, INullableValue<bool>>> surgeonMachineRequirements,
            RedBlackTree<FhirDateTime, INullableValue<bool>> dayAvailabilities);
    }
}