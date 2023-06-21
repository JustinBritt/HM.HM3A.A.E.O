namespace HM.HM3A.A.E.O.InterfacesFactories.Results.MachineOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.MachineOperatingRoomAssignments;

    public interface IvFactory
    {
        Iv Create(
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvResultElement>> value);
    }
}