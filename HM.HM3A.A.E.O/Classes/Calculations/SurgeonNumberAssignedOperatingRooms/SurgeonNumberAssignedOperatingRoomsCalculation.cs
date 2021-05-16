namespace HM.HM3A.A.E.O.Classes.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Indices;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsCalculation : ISurgeonNumberAssignedOperatingRoomsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsCalculation()
        {
        }

        public ISurgeonNumberAssignedOperatingRooms Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            ISurgeonNumberAssignedOperatingRoomsFactory surgeonNumberAssignedOperatingRoomsFactory,
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculation surgeonNumberAssignedOperatingRoomsResultElementCalculation,
            Is s,
            Iy y)
        {
            return surgeonNumberAssignedOperatingRoomsFactory.Create(
                s.Value
                .Select(w => surgeonNumberAssignedOperatingRoomsResultElementCalculation.Calculate(
                    surgeonNumberAssignedOperatingRoomsResultElementFactory,
                    w,
                    y))
                .ToImmutableList());
        }
    }
}