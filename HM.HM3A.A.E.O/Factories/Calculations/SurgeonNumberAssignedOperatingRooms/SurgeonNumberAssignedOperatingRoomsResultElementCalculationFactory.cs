namespace HM.HM3A.A.E.O.Factories.Calculations.SurgeonNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using HM.HM3A.A.E.O.Classes.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.Interfaces.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3A.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;

    internal sealed class SurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory : ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElementCalculation Create()
        {
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonNumberAssignedOperatingRoomsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}