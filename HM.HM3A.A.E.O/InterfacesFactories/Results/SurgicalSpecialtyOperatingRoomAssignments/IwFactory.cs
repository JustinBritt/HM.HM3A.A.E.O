namespace HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyOperatingRoomAssignments
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IwFactory
    {
        Iw Create(
            RedBlackTree<IjIndexElement, RedBlackTree<IrIndexElement, IwResultElement>> value);
    }
}