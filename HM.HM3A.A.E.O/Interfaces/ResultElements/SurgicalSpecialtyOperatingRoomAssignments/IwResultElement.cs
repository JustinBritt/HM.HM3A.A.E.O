namespace HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IwResultElement
    {
        IjIndexElement jIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        bool Value { get; }
    }
}