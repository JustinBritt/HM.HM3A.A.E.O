namespace HM.HM3A.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsCalculation : ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRooms Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory surgicalSpecialtyNumberAssignedOperatingRoomsFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation,
            IΔ Δ,
            Iy y)
        {
            return surgicalSpecialtyNumberAssignedOperatingRoomsFactory.Create(
                Δ.Value
                .Select(i => surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation.Calculate(
                    surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
                    i,
                    y))
                .ToImmutableList());
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRooms Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory surgicalSpecialtyNumberAssignedOperatingRoomsFactory,
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation,
            Ij j,
            Iw w)
        {
            return surgicalSpecialtyNumberAssignedOperatingRoomsFactory.Create(
                j.Value.Values
                .Select(i => surgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation.Calculate(
                    surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
                    i,
                    w))
                .ToImmutableList());
        }
    }
}