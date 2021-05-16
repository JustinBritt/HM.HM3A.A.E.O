namespace HM.HM3A.A.E.O.Interfaces.ResultElements.MachineOperatingRoomAssignments
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IvResultElement
    {
        ImIndexElement mIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        bool Value { get; }
    }
}