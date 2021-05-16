namespace HM.HM3A.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;

    internal sealed class SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory : ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation Create()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}