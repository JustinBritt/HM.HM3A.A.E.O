namespace HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface IyResultElement
    {
        IsIndexElement sIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        bool Value { get; }
    }
}