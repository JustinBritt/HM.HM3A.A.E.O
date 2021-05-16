namespace HM.HM3A.A.E.O.InterfacesFactories.ResultElements.MachineOperatingRoomAssignments
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments;

    public interface IvResultElementFactory
    {
        IvResultElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            bool value);
    }
}