namespace HM.HM3A.A.E.O.Classes.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using System.Linq;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsResultElementCalculation : ISurgeonNumberAssignedOperatingRoomsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsResultElementCalculation()
        {
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory surgeonNumberAssignedOperatingRoomsResultElementFactory,
            IsIndexElement sIndexElement,
            Iy y)
        {
            return surgeonNumberAssignedOperatingRoomsResultElementFactory.Create(
                sIndexElement,
                y.Value.Where(i => i.sIndexElement == sIndexElement && i.Value).Select(i => i.rIndexElement).Distinct().Count());
        }
    }
}