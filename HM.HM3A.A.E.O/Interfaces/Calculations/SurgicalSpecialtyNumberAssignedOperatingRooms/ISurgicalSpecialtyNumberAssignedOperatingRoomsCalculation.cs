namespace HM.HM3A.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;

    public interface ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculation
    {
        ISurgicalSpecialtyNumberAssignedOperatingRooms Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory surgicalSpecialtyNumberAssignedOperatingRoomsFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation,
            IΔ Δ,
            Iy y);

        ISurgicalSpecialtyNumberAssignedOperatingRooms Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory surgicalSpecialtyNumberAssignedOperatingRoomsFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation,
            Ij j,
            Iw w);
    }
}