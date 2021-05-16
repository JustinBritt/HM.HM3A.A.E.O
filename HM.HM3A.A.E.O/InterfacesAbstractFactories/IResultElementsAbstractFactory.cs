namespace HM.HM3A.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.MachineOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IResultElementsAbstractFactory
    {
        ISurgeonNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory();

        IvResultElementFactory CreatevResultElementFactory();

        IwResultElementFactory CreatewResultElementFactory();

        IyResultElementFactory CreateyResultElementFactory();
    }
}