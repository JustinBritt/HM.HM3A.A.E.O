namespace HM.HM3A.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;   

    public interface ISurgeonNumberAssignedOperatingRoomsCalculation
    {
        ISurgeonNumberAssignedOperatingRooms Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            ISurgeonNumberAssignedOperatingRoomsFactory surgeonNumberAssignedOperatingRoomsFactory,
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculation surgeonNumberAssignedOperatingRoomsResultElementCalculation,
            Is s,
            Iy y);
    }
}