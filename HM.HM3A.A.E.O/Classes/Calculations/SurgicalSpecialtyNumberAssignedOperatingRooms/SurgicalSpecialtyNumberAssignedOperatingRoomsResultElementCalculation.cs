namespace HM.HM3A.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System.Linq;

    using log4net;

    using HM.HM3A.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.IndexElements;
    using HM.HM3A.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3A.A.E.O.Interfaces.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3A.A.E.O.Interfaces.Results.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3A.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation : ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            IΔParameterElement ΔParameterElement,
            Iy y)
        {
            return surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory.Create(
                ΔParameterElement.jIndexElement,
                ΔParameterElement.Value.SelectMany(a => y.Value[a].Where(i => i.Value.Value).Select(w => w.Key)).Distinct().Count());
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory,
            IjIndexElement jIndexElement,
            Iw w)
        {
            return surgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory.Create(
                jIndexElement,
                w.Value[jIndexElement].Where(i => i.Value.Value).Select(i => i.Key).Distinct().Count());
        }
    }
}