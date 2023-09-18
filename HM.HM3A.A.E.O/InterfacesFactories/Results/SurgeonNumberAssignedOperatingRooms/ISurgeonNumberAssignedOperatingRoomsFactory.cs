namespace HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    
    public interface ISurgeonNumberAssignedOperatingRoomsFactory
    {
        ISurgeonNumberAssignedOperatingRooms Create(
            RedBlackTree<IsIndexElement, ISurgeonNumberAssignedOperatingRoomsResultElement> value);
    }
}