namespace HM.HM3A.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonNumberAssignedOperatingRooms
    {
        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}