namespace HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory
    {
        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Create(
            IjIndexElement jIndexElement,
            int value);
    }
}