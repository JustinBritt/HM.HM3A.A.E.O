namespace HM.HM3A.A.E.O.InterfacesFactories.Contexts
{
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
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            RedBlackTree<Organization, INullableValue<int>> surgicalSpecialtyNumberAssignedTimeBlocks,
            RedBlackTree<Organization, INullableValue<int>> surgeonNumberAssignedTimeBlocks,
            RedBlackTree<Device, Money> machineCosts,
            RedBlackTree<Organization, RedBlackTree<Device, INullableValue<bool>>> surgeonMachineRequirements,
            RedBlackTree<FhirDateTime, INullableValue<bool>> dayAvailabilities);
    }
}