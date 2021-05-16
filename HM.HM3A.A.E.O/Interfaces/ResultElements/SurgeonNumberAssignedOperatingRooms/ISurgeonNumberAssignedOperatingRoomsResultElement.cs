namespace HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;

    public interface ISurgeonNumberAssignedOperatingRoomsResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}